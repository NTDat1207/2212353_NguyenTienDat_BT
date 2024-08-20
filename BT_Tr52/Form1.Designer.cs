namespace BT_Tr52
{
    partial class frmListBox
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
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lblDanhSachChon = new System.Windows.Forms.Label();
            this.lbDanhSach = new System.Windows.Forms.ListBox();
            this.lbDanhSachChon = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.ForeColor = System.Drawing.Color.Blue;
            this.lblDanhSach.Location = new System.Drawing.Point(18, 32);
            this.lblDanhSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(176, 20);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Danh sách sinh viên lớp";
            // 
            // lblDanhSachChon
            // 
            this.lblDanhSachChon.AutoSize = true;
            this.lblDanhSachChon.ForeColor = System.Drawing.Color.Blue;
            this.lblDanhSachChon.Location = new System.Drawing.Point(408, 32);
            this.lblDanhSachChon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSachChon.Name = "lblDanhSachChon";
            this.lblDanhSachChon.Size = new System.Drawing.Size(278, 20);
            this.lblDanhSachChon.TabIndex = 1;
            this.lblDanhSachChon.Text = "Danh sách sinh viên tham gia bóng đá";
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.FormattingEnabled = true;
            this.lbDanhSach.ItemHeight = 20;
            this.lbDanhSach.Items.AddRange(new object[] {
            "Tran The Anh",
            "Nguyen Thi Lan Huong",
            "Pham Vu Ngoc Ha",
            "Pham Van Hung",
            "Le Thi Van",
            "Nguyen Thi Thu",
            "Le Van Quoc",
            "Le Van Phuoc",
            "Truong Van Dung"});
            this.lbDanhSach.Location = new System.Drawing.Point(22, 74);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhSach.Size = new System.Drawing.Size(274, 264);
            this.lbDanhSach.TabIndex = 2;
            // 
            // lbDanhSachChon
            // 
            this.lbDanhSachChon.FormattingEnabled = true;
            this.lbDanhSachChon.ItemHeight = 20;
            this.lbDanhSachChon.Location = new System.Drawing.Point(412, 74);
            this.lbDanhSachChon.Name = "lbDanhSachChon";
            this.lbDanhSachChon.Size = new System.Drawing.Size(274, 264);
            this.lbDanhSachChon.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(315, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Chọn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(315, 187);
            this.btnXoa.Name = "btnRemove";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 471);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbDanhSachChon);
            this.Controls.Add(this.lbDanhSach);
            this.Controls.Add(this.lblDanhSachChon);
            this.Controls.Add(this.lblDanhSach);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListBox";
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Label lblDanhSachChon;
        private System.Windows.Forms.ListBox lbDanhSach;
        private System.Windows.Forms.ListBox lbDanhSachChon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoa;
    }
}

