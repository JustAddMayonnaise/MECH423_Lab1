using System;
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
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            readBytes = new byte[serCOM.ReadBufferSize];
            serCOM.BaudRate = 128000;
            serCOM.DataBits = 8;
            serCOM.StopBits = System.IO.Ports.StopBits.One;
            serCOM.Parity = System.IO.Ports.Parity.None;

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
                serCOM.Close();
                btnConnectDisconnect.Text = "Connect";
                lstbxSerParam.Items.Clear();
                cmbbxCOMPorts.Enabled = true;
                tmrSerRead.Enabled = false;
                txtXAxis.Clear();
                txtYAxis.Clear();
                txtZAxis.Clear();
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
                    lstbxSerParam.Items.Add("Bytes To Read: " + serCOM.BytesToRead.ToString());
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
                txtXAxis.Text = Convert.ToString(removedItemInDataQueue[1]);
                txtYAxis.Text = Convert.ToString(removedItemInDataQueue[2]);
                txtZAxis.Text = Convert.ToString(removedItemInDataQueue[3]);

                xAxisQueue.Enqueue(Convert.ToInt16(txtXAxis.Text));
                yAxisQueue.Enqueue(Convert.ToInt16(txtYAxis.Text));
                zAxisQueue.Enqueue(Convert.ToInt16(txtZAxis.Text));

                if(xAxisQueue.Count() > 100)
                {
                    xAxisQueue.TryDequeue(out removedItemInXAxisQueue);
                    yAxisQueue.TryDequeue(out removedItemInYAxisQueue);
                    zAxisQueue.TryDequeue(out removedItemInZAxisQueue);

                    
                    chrtAccelData.Series["XAxisData"].Points.RemoveAt(0);
                    chrtAccelData.Series["YAxisData"].Points.RemoveAt(0);
                    chrtAccelData.Series["ZAxisData"].Points.RemoveAt(0);
                }

                chrtAccelData.Series["XAxisData"].Points.AddY(Convert.ToInt16(removedItemInDataQueue[1]));
                chrtAccelData.Series["YAxisData"].Points.AddY(Convert.ToInt16(removedItemInDataQueue[2]));
                chrtAccelData.Series["ZAxisData"].Points.AddY(Convert.ToInt16(removedItemInDataQueue[3]));

                txtXAvg.Text = Convert.ToString(xAxisQueue.Average());
                txtYAvg.Text = Convert.ToString(yAxisQueue.Average());
                txtZAvg.Text = Convert.ToString(zAxisQueue.Average());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serCOM.Close();
        }

        private void serCOM_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serCOM.Read(readBytes, 0, readBytes.Length);
            outputDataQueue.Enqueue(readBytes);
        }
    }
}
