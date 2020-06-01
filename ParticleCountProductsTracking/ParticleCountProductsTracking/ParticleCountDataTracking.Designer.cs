namespace ParticleCountProductsTracking
{
    partial class ParticleCountDataTracking
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
            this.lbScanStatus = new System.Windows.Forms.Label();
            this.lbReadResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboxDeviceID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbScanStatus
            // 
            this.lbScanStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbScanStatus.AutoSize = true;
            this.lbScanStatus.Location = new System.Drawing.Point(633, 97);
            this.lbScanStatus.Name = "lbScanStatus";
            this.lbScanStatus.Size = new System.Drawing.Size(46, 17);
            this.lbScanStatus.TabIndex = 1;
            this.lbScanStatus.Text = "label1";
            // 
            // lbReadResult
            // 
            this.lbReadResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbReadResult.AutoSize = true;
            this.lbReadResult.Location = new System.Drawing.Point(85, 97);
            this.lbReadResult.Name = "lbReadResult";
            this.lbReadResult.Size = new System.Drawing.Size(78, 17);
            this.lbReadResult.TabIndex = 2;
            this.lbReadResult.Text = "扫描结果：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "DeviceID:";
            // 
            // comboxDeviceID
            // 
            this.comboxDeviceID.DisplayMember = "DeviceID";
            this.comboxDeviceID.FormattingEnabled = true;
            this.comboxDeviceID.Location = new System.Drawing.Point(169, 51);
            this.comboxDeviceID.Name = "comboxDeviceID";
            this.comboxDeviceID.Size = new System.Drawing.Size(121, 24);
            this.comboxDeviceID.TabIndex = 4;
            // 
            // ParticleCountDataTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 306);
            this.Controls.Add(this.comboxDeviceID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbReadResult);
            this.Controls.Add(this.lbScanStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParticleCountDataTracking";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ParticleCountDataTracking";
            this.Load += new System.EventHandler(this.ParticleCountDataTracking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbScanStatus;
        private System.Windows.Forms.Label lbReadResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboxDeviceID;
    }
}

