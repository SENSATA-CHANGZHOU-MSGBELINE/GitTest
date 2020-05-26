namespace MVCalculate
{
    partial class Main
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
            this.b123 = new System.Windows.Forms.Button();
            this.b126 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b123
            // 
            this.b123.Location = new System.Drawing.Point(70, 46);
            this.b123.Name = "b123";
            this.b123.Size = new System.Drawing.Size(134, 62);
            this.b123.TabIndex = 0;
            this.b123.Text = "ASIC 12123";
            this.b123.UseVisualStyleBackColor = true;
            this.b123.Click += new System.EventHandler(this.b123_Click);
            // 
            // b126
            // 
            this.b126.Location = new System.Drawing.Point(70, 131);
            this.b126.Name = "b126";
            this.b126.Size = new System.Drawing.Size(134, 62);
            this.b126.TabIndex = 1;
            this.b126.Text = "ASIC 12126";
            this.b126.UseVisualStyleBackColor = true;
            this.b126.Click += new System.EventHandler(this.b126_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 256);
            this.Controls.Add(this.b126);
            this.Controls.Add(this.b123);
            this.Name = "Main";
            this.Text = "MV calculation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b123;
        private System.Windows.Forms.Button b126;
    }
}

