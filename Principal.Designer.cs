
namespace MonitorAlarm
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portSerialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.F1 = new System.Windows.Forms.Label();
            this.F2 = new System.Windows.Forms.Label();
            this.F3 = new System.Windows.Forms.Label();
            this.F4 = new System.Windows.Forms.Label();
            this.F5 = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Label();
            this.P3 = new System.Windows.Forms.Label();
            this.P4 = new System.Windows.Forms.Label();
            this.P5 = new System.Windows.Forms.Label();
            this.P6 = new System.Windows.Forms.Label();
            this.P7 = new System.Windows.Forms.Label();
            this.P8 = new System.Windows.Forms.Label();
            this.DM1 = new System.Windows.Forms.Label();
            this.DM2 = new System.Windows.Forms.Label();
            this.DI1 = new System.Windows.Forms.Label();
            this.DI2 = new System.Windows.Forms.Label();
            this.DI3 = new System.Windows.Forms.Label();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Actions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCon = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.P9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portSerialToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // portSerialToolStripMenuItem
            // 
            this.portSerialToolStripMenuItem.Name = "portSerialToolStripMenuItem";
            this.portSerialToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.portSerialToolStripMenuItem.Text = "Port Serial";
            this.portSerialToolStripMenuItem.Click += new System.EventHandler(this.portSerialToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // F1
            // 
            this.F1.BackColor = System.Drawing.Color.Green;
            this.F1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.F1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F1.ForeColor = System.Drawing.SystemColors.Control;
            this.F1.Location = new System.Drawing.Point(92, 27);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(36, 28);
            this.F1.TabIndex = 2;
            this.F1.Text = "F1";
            this.F1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F2
            // 
            this.F2.BackColor = System.Drawing.Color.Green;
            this.F2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.F2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F2.ForeColor = System.Drawing.SystemColors.Control;
            this.F2.Location = new System.Drawing.Point(230, 28);
            this.F2.Name = "F2";
            this.F2.Size = new System.Drawing.Size(34, 27);
            this.F2.TabIndex = 3;
            this.F2.Text = "F2";
            this.F2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F3
            // 
            this.F3.BackColor = System.Drawing.Color.Green;
            this.F3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.F3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F3.ForeColor = System.Drawing.SystemColors.Control;
            this.F3.Location = new System.Drawing.Point(345, 27);
            this.F3.Name = "F3";
            this.F3.Size = new System.Drawing.Size(34, 28);
            this.F3.TabIndex = 4;
            this.F3.Text = "F3";
            this.F3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F4
            // 
            this.F4.BackColor = System.Drawing.Color.Green;
            this.F4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.F4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F4.ForeColor = System.Drawing.SystemColors.Control;
            this.F4.Location = new System.Drawing.Point(467, 27);
            this.F4.Name = "F4";
            this.F4.Size = new System.Drawing.Size(34, 28);
            this.F4.TabIndex = 5;
            this.F4.Text = "F4";
            this.F4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F5
            // 
            this.F5.BackColor = System.Drawing.Color.Green;
            this.F5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.F5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F5.ForeColor = System.Drawing.SystemColors.Control;
            this.F5.Location = new System.Drawing.Point(220, 472);
            this.F5.Name = "F5";
            this.F5.Size = new System.Drawing.Size(35, 27);
            this.F5.TabIndex = 6;
            this.F5.Text = "F5";
            this.F5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.Green;
            this.P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1.ForeColor = System.Drawing.SystemColors.Control;
            this.P1.Location = new System.Drawing.Point(151, 202);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(34, 23);
            this.P1.TabIndex = 10;
            this.P1.Text = "P1";
            this.P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.Color.Green;
            this.P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2.ForeColor = System.Drawing.SystemColors.Control;
            this.P2.Location = new System.Drawing.Point(196, 201);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(34, 23);
            this.P2.TabIndex = 11;
            this.P2.Text = "P2";
            this.P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P3
            // 
            this.P3.BackColor = System.Drawing.Color.Green;
            this.P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P3.ForeColor = System.Drawing.SystemColors.Control;
            this.P3.Location = new System.Drawing.Point(88, 239);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(34, 29);
            this.P3.TabIndex = 12;
            this.P3.Text = "P3";
            this.P3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P4
            // 
            this.P4.BackColor = System.Drawing.Color.Green;
            this.P4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P4.ForeColor = System.Drawing.SystemColors.Control;
            this.P4.Location = new System.Drawing.Point(113, 279);
            this.P4.Name = "P4";
            this.P4.Size = new System.Drawing.Size(34, 23);
            this.P4.TabIndex = 13;
            this.P4.Text = "P4";
            this.P4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P5
            // 
            this.P5.BackColor = System.Drawing.Color.Green;
            this.P5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P5.ForeColor = System.Drawing.SystemColors.Control;
            this.P5.Location = new System.Drawing.Point(232, 279);
            this.P5.Name = "P5";
            this.P5.Size = new System.Drawing.Size(34, 23);
            this.P5.TabIndex = 14;
            this.P5.Text = "P5";
            this.P5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P6
            // 
            this.P6.BackColor = System.Drawing.Color.Green;
            this.P6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P6.ForeColor = System.Drawing.SystemColors.Control;
            this.P6.Location = new System.Drawing.Point(308, 279);
            this.P6.Name = "P6";
            this.P6.Size = new System.Drawing.Size(34, 23);
            this.P6.TabIndex = 15;
            this.P6.Text = "P6";
            this.P6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P7
            // 
            this.P7.BackColor = System.Drawing.Color.Green;
            this.P7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P7.ForeColor = System.Drawing.SystemColors.Control;
            this.P7.Location = new System.Drawing.Point(75, 590);
            this.P7.Name = "P7";
            this.P7.Size = new System.Drawing.Size(43, 30);
            this.P7.TabIndex = 16;
            this.P7.Text = "P7";
            this.P7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P8
            // 
            this.P8.BackColor = System.Drawing.Color.Green;
            this.P8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P8.ForeColor = System.Drawing.SystemColors.Control;
            this.P8.Location = new System.Drawing.Point(359, 424);
            this.P8.Name = "P8";
            this.P8.Size = new System.Drawing.Size(33, 32);
            this.P8.TabIndex = 17;
            this.P8.Text = "P8";
            this.P8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DM1
            // 
            this.DM1.BackColor = System.Drawing.Color.Green;
            this.DM1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM1.ForeColor = System.Drawing.SystemColors.Control;
            this.DM1.Location = new System.Drawing.Point(29, 283);
            this.DM1.Name = "DM1";
            this.DM1.Size = new System.Drawing.Size(48, 35);
            this.DM1.TabIndex = 18;
            this.DM1.Text = "DM1";
            this.DM1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DM2
            // 
            this.DM2.BackColor = System.Drawing.Color.Green;
            this.DM2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM2.ForeColor = System.Drawing.SystemColors.Control;
            this.DM2.Location = new System.Drawing.Point(497, 201);
            this.DM2.Name = "DM2";
            this.DM2.Size = new System.Drawing.Size(52, 34);
            this.DM2.TabIndex = 19;
            this.DM2.Text = "DM2";
            this.DM2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DI1
            // 
            this.DI1.BackColor = System.Drawing.Color.Green;
            this.DI1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DI1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DI1.ForeColor = System.Drawing.SystemColors.Control;
            this.DI1.Location = new System.Drawing.Point(49, 402);
            this.DI1.Name = "DI1";
            this.DI1.Size = new System.Drawing.Size(46, 26);
            this.DI1.TabIndex = 20;
            this.DI1.Text = "DI1";
            this.DI1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DI2
            // 
            this.DI2.BackColor = System.Drawing.Color.Green;
            this.DI2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DI2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DI2.ForeColor = System.Drawing.SystemColors.Control;
            this.DI2.Location = new System.Drawing.Point(171, 239);
            this.DI2.Name = "DI2";
            this.DI2.Size = new System.Drawing.Size(43, 29);
            this.DI2.TabIndex = 21;
            this.DI2.Text = "DI2";
            this.DI2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DI3
            // 
            this.DI3.BackColor = System.Drawing.Color.Green;
            this.DI3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DI3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DI3.ForeColor = System.Drawing.SystemColors.Control;
            this.DI3.Location = new System.Drawing.Point(500, 309);
            this.DI3.Name = "DI3";
            this.DI3.Size = new System.Drawing.Size(43, 28);
            this.DI3.TabIndex = 22;
            this.DI3.Text = "DI3";
            this.DI3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(581, 574);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(85, 35);
            this.btnEffacer.TabIndex = 24;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Actions});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(581, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(367, 525);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 120;
            // 
            // Actions
            // 
            this.Actions.Text = "Actions";
            this.Actions.Width = 240;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(863, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 28;
            this.button1.Text = "Mise à jour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPort,
            this.toolStripStatusLabel2,
            this.statusCon});
            this.statusStrip1.Location = new System.Drawing.Point(0, 623);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(960, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusPort
            // 
            this.statusPort.Name = "statusPort";
            this.statusPort.Size = new System.Drawing.Size(60, 17);
            this.statusPort.Text = "statusPort";
            this.statusPort.Click += new System.EventHandler(this.statusPort_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // statusCon
            // 
            this.statusCon.Name = "statusCon";
            this.statusCon.Size = new System.Drawing.Size(60, 17);
            this.statusCon.Text = "statusCon";
            this.statusCon.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MonitorAlarm.Properties.Resources.plan;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 593);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // P9
            // 
            this.P9.BackColor = System.Drawing.Color.Green;
            this.P9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P9.ForeColor = System.Drawing.SystemColors.Control;
            this.P9.Location = new System.Drawing.Point(493, 472);
            this.P9.Name = "P9";
            this.P9.Size = new System.Drawing.Size(36, 32);
            this.P9.TabIndex = 31;
            this.P9.Text = "P9";
            this.P9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 645);
            this.Controls.Add(this.P9);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.DI3);
            this.Controls.Add(this.DI2);
            this.Controls.Add(this.DI1);
            this.Controls.Add(this.DM2);
            this.Controls.Add(this.DM1);
            this.Controls.Add(this.P8);
            this.Controls.Add(this.P7);
            this.Controls.Add(this.P6);
            this.Controls.Add(this.P5);
            this.Controls.Add(this.P4);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.F5);
            this.Controls.Add(this.F4);
            this.Controls.Add(this.F3);
            this.Controls.Add(this.F2);
            this.Controls.Add(this.F1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Monitor Alarm";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portSerialToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label F1;
        private System.Windows.Forms.Label F2;
        private System.Windows.Forms.Label F3;
        private System.Windows.Forms.Label F4;
        private System.Windows.Forms.Label F5;
        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.Label P3;
        private System.Windows.Forms.Label P4;
        private System.Windows.Forms.Label P5;
        private System.Windows.Forms.Label P6;
        private System.Windows.Forms.Label P7;
        private System.Windows.Forms.Label P8;
        private System.Windows.Forms.Label DM1;
        private System.Windows.Forms.Label DM2;
        private System.Windows.Forms.Label DI1;
        private System.Windows.Forms.Label DI2;
        private System.Windows.Forms.Label DI3;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Actions;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusPort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label P9;
        private System.Windows.Forms.ToolStripStatusLabel statusCon;
        private System.Windows.Forms.Timer timer1;
    }
}