
namespace MonitorAlarm
{
    partial class Port
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
            this.cboList = new System.Windows.Forms.ComboBox();
            this.btnChoix = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboList
            // 
            this.cboList.FormattingEnabled = true;
            this.cboList.Location = new System.Drawing.Point(29, 26);
            this.cboList.Name = "cboList";
            this.cboList.Size = new System.Drawing.Size(121, 21);
            this.cboList.TabIndex = 0;
            // 
            // btnChoix
            // 
            this.btnChoix.Location = new System.Drawing.Point(176, 26);
            this.btnChoix.Name = "btnChoix";
            this.btnChoix.Size = new System.Drawing.Size(75, 23);
            this.btnChoix.TabIndex = 1;
            this.btnChoix.Text = "Open";
            this.btnChoix.UseVisualStyleBackColor = true;
            this.btnChoix.Click += new System.EventHandler(this.btnChoix_Click);
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(29, 65);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(212, 39);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "label1";
            this.lblPort.Click += new System.EventHandler(this.lblPort_Click);
            // 
            // Port
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 127);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.btnChoix);
            this.Controls.Add(this.cboList);
            this.Name = "Port";
            this.Text = "Port";
            this.Load += new System.EventHandler(this.Port_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboList;
        private System.Windows.Forms.Button btnChoix;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblPort;
    }
}