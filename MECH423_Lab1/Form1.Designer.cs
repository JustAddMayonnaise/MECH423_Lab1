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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label19;
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
            this.imglstClefairyP1 = new System.Windows.Forms.ImageList(this.components);
            this.picClefairyP1 = new System.Windows.Forms.PictureBox();
            this.btnClefairySays = new System.Windows.Forms.Button();
            this.txtbxGestureSequence = new System.Windows.Forms.TextBox();
            this.pgrsReadInput = new System.Windows.Forms.ProgressBar();
            this.chkbxSequenceNumber = new System.Windows.Forms.CheckedListBox();
            this.tmrDisplayGenerated = new System.Windows.Forms.Timer(this.components);
            this.tmrDisplayRead = new System.Windows.Forms.Timer(this.components);
            this.lstbxShowGeneratedGestures = new System.Windows.Forms.ListBox();
            this.lstbxShowRecordedGestures = new System.Windows.Forms.ListBox();
            this.txtbxBytesInQueue = new System.Windows.Forms.TextBox();
            this.tmrCheckSerialPort = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbxClefairyDirections = new System.Windows.Forms.TextBox();
            this.chkbxWriteToFile = new System.Windows.Forms.CheckBox();
            this.txtbxFileName = new System.Windows.Forms.TextBox();
            this.tmrDisplayInstructions = new System.Windows.Forms.Timer(this.components);
            this.picClefairyP2 = new System.Windows.Forms.PictureBox();
            this.picClefairyP3 = new System.Windows.Forms.PictureBox();
            this.picClefairyP4 = new System.Windows.Forms.PictureBox();
            this.imglstClefairyP2 = new System.Windows.Forms.ImageList(this.components);
            this.imglstClefairyP3 = new System.Windows.Forms.ImageList(this.components);
            this.imglstClefairyP4 = new System.Windows.Forms.ImageList(this.components);
            this.txtbxP1Score = new System.Windows.Forms.TextBox();
            this.txtbxP1Mistakes = new System.Windows.Forms.TextBox();
            this.txtbxP2Score = new System.Windows.Forms.TextBox();
            this.txtbxP2Mistakes = new System.Windows.Forms.TextBox();
            this.txtbxP3Score = new System.Windows.Forms.TextBox();
            this.txtbxP3Mistakes = new System.Windows.Forms.TextBox();
            this.txtbxP4Score = new System.Windows.Forms.TextBox();
            this.txtbxP4Mistakes = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            Current = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAccelData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClefairyP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClefairyP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClefairyP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClefairyP4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(4, 260);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 26);
            label1.TabIndex = 3;
            label1.Text = "X axis:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(4, 306);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 26);
            label2.TabIndex = 3;
            label2.Text = "Y axis:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(8, 352);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 26);
            label3.TabIndex = 3;
            label3.Text = "Z axis:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(269, 229);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 20);
            label4.TabIndex = 6;
            label4.Text = "Std dev";
            // 
            // Current
            // 
            Current.AutoSize = true;
            Current.Location = new System.Drawing.Point(127, 229);
            Current.Name = "Current";
            Current.Size = new System.Drawing.Size(62, 20);
            Current.TabIndex = 6;
            Current.Text = "Current";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(7, 394);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(124, 26);
            label5.TabIndex = 3;
            label5.Text = "Orientation:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(7, 444);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(146, 26);
            label6.TabIndex = 3;
            label6.Text = "Bytes to read:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(7, 490);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(170, 26);
            label7.TabIndex = 3;
            label7.Text = "Arrays in queue:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(1295, 763);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(39, 26);
            label8.TabIndex = 3;
            label8.Text = "P1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(1295, 803);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(39, 26);
            label9.TabIndex = 3;
            label9.Text = "P2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(1295, 843);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(39, 26);
            label10.TabIndex = 3;
            label10.Text = "P3";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(1295, 883);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(39, 26);
            label11.TabIndex = 3;
            label11.Text = "P4";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(1465, 737);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(85, 20);
            label12.TabIndex = 6;
            label12.Text = "# Incorrect";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(1357, 737);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(74, 20);
            label13.TabIndex = 6;
            label13.Text = "# Correct";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(1011, 739);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(154, 20);
            label14.TabIndex = 6;
            label14.Text = "User Input Gestures";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(853, 739);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(156, 20);
            label15.TabIndex = 6;
            label15.Text = "Generated Gestures";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(1163, 737);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(139, 20);
            label16.TabIndex = 6;
            label16.Text = "Current Sequence";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.Location = new System.Drawing.Point(7, 976);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(142, 26);
            label17.TabIndex = 3;
            label17.Text = "File directory:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(1173, 927);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(116, 20);
            label18.TabIndex = 6;
            label18.Text = "Input progress:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.Location = new System.Drawing.Point(4, 530);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(69, 26);
            label19.TabIndex = 3;
            label19.Text = "State:";
            // 
            // cmbbxCOMPorts
            // 
            this.cmbbxCOMPorts.BackColor = System.Drawing.Color.White;
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
            this.btnConnectDisconnect.Location = new System.Drawing.Point(140, 8);
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
            this.txtXAxis.BackColor = System.Drawing.Color.White;
            this.txtXAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXAxis.Location = new System.Drawing.Point(96, 255);
            this.txtXAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXAxis.Name = "txtXAxis";
            this.txtXAxis.ReadOnly = true;
            this.txtXAxis.Size = new System.Drawing.Size(121, 35);
            this.txtXAxis.TabIndex = 2;
            // 
            // txtYAxis
            // 
            this.txtYAxis.BackColor = System.Drawing.Color.White;
            this.txtYAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYAxis.Location = new System.Drawing.Point(98, 301);
            this.txtYAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYAxis.Name = "txtYAxis";
            this.txtYAxis.ReadOnly = true;
            this.txtYAxis.Size = new System.Drawing.Size(120, 35);
            this.txtYAxis.TabIndex = 2;
            // 
            // txtZAxis
            // 
            this.txtZAxis.BackColor = System.Drawing.Color.White;
            this.txtZAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZAxis.Location = new System.Drawing.Point(98, 347);
            this.txtZAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZAxis.Name = "txtZAxis";
            this.txtZAxis.ReadOnly = true;
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
            this.txtXAvg.BackColor = System.Drawing.Color.White;
            this.txtXAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXAvg.Location = new System.Drawing.Point(242, 255);
            this.txtXAvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXAvg.Name = "txtXAvg";
            this.txtXAvg.ReadOnly = true;
            this.txtXAvg.Size = new System.Drawing.Size(121, 35);
            this.txtXAvg.TabIndex = 2;
            // 
            // txtYAvg
            // 
            this.txtYAvg.BackColor = System.Drawing.Color.White;
            this.txtYAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYAvg.Location = new System.Drawing.Point(242, 302);
            this.txtYAvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYAvg.Name = "txtYAvg";
            this.txtYAvg.ReadOnly = true;
            this.txtYAvg.Size = new System.Drawing.Size(120, 35);
            this.txtYAvg.TabIndex = 2;
            // 
            // txtZAvg
            // 
            this.txtZAvg.BackColor = System.Drawing.Color.White;
            this.txtZAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZAvg.Location = new System.Drawing.Point(242, 347);
            this.txtZAvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZAvg.Name = "txtZAvg";
            this.txtZAvg.ReadOnly = true;
            this.txtZAvg.Size = new System.Drawing.Size(120, 35);
            this.txtZAvg.TabIndex = 2;
            // 
            // chrtAccelData
            // 
            this.chrtAccelData.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 255D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BackImageTransparentColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chrtAccelData.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Name = "Legend1";
            this.chrtAccelData.Legends.Add(legend1);
            this.chrtAccelData.Location = new System.Drawing.Point(1, 589);
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
            this.chrtAccelData.Size = new System.Drawing.Size(402, 354);
            this.chrtAccelData.TabIndex = 4;
            this.chrtAccelData.Text = "chart1";
            // 
            // lstbxSerParam
            // 
            this.lstbxSerParam.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxSerParam.FormattingEnabled = true;
            this.lstbxSerParam.ItemHeight = 23;
            this.lstbxSerParam.Location = new System.Drawing.Point(13, 59);
            this.lstbxSerParam.MultiColumn = true;
            this.lstbxSerParam.Name = "lstbxSerParam";
            this.lstbxSerParam.Size = new System.Drawing.Size(350, 165);
            this.lstbxSerParam.TabIndex = 5;
            // 
            // txtbxBytesToRead
            // 
            this.txtbxBytesToRead.BackColor = System.Drawing.Color.White;
            this.txtbxBytesToRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxBytesToRead.Location = new System.Drawing.Point(184, 439);
            this.txtbxBytesToRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxBytesToRead.Name = "txtbxBytesToRead";
            this.txtbxBytesToRead.ReadOnly = true;
            this.txtbxBytesToRead.Size = new System.Drawing.Size(108, 35);
            this.txtbxBytesToRead.TabIndex = 2;
            // 
            // txtbxOrientation
            // 
            this.txtbxOrientation.BackColor = System.Drawing.Color.White;
            this.txtbxOrientation.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxOrientation.Location = new System.Drawing.Point(184, 390);
            this.txtbxOrientation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxOrientation.Name = "txtbxOrientation";
            this.txtbxOrientation.ReadOnly = true;
            this.txtbxOrientation.Size = new System.Drawing.Size(108, 36);
            this.txtbxOrientation.TabIndex = 2;
            // 
            // chkbxGestures
            // 
            this.chkbxGestures.Enabled = false;
            this.chkbxGestures.ForeColor = System.Drawing.Color.Black;
            this.chkbxGestures.FormattingEnabled = true;
            this.chkbxGestures.Items.AddRange(new object[] {
            "+X",
            "+Y",
            "+Z",
            "-X",
            "-Y",
            "-Z"});
            this.chkbxGestures.Location = new System.Drawing.Point(298, 390);
            this.chkbxGestures.Name = "chkbxGestures";
            this.chkbxGestures.Size = new System.Drawing.Size(65, 130);
            this.chkbxGestures.TabIndex = 7;
            // 
            // imglstClefairyP1
            // 
            this.imglstClefairyP1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstClefairyP1.ImageStream")));
            this.imglstClefairyP1.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstClefairyP1.Images.SetKeyName(0, "p1_down.jpg");
            this.imglstClefairyP1.Images.SetKeyName(1, "p1_left.jpg");
            this.imglstClefairyP1.Images.SetKeyName(2, "p1_right.jpg");
            this.imglstClefairyP1.Images.SetKeyName(3, "p1_up.jpg");
            this.imglstClefairyP1.Images.SetKeyName(4, "p1_confused.jpg");
            this.imglstClefairyP1.Images.SetKeyName(5, "p1_stationary.jpg");
            // 
            // picClefairyP1
            // 
            this.picClefairyP1.BackColor = System.Drawing.Color.Transparent;
            this.picClefairyP1.Image = ((System.Drawing.Image)(resources.GetObject("picClefairyP1.Image")));
            this.picClefairyP1.InitialImage = null;
            this.picClefairyP1.Location = new System.Drawing.Point(563, 452);
            this.picClefairyP1.Name = "picClefairyP1";
            this.picClefairyP1.Size = new System.Drawing.Size(265, 180);
            this.picClefairyP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClefairyP1.TabIndex = 8;
            this.picClefairyP1.TabStop = false;
            // 
            // btnClefairySays
            // 
            this.btnClefairySays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClefairySays.Location = new System.Drawing.Point(1177, 964);
            this.btnClefairySays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClefairySays.Name = "btnClefairySays";
            this.btnClefairySays.Size = new System.Drawing.Size(389, 42);
            this.btnClefairySays.TabIndex = 1;
            this.btnClefairySays.Text = "Begin Playing Clefairy Says";
            this.btnClefairySays.UseVisualStyleBackColor = true;
            this.btnClefairySays.Click += new System.EventHandler(this.btnClefairySays_Click);
            // 
            // txtbxGestureSequence
            // 
            this.txtbxGestureSequence.BackColor = System.Drawing.Color.White;
            this.txtbxGestureSequence.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxGestureSequence.Location = new System.Drawing.Point(79, 530);
            this.txtbxGestureSequence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxGestureSequence.Name = "txtbxGestureSequence";
            this.txtbxGestureSequence.ReadOnly = true;
            this.txtbxGestureSequence.Size = new System.Drawing.Size(283, 31);
            this.txtbxGestureSequence.TabIndex = 2;
            // 
            // pgrsReadInput
            // 
            this.pgrsReadInput.BackColor = System.Drawing.Color.Lime;
            this.pgrsReadInput.ForeColor = System.Drawing.Color.Red;
            this.pgrsReadInput.Location = new System.Drawing.Point(1287, 926);
            this.pgrsReadInput.Name = "pgrsReadInput";
            this.pgrsReadInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pgrsReadInput.Size = new System.Drawing.Size(278, 23);
            this.pgrsReadInput.TabIndex = 9;
            // 
            // chkbxSequenceNumber
            // 
            this.chkbxSequenceNumber.ColumnWidth = 50;
            this.chkbxSequenceNumber.Enabled = false;
            this.chkbxSequenceNumber.ForeColor = System.Drawing.Color.Black;
            this.chkbxSequenceNumber.FormattingEnabled = true;
            this.chkbxSequenceNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.chkbxSequenceNumber.Location = new System.Drawing.Point(1177, 762);
            this.chkbxSequenceNumber.MultiColumn = true;
            this.chkbxSequenceNumber.Name = "chkbxSequenceNumber";
            this.chkbxSequenceNumber.Size = new System.Drawing.Size(112, 130);
            this.chkbxSequenceNumber.TabIndex = 2;
            // 
            // tmrDisplayGenerated
            // 
            this.tmrDisplayGenerated.Interval = 1000;
            this.tmrDisplayGenerated.Tick += new System.EventHandler(this.tmrDisplayGenerated_Tick);
            // 
            // tmrDisplayRead
            // 
            this.tmrDisplayRead.Tick += new System.EventHandler(this.tmrDisplayRead_Tick);
            // 
            // lstbxShowGeneratedGestures
            // 
            this.lstbxShowGeneratedGestures.FormattingEnabled = true;
            this.lstbxShowGeneratedGestures.ItemHeight = 20;
            this.lstbxShowGeneratedGestures.Location = new System.Drawing.Point(857, 762);
            this.lstbxShowGeneratedGestures.Name = "lstbxShowGeneratedGestures";
            this.lstbxShowGeneratedGestures.Size = new System.Drawing.Size(152, 244);
            this.lstbxShowGeneratedGestures.TabIndex = 10;
            // 
            // lstbxShowRecordedGestures
            // 
            this.lstbxShowRecordedGestures.FormattingEnabled = true;
            this.lstbxShowRecordedGestures.ItemHeight = 20;
            this.lstbxShowRecordedGestures.Location = new System.Drawing.Point(1015, 762);
            this.lstbxShowRecordedGestures.Name = "lstbxShowRecordedGestures";
            this.lstbxShowRecordedGestures.Size = new System.Drawing.Size(146, 244);
            this.lstbxShowRecordedGestures.TabIndex = 10;
            // 
            // txtbxBytesInQueue
            // 
            this.txtbxBytesInQueue.BackColor = System.Drawing.Color.White;
            this.txtbxBytesInQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxBytesInQueue.Location = new System.Drawing.Point(184, 485);
            this.txtbxBytesInQueue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxBytesInQueue.Name = "txtbxBytesInQueue";
            this.txtbxBytesInQueue.ReadOnly = true;
            this.txtbxBytesInQueue.Size = new System.Drawing.Size(108, 35);
            this.txtbxBytesInQueue.TabIndex = 2;
            // 
            // tmrCheckSerialPort
            // 
            this.tmrCheckSerialPort.Enabled = true;
            this.tmrCheckSerialPort.Tick += new System.EventHandler(this.tmrCheckSerialPort_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(436, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtbxClefairyDirections
            // 
            this.txtbxClefairyDirections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(25)))));
            this.txtbxClefairyDirections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxClefairyDirections.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxClefairyDirections.ForeColor = System.Drawing.Color.White;
            this.txtbxClefairyDirections.Location = new System.Drawing.Point(753, 177);
            this.txtbxClefairyDirections.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxClefairyDirections.Name = "txtbxClefairyDirections";
            this.txtbxClefairyDirections.ReadOnly = true;
            this.txtbxClefairyDirections.Size = new System.Drawing.Size(645, 56);
            this.txtbxClefairyDirections.TabIndex = 2;
            this.txtbxClefairyDirections.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkbxWriteToFile
            // 
            this.chkbxWriteToFile.AutoSize = true;
            this.chkbxWriteToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxWriteToFile.Location = new System.Drawing.Point(688, 937);
            this.chkbxWriteToFile.Name = "chkbxWriteToFile";
            this.chkbxWriteToFile.Size = new System.Drawing.Size(149, 29);
            this.chkbxWriteToFile.TabIndex = 11;
            this.chkbxWriteToFile.Text = "Write To File";
            this.chkbxWriteToFile.UseVisualStyleBackColor = true;
            this.chkbxWriteToFile.Click += new System.EventHandler(this.chkbxWriteToFile_Click);
            // 
            // txtbxFileName
            // 
            this.txtbxFileName.BackColor = System.Drawing.Color.White;
            this.txtbxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxFileName.Location = new System.Drawing.Point(155, 971);
            this.txtbxFileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxFileName.Name = "txtbxFileName";
            this.txtbxFileName.ReadOnly = true;
            this.txtbxFileName.Size = new System.Drawing.Size(682, 35);
            this.txtbxFileName.TabIndex = 2;
            this.txtbxFileName.Click += new System.EventHandler(this.txtbxFileName_Click);
            // 
            // tmrDisplayInstructions
            // 
            this.tmrDisplayInstructions.Interval = 50;
            this.tmrDisplayInstructions.Tick += new System.EventHandler(this.tmrDisplayInstructions_Tick);
            // 
            // picClefairyP2
            // 
            this.picClefairyP2.BackColor = System.Drawing.Color.Transparent;
            this.picClefairyP2.Image = ((System.Drawing.Image)(resources.GetObject("picClefairyP2.Image")));
            this.picClefairyP2.InitialImage = null;
            this.picClefairyP2.Location = new System.Drawing.Point(825, 452);
            this.picClefairyP2.Name = "picClefairyP2";
            this.picClefairyP2.Size = new System.Drawing.Size(265, 180);
            this.picClefairyP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClefairyP2.TabIndex = 8;
            this.picClefairyP2.TabStop = false;
            // 
            // picClefairyP3
            // 
            this.picClefairyP3.BackColor = System.Drawing.Color.Transparent;
            this.picClefairyP3.Image = ((System.Drawing.Image)(resources.GetObject("picClefairyP3.Image")));
            this.picClefairyP3.InitialImage = null;
            this.picClefairyP3.Location = new System.Drawing.Point(1065, 452);
            this.picClefairyP3.Name = "picClefairyP3";
            this.picClefairyP3.Size = new System.Drawing.Size(265, 180);
            this.picClefairyP3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClefairyP3.TabIndex = 8;
            this.picClefairyP3.TabStop = false;
            // 
            // picClefairyP4
            // 
            this.picClefairyP4.BackColor = System.Drawing.Color.Transparent;
            this.picClefairyP4.Image = ((System.Drawing.Image)(resources.GetObject("picClefairyP4.Image")));
            this.picClefairyP4.InitialImage = null;
            this.picClefairyP4.Location = new System.Drawing.Point(1328, 452);
            this.picClefairyP4.Name = "picClefairyP4";
            this.picClefairyP4.Size = new System.Drawing.Size(265, 180);
            this.picClefairyP4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClefairyP4.TabIndex = 8;
            this.picClefairyP4.TabStop = false;
            // 
            // imglstClefairyP2
            // 
            this.imglstClefairyP2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstClefairyP2.ImageStream")));
            this.imglstClefairyP2.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstClefairyP2.Images.SetKeyName(0, "p2_down.jpg");
            this.imglstClefairyP2.Images.SetKeyName(1, "p2_left.jpg");
            this.imglstClefairyP2.Images.SetKeyName(2, "p2_right.jpg");
            this.imglstClefairyP2.Images.SetKeyName(3, "p2_up.jpg");
            this.imglstClefairyP2.Images.SetKeyName(4, "p2_confused.jpg");
            this.imglstClefairyP2.Images.SetKeyName(5, "p2_stationary.jpg");
            // 
            // imglstClefairyP3
            // 
            this.imglstClefairyP3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstClefairyP3.ImageStream")));
            this.imglstClefairyP3.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstClefairyP3.Images.SetKeyName(0, "p3_down.jpg");
            this.imglstClefairyP3.Images.SetKeyName(1, "p3_left.jpg");
            this.imglstClefairyP3.Images.SetKeyName(2, "p3_right.jpg");
            this.imglstClefairyP3.Images.SetKeyName(3, "p3_up.jpg");
            this.imglstClefairyP3.Images.SetKeyName(4, "p3_confused.jpg");
            this.imglstClefairyP3.Images.SetKeyName(5, "p3_stationary.jpg");
            // 
            // imglstClefairyP4
            // 
            this.imglstClefairyP4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstClefairyP4.ImageStream")));
            this.imglstClefairyP4.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstClefairyP4.Images.SetKeyName(0, "p4_up.jpg");
            this.imglstClefairyP4.Images.SetKeyName(1, "p4_down.jpg");
            this.imglstClefairyP4.Images.SetKeyName(2, "p4_left.jpg");
            this.imglstClefairyP4.Images.SetKeyName(3, "p4_right.jpg");
            this.imglstClefairyP4.Images.SetKeyName(4, "p4_confused.jpg");
            this.imglstClefairyP4.Images.SetKeyName(5, "p4_stationary.jpg");
            // 
            // txtbxP1Score
            // 
            this.txtbxP1Score.BackColor = System.Drawing.Color.White;
            this.txtbxP1Score.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxP1Score.Location = new System.Drawing.Point(1342, 759);
            this.txtbxP1Score.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxP1Score.Name = "txtbxP1Score";
            this.txtbxP1Score.ReadOnly = true;
            this.txtbxP1Score.Size = new System.Drawing.Size(108, 36);
            this.txtbxP1Score.TabIndex = 2;
            // 
            // txtbxP1Mistakes
            // 
            this.txtbxP1Mistakes.BackColor = System.Drawing.Color.White;
            this.txtbxP1Mistakes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxP1Mistakes.Location = new System.Drawing.Point(1458, 759);
            this.txtbxP1Mistakes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxP1Mistakes.Name = "txtbxP1Mistakes";
            this.txtbxP1Mistakes.ReadOnly = true;
            this.txtbxP1Mistakes.Size = new System.Drawing.Size(108, 36);
            this.txtbxP1Mistakes.TabIndex = 2;
            // 
            // txtbxP2Score
            // 
            this.txtbxP2Score.BackColor = System.Drawing.Color.White;
            this.txtbxP2Score.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxP2Score.Location = new System.Drawing.Point(1342, 799);
            this.txtbxP2Score.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxP2Score.Name = "txtbxP2Score";
            this.txtbxP2Score.ReadOnly = true;
            this.txtbxP2Score.Size = new System.Drawing.Size(108, 36);
            this.txtbxP2Score.TabIndex = 2;
            // 
            // txtbxP2Mistakes
            // 
            this.txtbxP2Mistakes.BackColor = System.Drawing.Color.White;
            this.txtbxP2Mistakes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxP2Mistakes.Location = new System.Drawing.Point(1458, 799);
            this.txtbxP2Mistakes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxP2Mistakes.Name = "txtbxP2Mistakes";
            this.txtbxP2Mistakes.ReadOnly = true;
            this.txtbxP2Mistakes.Size = new System.Drawing.Size(108, 36);
            this.txtbxP2Mistakes.TabIndex = 2;
            // 
            // txtbxP3Score
            // 
            this.txtbxP3Score.BackColor = System.Drawing.Color.White;
            this.txtbxP3Score.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxP3Score.Location = new System.Drawing.Point(1342, 839);
            this.txtbxP3Score.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxP3Score.Name = "txtbxP3Score";
            this.txtbxP3Score.ReadOnly = true;
            this.txtbxP3Score.Size = new System.Drawing.Size(108, 36);
            this.txtbxP3Score.TabIndex = 2;
            // 
            // txtbxP3Mistakes
            // 
            this.txtbxP3Mistakes.BackColor = System.Drawing.Color.White;
            this.txtbxP3Mistakes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxP3Mistakes.Location = new System.Drawing.Point(1458, 839);
            this.txtbxP3Mistakes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxP3Mistakes.Name = "txtbxP3Mistakes";
            this.txtbxP3Mistakes.ReadOnly = true;
            this.txtbxP3Mistakes.Size = new System.Drawing.Size(108, 36);
            this.txtbxP3Mistakes.TabIndex = 2;
            // 
            // txtbxP4Score
            // 
            this.txtbxP4Score.BackColor = System.Drawing.Color.White;
            this.txtbxP4Score.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxP4Score.Location = new System.Drawing.Point(1342, 879);
            this.txtbxP4Score.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxP4Score.Name = "txtbxP4Score";
            this.txtbxP4Score.ReadOnly = true;
            this.txtbxP4Score.Size = new System.Drawing.Size(108, 36);
            this.txtbxP4Score.TabIndex = 2;
            // 
            // txtbxP4Mistakes
            // 
            this.txtbxP4Mistakes.BackColor = System.Drawing.Color.White;
            this.txtbxP4Mistakes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxP4Mistakes.Location = new System.Drawing.Point(1458, 879);
            this.txtbxP4Mistakes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxP4Mistakes.Name = "txtbxP4Mistakes";
            this.txtbxP4Mistakes.ReadOnly = true;
            this.txtbxP4Mistakes.Size = new System.Drawing.Size(108, 36);
            this.txtbxP4Mistakes.TabIndex = 2;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 1024);
            this.Controls.Add(this.chkbxWriteToFile);
            this.Controls.Add(this.picClefairyP4);
            this.Controls.Add(this.picClefairyP3);
            this.Controls.Add(this.picClefairyP2);
            this.Controls.Add(this.picClefairyP1);
            this.Controls.Add(this.lstbxShowRecordedGestures);
            this.Controls.Add(this.lstbxShowGeneratedGestures);
            this.Controls.Add(this.pgrsReadInput);
            this.Controls.Add(this.chkbxSequenceNumber);
            this.Controls.Add(this.chkbxGestures);
            this.Controls.Add(label18);
            this.Controls.Add(label13);
            this.Controls.Add(label15);
            this.Controls.Add(label16);
            this.Controls.Add(label14);
            this.Controls.Add(Current);
            this.Controls.Add(label12);
            this.Controls.Add(label4);
            this.Controls.Add(this.lstbxSerParam);
            this.Controls.Add(label17);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(label19);
            this.Controls.Add(label5);
            this.Controls.Add(label3);
            this.Controls.Add(label11);
            this.Controls.Add(label10);
            this.Controls.Add(label9);
            this.Controls.Add(label8);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtZAvg);
            this.Controls.Add(this.txtZAxis);
            this.Controls.Add(this.txtYAvg);
            this.Controls.Add(this.txtbxP4Mistakes);
            this.Controls.Add(this.txtYAxis);
            this.Controls.Add(this.txtbxP4Score);
            this.Controls.Add(this.txtbxP3Mistakes);
            this.Controls.Add(this.txtbxP3Score);
            this.Controls.Add(this.txtbxP2Mistakes);
            this.Controls.Add(this.txtbxP2Score);
            this.Controls.Add(this.txtbxP1Mistakes);
            this.Controls.Add(this.txtbxP1Score);
            this.Controls.Add(this.txtbxOrientation);
            this.Controls.Add(this.txtbxClefairyDirections);
            this.Controls.Add(this.txtbxFileName);
            this.Controls.Add(this.txtbxGestureSequence);
            this.Controls.Add(this.txtbxBytesInQueue);
            this.Controls.Add(this.txtbxBytesToRead);
            this.Controls.Add(this.txtXAvg);
            this.Controls.Add(this.txtXAxis);
            this.Controls.Add(this.btnClefairySays);
            this.Controls.Add(this.btnConnectDisconnect);
            this.Controls.Add(this.cmbbxCOMPorts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chrtAccelData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1750, 1078);
            this.Name = "frmMainWindow";
            this.Text = "MECH 423, Lab #1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chrtAccelData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClefairyP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClefairyP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClefairyP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClefairyP4)).EndInit();
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
        private System.Windows.Forms.ImageList imglstClefairyP1;
        private System.Windows.Forms.PictureBox picClefairyP1;
        private System.Windows.Forms.Button btnClefairySays;
        private System.Windows.Forms.TextBox txtbxGestureSequence;
        private System.Windows.Forms.ProgressBar pgrsReadInput;
        private System.Windows.Forms.CheckedListBox chkbxSequenceNumber;
        private System.Windows.Forms.Timer tmrDisplayGenerated;
        private System.Windows.Forms.Timer tmrDisplayRead;
        private System.Windows.Forms.ListBox lstbxShowGeneratedGestures;
        private System.Windows.Forms.ListBox lstbxShowRecordedGestures;
        private System.Windows.Forms.TextBox txtbxBytesInQueue;
        private System.Windows.Forms.Timer tmrCheckSerialPort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbxClefairyDirections;
        private System.Windows.Forms.CheckBox chkbxWriteToFile;
        private System.Windows.Forms.TextBox txtbxFileName;
        private System.Windows.Forms.Timer tmrDisplayInstructions;
        private System.Windows.Forms.PictureBox picClefairyP2;
        private System.Windows.Forms.PictureBox picClefairyP3;
        private System.Windows.Forms.PictureBox picClefairyP4;
        private System.Windows.Forms.ImageList imglstClefairyP2;
        private System.Windows.Forms.ImageList imglstClefairyP3;
        private System.Windows.Forms.ImageList imglstClefairyP4;
        private System.Windows.Forms.TextBox txtbxP1Score;
        private System.Windows.Forms.TextBox txtbxP2Score;
        private System.Windows.Forms.TextBox txtbxP2Mistakes;
        private System.Windows.Forms.TextBox txtbxP3Score;
        private System.Windows.Forms.TextBox txtbxP3Mistakes;
        private System.Windows.Forms.TextBox txtbxP4Score;
        private System.Windows.Forms.TextBox txtbxP4Mistakes;
        private System.Windows.Forms.TextBox txtbxP1Mistakes;
    }
}

