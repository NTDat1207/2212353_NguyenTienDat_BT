namespace BT_Tr48
{
    partial class frmDemoComboBox
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
            this.cboNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.lblChonNgoaiNgu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboNgoaiNgu
            // 
            this.cboNgoaiNgu.FormattingEnabled = true;
            this.cboNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật"});
            this.cboNgoaiNgu.Location = new System.Drawing.Point(206, 32);
            this.cboNgoaiNgu.Name = "cboNgoaiNgu";
            this.cboNgoaiNgu.Size = new System.Drawing.Size(159, 28);
            this.cboNgoaiNgu.TabIndex = 0;
            this.cboNgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.cboNgoaiNgu_SelectedIndexChanged);
            // 
            // lblChonNgoaiNgu
            // 
            this.lblChonNgoaiNgu.AutoSize = true;
            this.lblChonNgoaiNgu.Location = new System.Drawing.Point(20, 40);
            this.lblChonNgoaiNgu.Name = "lblChonNgoaiNgu";
            this.lblChonNgoaiNgu.Size = new System.Drawing.Size(121, 20);
            this.lblChonNgoaiNgu.TabIndex = 1;
            this.lblChonNgoaiNgu.Text = "Chọn ngoại ngữ";
            // 
            // frmDemoComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 240);
            this.Controls.Add(this.lblChonNgoaiNgu);
            this.Controls.Add(this.cboNgoaiNgu);
            this.Name = "frmDemoComboBox";
            this.Text = "Demo ComboBox";
            this.Load += new System.EventHandler(this.frmDemoComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNgoaiNgu;
        private System.Windows.Forms.Label lblChonNgoaiNgu;
    }
}

