using static MetroFramework.Drawing.MetroPaint.BackColor;

namespace Manny.IoT.EventGenerator
{
    partial class MainScreen
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
            this.tbcMain = new MetroFramework.Controls.MetroTabControl();
            this.tbpConfigure = new MetroFramework.Controls.MetroTabPage();
            this.pnlLabelGeneral = new MetroFramework.Controls.MetroLabel();
            this.pnlConfigure = new MetroFramework.Controls.MetroPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSensorType = new MetroFramework.Controls.MetroLabel();
            this.chkRandomise = new MetroFramework.Controls.MetroCheckBox();
            this.cbSensorType = new MetroFramework.Controls.MetroComboBox();
            this.lblRandomise = new MetroFramework.Controls.MetroLabel();
            this.lblDelay = new MetroFramework.Controls.MetroLabel();
            this.cbDelay = new MetroFramework.Controls.MetroComboBox();
            this.cbNumSensors = new MetroFramework.Controls.MetroComboBox();
            this.lblTotalSensors = new MetroFramework.Controls.MetroLabel();
            this.tbpStream = new MetroFramework.Controls.MetroTabPage();
            this.pnlLog = new MetroFramework.Controls.MetroPanel();
            this.txtMessageLog = new System.Windows.Forms.RichTextBox();
            this.pnlCounter = new MetroFramework.Controls.MetroPanel();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lnkStop = new MetroFramework.Controls.MetroLink();
            this.lnkStream = new MetroFramework.Controls.MetroLink();
            this.tbpMessageDetails = new MetroFramework.Controls.MetroTabPage();
            this.txtMsgDetails = new System.Windows.Forms.RichTextBox();
            this.lstMessages = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMsgDetails = new MetroFramework.Controls.MetroLabel();
            this.tmrCheckSimulator = new System.Windows.Forms.Timer(this.components);
            this.tmrLogConsole = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.lblCopyRight = new MetroFramework.Controls.MetroLabel();
            this.tooltipsMain = new System.Windows.Forms.ToolTip(this.components);
            this.tbcMain.SuspendLayout();
            this.tbpConfigure.SuspendLayout();
            this.pnlConfigure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tbpStream.SuspendLayout();
            this.pnlLog.SuspendLayout();
            this.pnlCounter.SuspendLayout();
            this.tbpMessageDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpConfigure);
            this.tbcMain.Controls.Add(this.tbpStream);
            this.tbcMain.Controls.Add(this.tbpMessageDetails);
            this.tbcMain.Location = new System.Drawing.Point(23, 75);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 2;
            this.tbcMain.Size = new System.Drawing.Size(896, 741);
            this.tbcMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tbcMain.TabIndex = 2;
            this.tbcMain.UseSelectable = true;
            this.tbcMain.SelectedIndexChanged += new System.EventHandler(this.tbcMain_SelectedIndexChanged);
            // 
            // tbpConfigure
            // 
            this.tbpConfigure.Controls.Add(this.pnlLabelGeneral);
            this.tbpConfigure.Controls.Add(this.pnlConfigure);
            this.tbpConfigure.HorizontalScrollbarBarColor = true;
            this.tbpConfigure.HorizontalScrollbarHighlightOnWheel = false;
            this.tbpConfigure.HorizontalScrollbarSize = 10;
            this.tbpConfigure.Location = new System.Drawing.Point(4, 38);
            this.tbpConfigure.Margin = new System.Windows.Forms.Padding(30);
            this.tbpConfigure.Name = "tbpConfigure";
            this.tbpConfigure.Size = new System.Drawing.Size(888, 699);
            this.tbpConfigure.TabIndex = 0;
            this.tbpConfigure.Text = "Configure";
            this.tbpConfigure.VerticalScrollbarBarColor = true;
            this.tbpConfigure.VerticalScrollbarHighlightOnWheel = false;
            this.tbpConfigure.VerticalScrollbarSize = 10;
            // 
            // pnlLabelGeneral
            // 
            this.pnlLabelGeneral.AccessibleDescription = "Randomise Emission Time ensures message generation is scattered across the interv" +
    "al window (not all at the same time)";
            this.pnlLabelGeneral.AutoSize = true;
            this.pnlLabelGeneral.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.pnlLabelGeneral.Location = new System.Drawing.Point(85, 58);
            this.pnlLabelGeneral.Name = "pnlLabelGeneral";
            this.pnlLabelGeneral.Size = new System.Drawing.Size(109, 19);
            this.pnlLabelGeneral.TabIndex = 10;
            this.pnlLabelGeneral.Text = "General Settings";
            // 
            // pnlConfigure
            // 
            this.pnlConfigure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfigure.Controls.Add(this.pictureBox4);
            this.pnlConfigure.Controls.Add(this.pictureBox3);
            this.pnlConfigure.Controls.Add(this.pictureBox1);
            this.pnlConfigure.Controls.Add(this.pictureBox2);
            this.pnlConfigure.Controls.Add(this.lblSensorType);
            this.pnlConfigure.Controls.Add(this.chkRandomise);
            this.pnlConfigure.Controls.Add(this.cbSensorType);
            this.pnlConfigure.Controls.Add(this.lblRandomise);
            this.pnlConfigure.Controls.Add(this.lblDelay);
            this.pnlConfigure.Controls.Add(this.cbDelay);
            this.pnlConfigure.Controls.Add(this.cbNumSensors);
            this.pnlConfigure.Controls.Add(this.lblTotalSensors);
            this.pnlConfigure.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlConfigure.HorizontalScrollbarBarColor = true;
            this.pnlConfigure.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlConfigure.HorizontalScrollbarSize = 10;
            this.pnlConfigure.Location = new System.Drawing.Point(50, 68);
            this.pnlConfigure.Name = "pnlConfigure";
            this.pnlConfigure.Size = new System.Drawing.Size(495, 472);
            this.pnlConfigure.TabIndex = 10;
            this.pnlConfigure.VerticalScrollbarBarColor = true;
            this.pnlConfigure.VerticalScrollbarHighlightOnWheel = false;
            this.pnlConfigure.VerticalScrollbarSize = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::Manny.IoT.EventGenerator.Properties.Resources._1498838023_Shuffle;
            this.pictureBox4.Location = new System.Drawing.Point(36, 265);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 37);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.tooltipsMain.SetToolTip(this.pictureBox4, "Randomise Emission Time ensures message generation is scattered across the interv" +
        "al window (not all at once in the beginnig)");
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::Manny.IoT.EventGenerator.Properties.Resources._1498837641_settings;
            this.pictureBox3.Location = new System.Drawing.Point(36, 183);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 37);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.tooltipsMain.SetToolTip(this.pictureBox3, "How much sensors will generate message");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::Manny.IoT.EventGenerator.Properties.Resources._1498837130_weather_101;
            this.pictureBox1.Location = new System.Drawing.Point(37, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 39);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.tooltipsMain.SetToolTip(this.pictureBox1, "Choose the type of sensor. Message structure differs for each sensor");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Manny.IoT.EventGenerator.Properties.Resources._1498837673_timer;
            this.pictureBox2.Location = new System.Drawing.Point(36, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 37);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.tooltipsMain.SetToolTip(this.pictureBox2, "How much delay between consective messages");
            // 
            // lblSensorType
            // 
            this.lblSensorType.AutoSize = true;
            this.lblSensorType.Location = new System.Drawing.Point(95, 33);
            this.lblSensorType.Name = "lblSensorType";
            this.lblSensorType.Size = new System.Drawing.Size(79, 19);
            this.lblSensorType.TabIndex = 3;
            this.lblSensorType.Text = "Sensor Type";
            this.tooltipsMain.SetToolTip(this.lblSensorType, "Choose the type of sensor. Message structure differs for each sensor");
            // 
            // chkRandomise
            // 
            this.chkRandomise.AutoSize = true;
            this.chkRandomise.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkRandomise.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkRandomise.Location = new System.Drawing.Point(276, 265);
            this.chkRandomise.Name = "chkRandomise";
            this.chkRandomise.Size = new System.Drawing.Size(33, 19);
            this.chkRandomise.TabIndex = 8;
            this.chkRandomise.Text = "  ";
            this.chkRandomise.UseSelectable = true;
            this.chkRandomise.CheckedChanged += new System.EventHandler(this.chkRandomise_CheckedChanged);
            // 
            // cbSensorType
            // 
            this.cbSensorType.FormattingEnabled = true;
            this.cbSensorType.ItemHeight = 23;
            this.cbSensorType.Location = new System.Drawing.Point(238, 33);
            this.cbSensorType.Name = "cbSensorType";
            this.cbSensorType.Size = new System.Drawing.Size(222, 29);
            this.cbSensorType.TabIndex = 2;
            this.cbSensorType.UseSelectable = true;
            this.cbSensorType.SelectedIndexChanged += new System.EventHandler(this.cbSensorType_SelectedIndexChanged);
            // 
            // lblRandomise
            // 
            this.lblRandomise.AccessibleDescription = "Randomise Emission Time ensures message generation is scattered across the interv" +
    "al window (not all at the same time)";
            this.lblRandomise.AutoSize = true;
            this.lblRandomise.Location = new System.Drawing.Point(100, 265);
            this.lblRandomise.Name = "lblRandomise";
            this.lblRandomise.Size = new System.Drawing.Size(161, 19);
            this.lblRandomise.TabIndex = 9;
            this.lblRandomise.Text = "Randomise Emission Time";
            this.tooltipsMain.SetToolTip(this.lblRandomise, "Randomise Emission Time ensures message generation is scattered across the interv" +
        "al window (not all at once in the beginnig)");
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(100, 105);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(134, 19);
            this.lblDelay.TabIndex = 3;
            this.lblDelay.Text = "Delay Between Events";
            this.tooltipsMain.SetToolTip(this.lblDelay, "How much delay between consective messages");
            // 
            // cbDelay
            // 
            this.cbDelay.FormattingEnabled = true;
            this.cbDelay.ItemHeight = 23;
            this.cbDelay.Location = new System.Drawing.Point(243, 105);
            this.cbDelay.Name = "cbDelay";
            this.cbDelay.Size = new System.Drawing.Size(169, 29);
            this.cbDelay.TabIndex = 2;
            this.cbDelay.UseSelectable = true;
            this.cbDelay.SelectedIndexChanged += new System.EventHandler(this.cbDelay_SelectedIndexChanged);
            // 
            // cbNumSensors
            // 
            this.cbNumSensors.FormattingEnabled = true;
            this.cbNumSensors.ItemHeight = 23;
            this.cbNumSensors.Location = new System.Drawing.Point(243, 183);
            this.cbNumSensors.Name = "cbNumSensors";
            this.cbNumSensors.Size = new System.Drawing.Size(169, 29);
            this.cbNumSensors.TabIndex = 4;
            this.cbNumSensors.UseSelectable = true;
            this.cbNumSensors.SelectedIndexChanged += new System.EventHandler(this.cbNumSensors_SelectedIndexChanged);
            // 
            // lblTotalSensors
            // 
            this.lblTotalSensors.AutoSize = true;
            this.lblTotalSensors.Location = new System.Drawing.Point(100, 183);
            this.lblTotalSensors.Name = "lblTotalSensors";
            this.lblTotalSensors.Size = new System.Drawing.Size(123, 19);
            this.lblTotalSensors.TabIndex = 5;
            this.lblTotalSensors.Text = "How many sensors?";
            this.tooltipsMain.SetToolTip(this.lblTotalSensors, "How much sensors will generate message");
            // 
            // tbpStream
            // 
            this.tbpStream.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbpStream.Controls.Add(this.pnlLog);
            this.tbpStream.Controls.Add(this.pnlCounter);
            this.tbpStream.Controls.Add(this.lnkStop);
            this.tbpStream.Controls.Add(this.lnkStream);
            this.tbpStream.HorizontalScrollbarBarColor = true;
            this.tbpStream.HorizontalScrollbarHighlightOnWheel = false;
            this.tbpStream.HorizontalScrollbarSize = 10;
            this.tbpStream.Location = new System.Drawing.Point(4, 38);
            this.tbpStream.Name = "tbpStream";
            this.tbpStream.Size = new System.Drawing.Size(888, 699);
            this.tbpStream.TabIndex = 1;
            this.tbpStream.Text = "Stream";
            this.tbpStream.VerticalScrollbarBarColor = true;
            this.tbpStream.VerticalScrollbarHighlightOnWheel = false;
            this.tbpStream.VerticalScrollbarSize = 10;
            // 
            // pnlLog
            // 
            this.pnlLog.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlLog.Controls.Add(this.txtMessageLog);
            this.pnlLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLog.HorizontalScrollbarBarColor = true;
            this.pnlLog.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlLog.HorizontalScrollbarSize = 10;
            this.pnlLog.Location = new System.Drawing.Point(17, 215);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(846, 459);
            this.pnlLog.TabIndex = 7;
            this.pnlLog.UseCustomBackColor = true;
            this.pnlLog.UseCustomForeColor = true;
            this.pnlLog.VerticalScrollbarBarColor = true;
            this.pnlLog.VerticalScrollbarHighlightOnWheel = false;
            this.pnlLog.VerticalScrollbarSize = 10;
            // 
            // txtMessageLog
            // 
            this.txtMessageLog.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtMessageLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessageLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessageLog.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageLog.ForeColor = System.Drawing.Color.Snow;
            this.txtMessageLog.Location = new System.Drawing.Point(0, 0);
            this.txtMessageLog.Name = "txtMessageLog";
            this.txtMessageLog.Size = new System.Drawing.Size(846, 459);
            this.txtMessageLog.TabIndex = 2;
            this.txtMessageLog.Text = "";
            // 
            // pnlCounter
            // 
            this.pnlCounter.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlCounter.Controls.Add(this.lblCounter);
            this.pnlCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCounter.HorizontalScrollbarBarColor = true;
            this.pnlCounter.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCounter.HorizontalScrollbarSize = 10;
            this.pnlCounter.Location = new System.Drawing.Point(675, 29);
            this.pnlCounter.Name = "pnlCounter";
            this.pnlCounter.Size = new System.Drawing.Size(188, 150);
            this.pnlCounter.TabIndex = 5;
            this.pnlCounter.UseCustomBackColor = true;
            this.pnlCounter.UseCustomForeColor = true;
            this.pnlCounter.VerticalScrollbarBarColor = true;
            this.pnlCounter.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCounter.VerticalScrollbarSize = 10;
            // 
            // lblCounter
            // 
            this.lblCounter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.Snow;
            this.lblCounter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCounter.Location = new System.Drawing.Point(0, 0);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(188, 150);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "0";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkStop
            // 
            this.lnkStop.BackColor = System.Drawing.SystemColors.Window;
            this.lnkStop.BackgroundImage = global::Manny.IoT.EventGenerator.Properties.Resources._1497761254_close;
            this.lnkStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lnkStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkStop.ForeColor = System.Drawing.Color.Black;
            this.lnkStop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkStop.Location = new System.Drawing.Point(17, 98);
            this.lnkStop.Name = "lnkStop";
            this.lnkStop.Size = new System.Drawing.Size(158, 33);
            this.lnkStop.TabIndex = 8;
            this.lnkStop.Text = "Stop Streaming  ";
            this.lnkStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkStop.UseSelectable = true;
            this.lnkStop.Click += new System.EventHandler(this.lnkStop_Click);
            // 
            // lnkStream
            // 
            this.lnkStream.BackColor = System.Drawing.SystemColors.Window;
            this.lnkStream.BackgroundImage = global::Manny.IoT.EventGenerator.Properties.Resources._1497701170_broadcast;
            this.lnkStream.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lnkStream.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkStream.ForeColor = System.Drawing.Color.Black;
            this.lnkStream.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkStream.Location = new System.Drawing.Point(17, 29);
            this.lnkStream.Name = "lnkStream";
            this.lnkStream.Size = new System.Drawing.Size(158, 34);
            this.lnkStream.TabIndex = 2;
            this.lnkStream.Text = "Begin Streaming  ";
            this.lnkStream.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkStream.UseSelectable = true;
            this.lnkStream.Click += new System.EventHandler(this.lnkStream_Click);
            // 
            // tbpMessageDetails
            // 
            this.tbpMessageDetails.Controls.Add(this.txtMsgDetails);
            this.tbpMessageDetails.Controls.Add(this.lstMessages);
            this.tbpMessageDetails.Controls.Add(this.lblMsgDetails);
            this.tbpMessageDetails.HorizontalScrollbarBarColor = true;
            this.tbpMessageDetails.HorizontalScrollbarHighlightOnWheel = false;
            this.tbpMessageDetails.HorizontalScrollbarSize = 10;
            this.tbpMessageDetails.Location = new System.Drawing.Point(4, 38);
            this.tbpMessageDetails.Name = "tbpMessageDetails";
            this.tbpMessageDetails.Size = new System.Drawing.Size(888, 699);
            this.tbpMessageDetails.TabIndex = 2;
            this.tbpMessageDetails.Text = "Message Details";
            this.tbpMessageDetails.VerticalScrollbarBarColor = true;
            this.tbpMessageDetails.VerticalScrollbarHighlightOnWheel = false;
            this.tbpMessageDetails.VerticalScrollbarSize = 10;
            // 
            // txtMsgDetails
            // 
            this.txtMsgDetails.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtMsgDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsgDetails.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsgDetails.ForeColor = System.Drawing.Color.Snow;
            this.txtMsgDetails.Location = new System.Drawing.Point(482, 33);
            this.txtMsgDetails.Name = "txtMsgDetails";
            this.txtMsgDetails.Size = new System.Drawing.Size(406, 644);
            this.txtMsgDetails.TabIndex = 5;
            this.txtMsgDetails.Text = "";
            // 
            // lstMessages
            // 
            this.lstMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstMessages.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstMessages.FullRowSelect = true;
            this.lstMessages.Location = new System.Drawing.Point(7, 33);
            this.lstMessages.MultiSelect = false;
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.OwnerDraw = true;
            this.lstMessages.Size = new System.Drawing.Size(452, 644);
            this.lstMessages.TabIndex = 4;
            this.lstMessages.UseCompatibleStateImageBehavior = false;
            this.lstMessages.UseSelectable = true;
            this.lstMessages.View = System.Windows.Forms.View.Details;
            this.lstMessages.SelectedIndexChanged += new System.EventHandler(this.lstMessages_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Message";
            this.columnHeader1.Width = 450;
            // 
            // lblMsgDetails
            // 
            this.lblMsgDetails.AutoSize = true;
            this.lblMsgDetails.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblMsgDetails.Location = new System.Drawing.Point(7, 7);
            this.lblMsgDetails.Name = "lblMsgDetails";
            this.lblMsgDetails.Size = new System.Drawing.Size(611, 15);
            this.lblMsgDetails.TabIndex = 2;
            this.lblMsgDetails.Text = "Note: This screen shows message payload details. For performance reasons only the" +
    " recently sent messges are dispalyed.";
            // 
            // tmrCheckSimulator
            // 
            this.tmrCheckSimulator.Interval = 50;
            this.tmrCheckSimulator.Tick += new System.EventHandler(this.tmrCheckSimulator_Tick);
            // 
            // tmrLogConsole
            // 
            this.tmrLogConsole.Interval = 200;
            this.tmrLogConsole.Tick += new System.EventHandler(this.tmrLogConsole_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(23, 819);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 19);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Ready";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyRight.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCopyRight.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCopyRight.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCopyRight.Location = new System.Drawing.Point(702, 36);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(213, 25);
            this.lblCopyRight.TabIndex = 4;
            this.lblCopyRight.Text = "© Manny Grewal - 2017";
            // 
            // tooltipsMain
            // 
            this.tooltipsMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 840);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbcMain);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Azure IoT Hub Streaming Simulator";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.tbcMain.ResumeLayout(false);
            this.tbpConfigure.ResumeLayout(false);
            this.tbpConfigure.PerformLayout();
            this.pnlConfigure.ResumeLayout(false);
            this.pnlConfigure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tbpStream.ResumeLayout(false);
            this.pnlLog.ResumeLayout(false);
            this.pnlCounter.ResumeLayout(false);
            this.tbpMessageDetails.ResumeLayout(false);
            this.tbpMessageDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbcMain;
        private MetroFramework.Controls.MetroTabPage tbpConfigure;
        private MetroFramework.Controls.MetroLabel lblDelay;
        private MetroFramework.Controls.MetroComboBox cbDelay;
        private MetroFramework.Controls.MetroTabPage tbpStream;
        private MetroFramework.Controls.MetroLink lnkStream;
        private MetroFramework.Controls.MetroPanel pnlCounter;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Timer tmrCheckSimulator;
        private MetroFramework.Controls.MetroPanel pnlLog;
        private System.Windows.Forms.RichTextBox txtMessageLog;
        private System.Windows.Forms.Timer tmrLogConsole;
        private MetroFramework.Controls.MetroLink lnkStop;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroLabel lblTotalSensors;
        private MetroFramework.Controls.MetroComboBox cbNumSensors;
        private MetroFramework.Controls.MetroTabPage tbpMessageDetails;
        private MetroFramework.Controls.MetroLabel lblMsgDetails;
        private MetroFramework.Controls.MetroListView lstMessages;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.RichTextBox txtMsgDetails;
        private MetroFramework.Controls.MetroLabel lblCopyRight;
        private MetroFramework.Controls.MetroPanel pnlConfigure;
        private MetroFramework.Controls.MetroCheckBox chkRandomise;
        private MetroFramework.Controls.MetroLabel lblRandomise;
        private System.Windows.Forms.ToolTip tooltipsMain;
        private MetroFramework.Controls.MetroLabel lblSensorType;
        private MetroFramework.Controls.MetroComboBox cbSensorType;
        private MetroFramework.Controls.MetroLabel pnlLabelGeneral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

