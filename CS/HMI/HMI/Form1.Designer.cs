namespace HMI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnJogBack = new System.Windows.Forms.Button();
            this.BtnJogFor = new System.Windows.Forms.Button();
            this.BtnSetPosition = new System.Windows.Forms.Button();
            this.txtActPos = new System.Windows.Forms.TextBox();
            this.BtnMoveVelo = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPowerStatus = new System.Windows.Forms.Button();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.btnPowerOn = new System.Windows.Forms.Button();
            this.BtnMoveRelative = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.BtnMoveRelative);
            this.groupBox1.Controls.Add(this.BtnJogBack);
            this.groupBox1.Controls.Add(this.BtnJogFor);
            this.groupBox1.Controls.Add(this.BtnSetPosition);
            this.groupBox1.Controls.Add(this.txtActPos);
            this.groupBox1.Controls.Add(this.BtnMoveVelo);
            this.groupBox1.Controls.Add(this.BtnStop);
            this.groupBox1.Controls.Add(this.BtnPowerStatus);
            this.groupBox1.Controls.Add(this.btnPowerOff);
            this.groupBox1.Controls.Add(this.btnPowerOn);
            this.groupBox1.Location = new System.Drawing.Point(14, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnJogBack
            // 
            this.BtnJogBack.Location = new System.Drawing.Point(276, 125);
            this.BtnJogBack.Name = "BtnJogBack";
            this.BtnJogBack.Size = new System.Drawing.Size(126, 35);
            this.BtnJogBack.TabIndex = 9;
            this.BtnJogBack.Text = "JogBack";
            this.BtnJogBack.UseVisualStyleBackColor = true;
            this.BtnJogBack.Click += new System.EventHandler(this.BtnJogBack_Click);
            // 
            // BtnJogFor
            // 
            this.BtnJogFor.Location = new System.Drawing.Point(138, 125);
            this.BtnJogFor.Name = "BtnJogFor";
            this.BtnJogFor.Size = new System.Drawing.Size(126, 35);
            this.BtnJogFor.TabIndex = 8;
            this.BtnJogFor.Text = "JogFor";
            this.BtnJogFor.UseVisualStyleBackColor = true;
            this.BtnJogFor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnJogFor_MouseDown);
            // 
            // BtnSetPosition
            // 
            this.BtnSetPosition.Location = new System.Drawing.Point(6, 125);
            this.BtnSetPosition.Name = "BtnSetPosition";
            this.BtnSetPosition.Size = new System.Drawing.Size(126, 35);
            this.BtnSetPosition.TabIndex = 7;
            this.BtnSetPosition.Text = "SetPosition";
            this.BtnSetPosition.UseVisualStyleBackColor = true;
            this.BtnSetPosition.Click += new System.EventHandler(this.BtnSetPosition_Click);
            // 
            // txtActPos
            // 
            this.txtActPos.Location = new System.Drawing.Point(644, 80);
            this.txtActPos.Name = "txtActPos";
            this.txtActPos.Size = new System.Drawing.Size(82, 22);
            this.txtActPos.TabIndex = 6;
            // 
            // BtnMoveVelo
            // 
            this.BtnMoveVelo.Location = new System.Drawing.Point(138, 74);
            this.BtnMoveVelo.Name = "BtnMoveVelo";
            this.BtnMoveVelo.Size = new System.Drawing.Size(126, 35);
            this.BtnMoveVelo.TabIndex = 5;
            this.BtnMoveVelo.Text = "MoveVelocity";
            this.BtnMoveVelo.UseVisualStyleBackColor = true;
            this.BtnMoveVelo.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(6, 74);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(126, 35);
            this.BtnStop.TabIndex = 4;
            this.BtnStop.Text = "AxisStop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnPowerStatus
            // 
            this.BtnPowerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPowerStatus.Location = new System.Drawing.Point(644, 17);
            this.BtnPowerStatus.Name = "BtnPowerStatus";
            this.BtnPowerStatus.Size = new System.Drawing.Size(165, 43);
            this.BtnPowerStatus.TabIndex = 3;
            this.BtnPowerStatus.Text = "PowerStatus";
            this.BtnPowerStatus.UseVisualStyleBackColor = true;
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.Location = new System.Drawing.Point(138, 21);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(126, 35);
            this.btnPowerOff.TabIndex = 1;
            this.btnPowerOff.Text = "AxisPowerOff";
            this.btnPowerOff.UseVisualStyleBackColor = true;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // btnPowerOn
            // 
            this.btnPowerOn.Location = new System.Drawing.Point(6, 21);
            this.btnPowerOn.Name = "btnPowerOn";
            this.btnPowerOn.Size = new System.Drawing.Size(126, 35);
            this.btnPowerOn.TabIndex = 0;
            this.btnPowerOn.Text = "AxisPowerOn";
            this.btnPowerOn.UseVisualStyleBackColor = true;
            this.btnPowerOn.Click += new System.EventHandler(this.btnPowerOn_Click);
            // 
            // BtnMoveRelative
            // 
            this.BtnMoveRelative.Location = new System.Drawing.Point(276, 74);
            this.BtnMoveRelative.Name = "BtnMoveRelative";
            this.BtnMoveRelative.Size = new System.Drawing.Size(126, 35);
            this.BtnMoveRelative.TabIndex = 10;
            this.BtnMoveRelative.Text = "MoveRelative";
            this.BtnMoveRelative.UseVisualStyleBackColor = true;
            this.BtnMoveRelative.Click += new System.EventHandler(this.BtnMoveRelative_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 456);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TwinCATMotion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPowerOn;
        private System.Windows.Forms.Button btnPowerOff;
        private System.Windows.Forms.Button BtnPowerStatus;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnMoveVelo;
        private System.Windows.Forms.TextBox txtActPos;
        private System.Windows.Forms.Button BtnSetPosition;
        private System.Windows.Forms.Button BtnJogBack;
        private System.Windows.Forms.Button BtnJogFor;
        private System.Windows.Forms.Button BtnMoveRelative;
    }
}

