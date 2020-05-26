namespace MVCalculate
{
    partial class f123Limits
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgCenter = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgMVL = new System.Windows.Forms.DataGridView();
            this.bGetLimts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMVL)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Center Parameter";
            // 
            // dgCenter
            // 
            this.dgCenter.AllowUserToAddRows = false;
            this.dgCenter.AllowUserToDeleteRows = false;
            this.dgCenter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCenter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCenter.Location = new System.Drawing.Point(23, 139);
            this.dgCenter.Name = "dgCenter";
            this.dgCenter.ReadOnly = true;
            this.dgCenter.Size = new System.Drawing.Size(440, 74);
            this.dgCenter.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ellipose parameter";
            // 
            // dgMVL
            // 
            this.dgMVL.AllowUserToAddRows = false;
            this.dgMVL.AllowUserToDeleteRows = false;
            this.dgMVL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMVL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMVL.Location = new System.Drawing.Point(23, 34);
            this.dgMVL.Name = "dgMVL";
            this.dgMVL.ReadOnly = true;
            this.dgMVL.Size = new System.Drawing.Size(440, 74);
            this.dgMVL.TabIndex = 9;
            // 
            // bGetLimts
            // 
            this.bGetLimts.Location = new System.Drawing.Point(23, 224);
            this.bGetLimts.Name = "bGetLimts";
            this.bGetLimts.Size = new System.Drawing.Size(75, 23);
            this.bGetLimts.TabIndex = 13;
            this.bGetLimts.Text = "Get Setting";
            this.bGetLimts.UseVisualStyleBackColor = true;
            this.bGetLimts.Click += new System.EventHandler(this.bGetLimts_Click);
            // 
            // f123Limits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 259);
            this.Controls.Add(this.bGetLimts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgCenter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgMVL);
            this.Name = "f123Limits";
            this.Text = "ASIC 12123 Limits";
            ((System.ComponentModel.ISupportInitialize)(this.dgCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMVL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgCenter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgMVL;
        private System.Windows.Forms.Button bGetLimts;
    }
}