namespace MVCalculate
{
    partial class f123
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDeviceID = new System.Windows.Forms.TextBox();
            this.lData = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DataGridView();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightClik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bcmv = new System.Windows.Forms.Button();
            this.bcheckLimits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.RightClik.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device ID";
            // 
            // tbDeviceID
            // 
            this.tbDeviceID.Location = new System.Drawing.Point(27, 29);
            this.tbDeviceID.Name = "tbDeviceID";
            this.tbDeviceID.Size = new System.Drawing.Size(100, 20);
            this.tbDeviceID.TabIndex = 1;
            // 
            // lData
            // 
            this.lData.AutoSize = true;
            this.lData.Location = new System.Drawing.Point(27, 72);
            this.lData.Name = "lData";
            this.lData.Size = new System.Drawing.Size(30, 13);
            this.lData.TabIndex = 2;
            this.lData.Text = "Data";
            // 
            // Data
            // 
            this.Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNo,
            this.OP1,
            this.OM1,
            this.MVC});
            this.Data.Location = new System.Drawing.Point(27, 88);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(443, 402);
            this.Data.TabIndex = 3;
            this.Data.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // SerialNo
            // 
            this.SerialNo.HeaderText = "SerialNo";
            this.SerialNo.Name = "SerialNo";
            // 
            // OP1
            // 
            this.OP1.HeaderText = "OP1";
            this.OP1.Name = "OP1";
            // 
            // OM1
            // 
            this.OM1.HeaderText = "OM1";
            this.OM1.Name = "OM1";
            // 
            // MVC
            // 
            this.MVC.HeaderText = "MV Score";
            this.MVC.Name = "MVC";
            this.MVC.ReadOnly = true;
            // 
            // RightClik
            // 
            this.RightClik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pastToolStripMenuItem,
            this.clearTableToolStripMenuItem});
            this.RightClik.Name = "RightClik";
            this.RightClik.Size = new System.Drawing.Size(131, 48);
            // 
            // pastToolStripMenuItem
            // 
            this.pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            this.pastToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.pastToolStripMenuItem.Text = "Past";
            this.pastToolStripMenuItem.Click += new System.EventHandler(this.pastToolStripMenuItem_Click);
            // 
            // clearTableToolStripMenuItem
            // 
            this.clearTableToolStripMenuItem.Name = "clearTableToolStripMenuItem";
            this.clearTableToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.clearTableToolStripMenuItem.Text = "ClearTable";
            this.clearTableToolStripMenuItem.Click += new System.EventHandler(this.clearTableToolStripMenuItem_Click);
            // 
            // bcmv
            // 
            this.bcmv.Location = new System.Drawing.Point(296, 29);
            this.bcmv.Name = "bcmv";
            this.bcmv.Size = new System.Drawing.Size(75, 23);
            this.bcmv.TabIndex = 10;
            this.bcmv.Text = "CalculateMV";
            this.bcmv.UseVisualStyleBackColor = true;
            this.bcmv.Click += new System.EventHandler(this.bcmv_Click);
            // 
            // bcheckLimits
            // 
            this.bcheckLimits.Location = new System.Drawing.Point(395, 29);
            this.bcheckLimits.Name = "bcheckLimits";
            this.bcheckLimits.Size = new System.Drawing.Size(75, 23);
            this.bcheckLimits.TabIndex = 11;
            this.bcheckLimits.Text = "Check Spec";
            this.bcheckLimits.UseVisualStyleBackColor = true;
            this.bcheckLimits.Click += new System.EventHandler(this.bcheckLimits_Click);
            // 
            // f123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 511);
            this.Controls.Add(this.bcheckLimits);
            this.Controls.Add(this.bcmv);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.lData);
            this.Controls.Add(this.tbDeviceID);
            this.Controls.Add(this.label1);
            this.Name = "f123";
            this.Text = "ASIC 12123 calculation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f123_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.RightClik.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDeviceID;
        private System.Windows.Forms.Label lData;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OM1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MVC;
        private System.Windows.Forms.ContextMenuStrip RightClik;
        private System.Windows.Forms.ToolStripMenuItem pastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTableToolStripMenuItem;
        private System.Windows.Forms.Button bcmv;
        private System.Windows.Forms.Button bcheckLimits;
    }
}