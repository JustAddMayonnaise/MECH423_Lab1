﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialReaderSuperSimple
{
    public partial class frmMainWindow : Form
    {
        ConcurrentQueue<byte[]> outputDataQueue = new ConcurrentQueue<byte[]>();
        ConcurrentQueue<int> xAxisQueue = new ConcurrentQueue<int>();
        ConcurrentQueue<int> yAxisQueue = new ConcurrentQueue<int>();
        ConcurrentQueue<int> zAxisQueue = new ConcurrentQueue<int>();
        byte[] readBytes;
        byte[] removedItemInDataQueue;
        int removedItemInXAxisQueue;
        int removedItemInYAxisQueue;
        int removedItemInZAxisQueue;
        int MAX_AVERAGE_N = 100;
        int ORIENTATION_AVERAGE_N = 10;
        int GRAVITY_CALIBRATION_NUM = 30;
        int lastN;

        ConcurrentQueue<int> bytesToReadQueue = new ConcurrentQueue<int>();
        int removedBytesToRead;
        int byteSequence = 0;

        public frmMainWindow()
        {
            InitializeComponent();
            readBytes = new byte[serCOM.ReadBufferSize];
            serCOM.BaudRate = 128000;
            serCOM.DataBits = 8;
            serCOM.StopBits = System.IO.Ports.StopBits.One;
            serCOM.Parity = System.IO.Ports.Parity.None;

            lastN = MAX_AVERAGE_N - ORIENTATION_AVERAGE_N;

        }

        private void cmbbxCOMPorts_DropDown(object sender, EventArgs e)
        {
            string[] COMPortNames = System.IO.Ports.SerialPort.GetPortNames().ToArray();
            cmbbxCOMPorts.Items.Clear();
            for (int cntr = 0; cntr < COMPortNames.Length; cntr++)
                cmbbxCOMPorts.Items.Add(COMPortNames[cntr]);
        }

        private void btnConnectDisconnect_Click(object sender, EventArgs e)
        {
            if(serCOM.IsOpen)
            {
                lock (serCOM) serCOM.Close();             // Mutex on the serial port
                btnConnectDisconnect.Text = "Connect";
                lstbxSerParam.Items.Clear();
                cmbbxCOMPorts.Enabled = true;
                tmrSerRead.Enabled = false;
				
                txtXAxis.Clear();                        // Clear txtXAxis box
                txtYAxis.Clear();                        //
                txtZAxis.Clear();                        //
            }
            else
            {
                if(!string.IsNullOrWhiteSpace(cmbbxCOMPorts.Text))
                {
                    serCOM.PortName = cmbbxCOMPorts.Text;
                    serCOM.Open();
                    btnConnectDisconnect.Text = "Disconnect";
                    lstbxSerParam.Items.Add("Baud Rate: " + serCOM.BaudRate.ToString());
                    lstbxSerParam.Items.Add("Data Bits: " + serCOM.DataBits.ToString());
                    lstbxSerParam.Items.Add("Stop bit: " + serCOM.StopBits.ToString());
                    lstbxSerParam.Items.Add("Parity: " + serCOM.Parity.ToString());
                    lstbxSerParam.Items.Add("Read Buffer Size: " + serCOM.ReadBufferSize.ToString());
                    lstbxSerParam.Items.Add("Received Bytes Threshold: " + serCOM.ReceivedBytesThreshold.ToString());
                    cmbbxCOMPorts.Enabled = false;
                    tmrSerRead.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No COM port selected. Please try again.", "ERROR");
                }

            }
        }

        private void tmrSerRead_Tick(object sender, EventArgs e)
        {
            if (outputDataQueue.TryDequeue(out removedItemInDataQueue))
            {
                if (bytesToReadQueue.TryDequeue(out removedBytesToRead))
                    txtbxBytesToRead.Text = Convert.ToString(removedBytesToRead);
                txtXAxis.Text = Convert.ToString(removedItemInDataQueue[0]);
                txtYAxis.Text = Convert.ToString(removedItemInDataQueue[1]);
                txtZAxis.Text = Convert.ToString(removedItemInDataQueue[2]);

                int xAccel = Convert.ToInt16(txtXAxis.Text) - 128;
                int yAccel = Convert.ToInt16(txtYAxis.Text) - 128;
                int zAccel = Convert.ToInt16(txtZAxis.Text) - 128;

                if (xAccel < -GRAVITY_CALIBRATION_NUM)
                {
                    chklstAcceleration.SetItemCheckState(3, CheckState.Checked);
                    chklstAcceleration.SetItemCheckState(0, CheckState.Unchecked);
                }
                else if (xAccel > GRAVITY_CALIBRATION_NUM)
                {
                    chklstAcceleration.SetItemCheckState(0, CheckState.Checked);
                    chklstAcceleration.SetItemCheckState(3, CheckState.Unchecked);
                }
                else
                {
                    chklstAcceleration.SetItemCheckState(3, CheckState.Unchecked);
                    chklstAcceleration.SetItemCheckState(0, CheckState.Unchecked);
                }

                if (yAccel < -GRAVITY_CALIBRATION_NUM)
                {
                    chklstAcceleration.SetItemCheckState(4, CheckState.Checked);
                    chklstAcceleration.SetItemCheckState(1, CheckState.Unchecked);
                }
                else if (yAccel > GRAVITY_CALIBRATION_NUM)
                {
                    chklstAcceleration.SetItemCheckState(1, CheckState.Checked);
                    chklstAcceleration.SetItemCheckState(4, CheckState.Unchecked);
                }
                else
                {
                    chklstAcceleration.SetItemCheckState(4, CheckState.Unchecked);
                    chklstAcceleration.SetItemCheckState(1, CheckState.Unchecked);
                }

                if (zAccel < -GRAVITY_CALIBRATION_NUM)
                {
                    chklstAcceleration.SetItemCheckState(5, CheckState.Checked);
                    chklstAcceleration.SetItemCheckState(2, CheckState.Unchecked);
                }
                else if (zAccel > GRAVITY_CALIBRATION_NUM)
                {
                    chklstAcceleration.SetItemCheckState(2, CheckState.Checked);
                    chklstAcceleration.SetItemCheckState(5, CheckState.Unchecked);
                }
                else
                {
                    chklstAcceleration.SetItemCheckState(5, CheckState.Unchecked);
                    chklstAcceleration.SetItemCheckState(2, CheckState.Unchecked);
                }

                xAxisQueue.Enqueue(Convert.ToInt16(txtXAxis.Text));
                yAxisQueue.Enqueue(Convert.ToInt16(txtYAxis.Text));
                zAxisQueue.Enqueue(Convert.ToInt16(txtZAxis.Text));

                if (xAxisQueue.Count() > MAX_AVERAGE_N)
                {
                    xAxisQueue.TryDequeue(out removedItemInXAxisQueue);
                    yAxisQueue.TryDequeue(out removedItemInYAxisQueue);
                    zAxisQueue.TryDequeue(out removedItemInZAxisQueue);


                    chrtAccelData.Series["XAxisData"].Points.RemoveAt(0);
                    chrtAccelData.Series["YAxisData"].Points.RemoveAt(0);
                    chrtAccelData.Series["ZAxisData"].Points.RemoveAt(0);
                }

                chrtAccelData.Series["XAxisData"].Points.AddY(Convert.ToInt16(removedItemInDataQueue[0]));
                chrtAccelData.Series["YAxisData"].Points.AddY(Convert.ToInt16(removedItemInDataQueue[1]));
                chrtAccelData.Series["ZAxisData"].Points.AddY(Convert.ToInt16(removedItemInDataQueue[2]));

                txtXAvg.Text = Convert.ToString(xAxisQueue.Average());
                txtYAvg.Text = Convert.ToString(yAxisQueue.Average());
                txtZAvg.Text = Convert.ToString(zAxisQueue.Average());

                IEnumerable<int> orientationAverageX = xAxisQueue.Skip(lastN);
                int averageX = 0;
                foreach (int itemInOrientationQueue in orientationAverageX)
                    averageX += itemInOrientationQueue - 128;
                averageX = averageX / ORIENTATION_AVERAGE_N;

                IEnumerable<int> orientationAverageY = yAxisQueue.Skip(lastN);
                int averageY = 0;
                foreach (int itemInOrientationQueue in orientationAverageY)
                    averageY += itemInOrientationQueue - 128;
                averageX = averageY / ORIENTATION_AVERAGE_N;

                IEnumerable<int> orientationAverageZ = xAxisQueue.Skip(lastN);
                int averageZ = 0;
                foreach (int itemInOrientationQueue in orientationAverageZ)
                    averageZ += itemInOrientationQueue - 128;
                averageZ = averageZ / ORIENTATION_AVERAGE_N;

                if (averageX < -5)
                    chklstOrientation.SetItemCheckState(3, CheckState.Checked);
                else if (averageX > 5)
                    chklstOrientation.SetItemCheckState(0, CheckState.Checked);
                else
                {
                    chklstOrientation.SetItemCheckState(3, CheckState.Unchecked);
                    chklstOrientation.SetItemCheckState(0, CheckState.Unchecked);
                }

                if (averageY < -5)
                    chklstOrientation.SetItemCheckState(4, CheckState.Checked);
                else if (averageY > 5)
                    chklstOrientation.SetItemCheckState(1, CheckState.Checked);
                else
                {
                    chklstOrientation.SetItemCheckState(4, CheckState.Unchecked);
                    chklstOrientation.SetItemCheckState(1, CheckState.Unchecked);
                }

                if (averageZ < -5)
                    chklstOrientation.SetItemCheckState(5, CheckState.Checked);
                else if (averageZ > 5)
                    chklstOrientation.SetItemCheckState(2, CheckState.Checked);
                else
                {
                    chklstOrientation.SetItemCheckState(5, CheckState.Unchecked);
                    chklstOrientation.SetItemCheckState(2, CheckState.Unchecked);
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            lock (serCOM) serCOM.Close();
        }

        private void serCOM_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //int bytesToRead = serCOM.BytesToRead;
            //bytesToReadQueue.Enqueue(bytesToRead);
            //if (serCOM.ReadByte() == 255)
            //{
            //    serCOM.Read(readBytes, 0, readBytes.Length);
            //    outputDataQueue.Enqueue(readBytes);
            //}
            lock (serCOM)
            {
                int newByte;
                int bytesToRead = serCOM.BytesToRead;
                bytesToReadQueue.Enqueue(bytesToRead);
                while (bytesToRead != 0 && serCOM.IsOpen == true)
                {
                    newByte = serCOM.ReadByte();
                    if (newByte == 255) byteSequence = 0;
                    else
                    {
                        readBytes[byteSequence] = Convert.ToByte(newByte);
                        bytesToRead = serCOM.BytesToRead;
                        byteSequence++;
                    }
                }
                outputDataQueue.Enqueue(readBytes);
            }
        }
        
        
    }
}
