namespace SerialReaderSuperSimple
{
    partial class frmMainWindow
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label Current;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
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
            this.txtbxBytesToRead = new System.Windows.Forms.TextBox();
            this.txtbxOrientation = new System.Windows.Forms.TextBox();
            this.chkbxGestures = new System.Windows.Forms.CheckedListBox();
            this.imglstClefairy = new System.Windows.Forms.ImageList(this.components);
            this.picClefairy = new System.Windows.Forms.PictureBox();
            this.btnClefairySays = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbxGestureSequence = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            Current = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAccelData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClefairy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 327);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 29);
            label1.TabIndex = 3;
            label1.Text = "X axis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(12, 374);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 29);
            label2.TabIndex = 3;
            label2.Text = "Y axis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(15, 420);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 29);
            label3.TabIndex = 3;
            label3.Text = "Z axis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(247, 298);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 20);
            label4.TabIndex = 6;
            label4.Text = "Average";
            // 
            // Current
            // 
            Current.AutoSize = true;
            Current.Location = new System.Drawing.Point(136, 298);
            Current.Name = "Current";
            Current.Size = new System.Drawing.Size(62, 20);
            Current.TabIndex = 6;
            Current.Text = "Current";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(15, 499);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(131, 29);
            label5.TabIndex = 3;
            label5.Text = "Orientation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(12, 552);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(153, 29);
            label6.TabIndex = 3;
            label6.Text = "Bytes to read";
            // 
            // cmbbxCOMPorts
            // 
            this.cmbbxCOMPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.txtXAxis.Location = new System.Drawing.Point(96, 324);
            this.txtXAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXAxis.Name = "txtXAxis";
            this.txtXAxis.Size = new System.Drawing.Size(121, 35);
            this.txtXAxis.TabIndex = 2;
            // 
            // txtYAxis
            // 
            this.txtYAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYAxis.Location = new System.Drawing.Point(98, 370);
            this.txtYAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYAxis.Name = "txtYAxis";
            this.txtYAxis.Size = new System.Drawing.Size(120, 35);
            this.txtYAxis.TabIndex = 2;
            // 
            // txtZAxis
            // 
            this.txtZAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZAxis.Location = new System.Drawing.Point(98, 416);
            this.txtZAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZAxis.Name = "txtZAxis";
            this.txtZAxis.Size = new System.Drawing.Size(120, 35);
            this.txtZAxis.TabIndex = 2;
            // 
            // serCOM
            // 
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCOM_DataReceived);
            // 
            // tmrSerRead
            // 
            this.tmrSerRead.Interval = 1;
            this.tmrSerRead.Tick += new System.EventHandler(this.tmrSerRead_Tick);
            // 
            // txtXAvg
            // 
            this.txtXAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXAvg.Location = new System.Drawing.Point(224, 324);
            this.txtXAvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXAvg.Name = "txtXAvg";
            this.txtXAvg.Size = new System.Drawing.Size(121, 35);
            this.txtXAvg.TabIndex = 2;
            // 
            // txtYAvg
            // 
            this.txtYAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYAvg.Location = new System.Drawing.Point(224, 371);
            this.txtYAvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYAvg.Name = "txtYAvg";
            this.txtYAvg.Size = new System.Drawing.Size(120, 35);
            this.txtYAvg.TabIndex = 2;
            // 
            // txtZAvg
            // 
            this.txtZAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZAvg.Location = new System.Drawing.Point(224, 416);
            this.txtZAvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZAvg.Name = "txtZAvg";
            this.txtZAvg.Size = new System.Drawing.Size(120, 35);
            this.txtZAvg.TabIndex = 2;
            // 
            // chrtAccelData
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 255D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chrtAccelData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtAccelData.Legends.Add(legend1);
            this.chrtAccelData.Location = new System.Drawing.Point(476, 59);
            this.chrtAccelData.Name = "chrtAccelData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "XAxisData";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "YAxisData";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "ZAxisData";
            this.chrtAccelData.Series.Add(series1);
            this.chrtAccelData.Series.Add(series2);
            this.chrtAccelData.Series.Add(series3);
            this.chrtAccelData.Size = new System.Drawing.Size(568, 556);
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
            this.lstbxSerParam.Size = new System.Drawing.Size(457, 236);
            this.lstbxSerParam.TabIndex = 5;
            // 
            // txtbxBytesToRead
            // 
            this.txtbxBytesToRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxBytesToRead.Location = new System.Drawing.Point(171, 549);
            this.txtbxBytesToRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxBytesToRead.Name = "txtbxBytesToRead";
            this.txtbxBytesToRead.Size = new System.Drawing.Size(121, 35);
            this.txtbxBytesToRead.TabIndex = 2;
            // 
            // txtbxOrientation
            // 
            this.txtbxOrientation.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxOrientation.Location = new System.Drawing.Point(171, 499);
            this.txtbxOrientation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxOrientation.Name = "txtbxOrientation";
            this.txtbxOrientation.Size = new System.Drawing.Size(121, 36);
            this.txtbxOrientation.TabIndex = 2;
            // 
            // chkbxGestures
            // 
            this.chkbxGestures.Enabled = false;
            this.chkbxGestures.FormattingEnabled = true;
            this.chkbxGestures.Items.AddRange(new object[] {
            "+X",
            "+Y",
            "+Z",
            "-X",
            "-Y",
            "-Z"});
            this.chkbxGestures.Location = new System.Drawing.Point(372, 319);
            this.chkbxGestures.Name = "chkbxGestures";
            this.chkbxGestures.Size = new System.Drawing.Size(65, 130);
            this.chkbxGestures.TabIndex = 7;
            // 
            // imglstClefairy
            // 
            this.imglstClefairy.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstClefairy.ImageStream")));
            this.imglstClefairy.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstClefairy.Images.SetKeyName(0, "Clefairy_DOWN.JPG");
            this.imglstClefairy.Images.SetKeyName(1, "Clefairy_LEFT.jpg");
            this.imglstClefairy.Images.SetKeyName(2, "Clefairy_RIGHT.JPG");
            this.imglstClefairy.Images.SetKeyName(3, "Clefairy_UP.JPG");
            // 
            // picClefairy
            // 
            this.picClefairy.Image = ((System.Drawing.Image)(resources.GetObject("picClefairy.Image")));
            this.picClefairy.InitialImage = null;
            this.picClefairy.Location = new System.Drawing.Point(1153, 309);
            this.picClefairy.Name = "picClefairy";
            this.picClefairy.Size = new System.Drawing.Size(315, 275);
            this.picClefairy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picClefairy.TabIndex = 8;
            this.picClefairy.TabStop = false;
            // 
            // btnClefairySays
            // 
            this.btnClefairySays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClefairySays.Location = new System.Drawing.Point(1227, 599);
            this.btnClefairySays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClefairySays.Name = "btnClefairySays";
            this.btnClefairySays.Size = new System.Drawing.Size(162, 42);
            this.btnClefairySays.TabIndex = 1;
            this.btnClefairySays.Text = "Clefairy Says";
            this.btnClefairySays.UseVisualStyleBackColor = true;
            this.btnClefairySays.Click += new System.EventHandler(this.btnClefairySays_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1153, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtbxGestureSequence
            // 
            this.txtbxGestureSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxGestureSequence.Location = new System.Drawing.Point(20, 599);
            this.txtbxGestureSequence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxGestureSequence.Name = "txtbxGestureSequence";
            this.txtbxGestureSequence.Size = new System.Drawing.Size(402, 35);
            this.txtbxGestureSequence.TabIndex = 2;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 779);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picClefairy);
            this.Controls.Add(this.chkbxGestures);
            this.Controls.Add(Current);
            this.Controls.Add(label4);
            this.Controls.Add(this.lstbxSerParam);
            this.Controls.Add(this.chrtAccelData);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtZAvg);
            this.Controls.Add(this.txtZAxis);
            this.Controls.Add(this.txtYAvg);
            this.Controls.Add(this.txtYAxis);
            this.Controls.Add(this.txtbxOrientation);
            this.Controls.Add(this.txtbxGestureSequence);
            this.Controls.Add(this.txtbxBytesToRead);
            this.Controls.Add(this.txtXAvg);
            this.Controls.Add(this.txtXAxis);
            this.Controls.Add(this.btnClefairySays);
            this.Controls.Add(this.btnConnectDisconnect);
            this.Controls.Add(this.cmbbxCOMPorts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMainWindow";
            this.Text = "MECH 423, Lab #1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chrtAccelData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClefairy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txtXAvg;
        private System.Windows.Forms.TextBox txtYAvg;
        private System.Windows.Forms.TextBox txtZAvg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtAccelData;
        private System.Windows.Forms.ListBox lstbxSerParam;
        private System.Windows.Forms.TextBox txtbxBytesToRead;
        private System.Windows.Forms.TextBox txtbxOrientation;
        private System.Windows.Forms.CheckedListBox chkbxGestures;
        private System.Windows.Forms.ImageList imglstClefairy;
        private System.Windows.Forms.PictureBox picClefairy;
        private System.Windows.Forms.Button btnClefairySays;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbxGestureSequence;
    }
}

