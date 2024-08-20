namespace BT_Tr57
{
    partial class frmButtons
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
            this.btnButton = new System.Windows.Forms.Button();
            this.btnFlat = new System.Windows.Forms.Button();
            this.rdFlat = new System.Windows.Forms.RadioButton();
            this.rdPopup = new System.Windows.Forms.RadioButton();
            this.ckbMauChu = new System.Windows.Forms.CheckBox();
            this.ckbMauNen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.AutoSize = true;
            this.btnButton.Location = new System.Drawing.Point(31, 83);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(98, 30);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Button";
            this.btnButton.UseVisualStyleBackColor = true;
            // 
            // btnFlat
            // 
            this.btnFlat.AutoSize = true;
            this.btnFlat.Location = new System.Drawing.Point(31, 202);
            this.btnFlat.Name = "btnFlat";
            this.btnFlat.Size = new System.Drawing.Size(98, 30);
            this.btnFlat.TabIndex = 1;
            this.btnFlat.Text = "Button Flat";
            this.btnFlat.UseVisualStyleBackColor = true;
            // 
            // rdFlat
            // 
            this.rdFlat.AutoSize = true;
            this.rdFlat.Location = new System.Drawing.Point(188, 165);
            this.rdFlat.Name = "rdFlat";
            this.rdFlat.Size = new System.Drawing.Size(96, 24);
            this.rdFlat.TabIndex = 2;
            this.rdFlat.TabStop = true;
            this.rdFlat.Text = "Kiểu Flat";
            this.rdFlat.UseVisualStyleBackColor = true;
            this.rdFlat.CheckedChanged += new System.EventHandler(this.rdFlat_CheckedChanged);
            // 
            // rdPopup
            // 
            this.rdPopup.AutoSize = true;
            this.rdPopup.Location = new System.Drawing.Point(188, 205);
            this.rdPopup.Name = "rdPopup";
            this.rdPopup.Size = new System.Drawing.Size(115, 24);
            this.rdPopup.TabIndex = 3;
            this.rdPopup.TabStop = true;
            this.rdPopup.Text = "Kiểu Popup";
            this.rdPopup.UseVisualStyleBackColor = true;
            // 
            // ckbMauChu
            // 
            this.ckbMauChu.AutoSize = true;
            this.ckbMauChu.Location = new System.Drawing.Point(188, 44);
            this.ckbMauChu.Name = "ckbMauChu";
            this.ckbMauChu.Size = new System.Drawing.Size(159, 24);
            this.ckbMauChu.TabIndex = 4;
            this.ckbMauChu.Text = "Thay đổi màu chữ";
            this.ckbMauChu.UseVisualStyleBackColor = true;
            this.ckbMauChu.CheckedChanged += new System.EventHandler(this.ckbMauChu_CheckedChanged);
            // 
            // ckbMauNen
            // 
            this.ckbMauNen.AutoSize = true;
            this.ckbMauNen.Location = new System.Drawing.Point(188, 86);
            this.ckbMauNen.Name = "ckbMauNen";
            this.ckbMauNen.Size = new System.Drawing.Size(160, 24);
            this.ckbMauNen.TabIndex = 5;
            this.ckbMauNen.Text = "Thay đổi màu nền";
            this.ckbMauNen.UseVisualStyleBackColor = true;
            this.ckbMauNen.CheckedChanged += new System.EventHandler(this.ckbMauNen_CheckedChanged);
            // 
            // frmButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 280);
            this.Controls.Add(this.ckbMauNen);
            this.Controls.Add(this.ckbMauChu);
            this.Controls.Add(this.rdPopup);
            this.Controls.Add(this.rdFlat);
            this.Controls.Add(this.btnFlat);
            this.Controls.Add(this.btnButton);
            this.Name = "frmButtons";
            this.Text = "Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnFlat;
        private System.Windows.Forms.RadioButton rdFlat;
        private System.Windows.Forms.RadioButton rdPopup;
        private System.Windows.Forms.CheckBox ckbMauChu;
        private System.Windows.Forms.CheckBox ckbMauNen;
    }
}

