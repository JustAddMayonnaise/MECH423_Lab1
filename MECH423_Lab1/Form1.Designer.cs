namespace SerialReaderSuperSimple
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbxCOMPorts = new System.Windows.Forms.ComboBox();
            this.btnConnectDisconnect = new System.Windows.Forms.Button();
            this.txtXAxis = new System.Windows.Forms.TextBox();
            this.txtYAxis = new System.Windows.Forms.TextBox();
            this.txtZAxis = new System.Windows.Forms.TextBox();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.tmrSerRead = new System.Windows.Forms.Timer(this.components);
            this.txtXAvg = new System.Windows.Forms.TextBox();
            this.txtYAvg = new System.Windows.Forms.TextBox();
            this.txtZAvg = new System.Windows.Forms.TextBox();
            this.chrtAccelData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lstbxSerParam = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAccelData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "X axis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y axis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Z axis";
            // 
            // cmbbxCOMPorts
            // 
            this.cmbbxCOMPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCOMPorts.FormattingEnabled = true;
            this.cmbbxCOMPorts.Location = new System.Drawing.Point(12, 12);
            this.cmbbxCOMPorts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbxCOMPorts.Name = "cmbbxCOMPorts";
            this.cmbbxCOMPorts.Size = new System.Drawing.Size(121, 37);
            this.cmbbxCOMPorts.TabIndex = 0;
            this.cmbbxCOMPorts.DropDown += new System.EventHandler(this.cmbbxCOMPorts_DropDown);
            // 
            // btnConnectDisconnect
            // 
            this.btnConnectDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectDisconnect.Location = new System.Drawing.Point(140, 12);
            this.btnConnectDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnectDisconnect.Name = "btnConnectDisconnect";
            this.btnConnectDisconnect.Size = new System.Drawing.Size(162, 42);
            this.btnConnectDisconnect.TabIndex = 1;
            this.btnConnectDisconnect.Text = "Connect";
            this.btnConnectDisconnect.UseVisualStyleBackColor = true;
            this.btnConnectDisconnect.Click += new System.EventHandler(this.btnConnectDisconnect_Click);
            // 
            // txtXAxis
            // 
            this.txtXAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXAxis.Location = new System.Drawing.Point(3, 308);
            this.txtXAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXAxis.Name = "txtXAxis";
            this.txtXAxis.Size = new System.Drawing.Size(121, 35);
            this.txtXAxis.TabIndex = 2;
            // 
            // txtYAxis
            // 
            this.txtYAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYAxis.Location = new System.Drawing.Point(5, 354);
            this.txtYAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYAxis.Name = "txtYAxis";
            this.txtYAxis.Size = new System.Drawing.Size(120, 35);
            this.txtYAxis.TabIndex = 2;
            // 
            // txtZAxis
            // 
            this.txtZAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZAxis.Location = new System.Drawing.Point(5, 400);
            this.txtZAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZAxis.Name = "txtZAxis";
            this.txtZAxis.Size = new System.Drawing.Size(120, 35);
            this.txtZAxis.TabIndex = 2;
            // 
            // serCOM
            // 
            this.serCOM.ReceivedBytesThreshold = 5;
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCOM_DataReceived);
            // 
            // tmrSerRead
            // 
            this.tmrSerRead.Tick += new System.EventHandler(this.tmrSerRead_Tick);
            // 
            // txtXAvg
            // 
            this.txtXAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXAvg.Location = new System.Drawing.Point(216, 305);
            this.txtXAvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXAvg.Name = "txtXAvg";
            this.txtXAvg.Size = new System.Drawing.Size(121, 35);
            this.txtXAvg.TabIndex = 2;
            // 
            // txtYAvg
            // 
            this.txtYAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYAvg.Location = new System.Drawing.Point(217, 355);
            this.txtYAvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYAvg.Name = "txtYAvg";
            this.txtYAvg.Size = new System.Drawing.Size(120, 35);
            this.txtYAvg.TabIndex = 2;
            // 
            // txtZAvg
            // 
            this.txtZAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZAvg.Location = new System.Drawing.Point(217, 400);
            this.txtZAvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZAvg.Name = "txtZAvg";
            this.txtZAvg.Size = new System.Drawing.Size(120, 35);
            this.txtZAvg.TabIndex = 2;
            // 
            // chrtAccelData
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.Maximum = 255D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chrtAccelData.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtAccelData.Legends.Add(legend2);
            this.chrtAccelData.Location = new System.Drawing.Point(686, 59);
            this.chrtAccelData.Name = "chrtAccelData";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "XAxisData";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "YAxisData";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "ZAxisData";
            this.chrtAccelData.Series.Add(series4);
            this.chrtAccelData.Series.Add(series5);
            this.chrtAccelData.Series.Add(series6);
            this.chrtAccelData.Size = new System.Drawing.Size(533, 321);
            this.chrtAccelData.TabIndex = 4;
            this.chrtAccelData.Text = "chart1";
            // 
            // lstbxSerParam
            // 
            this.lstbxSerParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxSerParam.FormattingEnabled = true;
            this.lstbxSerParam.ItemHeight = 29;
            this.lstbxSerParam.Location = new System.Drawing.Point(13, 59);
            this.lstbxSerParam.MultiColumn = true;
            this.lstbxSerParam.Name = "lstbxSerParam";
            this.lstbxSerParam.Size = new System.Drawing.Size(625, 236);
            this.lstbxSerParam.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 475);
            this.Controls.Add(this.lstbxSerParam);
            this.Controls.Add(this.chrtAccelData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZAvg);
            this.Controls.Add(this.txtZAxis);
            this.Controls.Add(this.txtYAvg);
            this.Controls.Add(this.txtYAxis);
            this.Controls.Add(this.txtXAvg);
            this.Controls.Add(this.txtXAxis);
            this.Controls.Add(this.btnConnectDisconnect);
            this.Controls.Add(this.cmbbxCOMPorts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Super Simple Serial Port Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chrtAccelData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbxCOMPorts;
        private System.Windows.Forms.Button btnConnectDisconnect;
        private System.Windows.Forms.TextBox txtXAxis;
        private System.Windows.Forms.TextBox txtYAxis;
        private System.Windows.Forms.TextBox txtZAxis;
        internal System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Timer tmrSerRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXAvg;
        private System.Windows.Forms.TextBox txtYAvg;
        private System.Windows.Forms.TextBox txtZAvg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtAccelData;
        private System.Windows.Forms.ListBox lstbxSerParam;
    }
}

