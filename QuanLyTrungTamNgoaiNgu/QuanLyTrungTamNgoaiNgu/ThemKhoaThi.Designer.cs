
namespace QuanLyTrungTamNgoaiNgu
{
    partial class ThemKhoaThi
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
            this.dateKhoaThi = new System.Windows.Forms.DateTimePicker();
            this.btn_Them = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateKhoaThi
            // 
            this.dateKhoaThi.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateKhoaThi.CustomFormat = "dd/MM/yyyy";
            this.dateKhoaThi.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateKhoaThi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateKhoaThi.Location = new System.Drawing.Point(12, 12);
            this.dateKhoaThi.MinDate = new System.DateTime(2022, 1, 5, 0, 0, 0, 0);
            this.dateKhoaThi.Name = "dateKhoaThi";
            this.dateKhoaThi.Size = new System.Drawing.Size(226, 57);
            this.dateKhoaThi.TabIndex = 0;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(245, 13);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(124, 56);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // ThemKhoaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 78);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dateKhoaThi);
            this.Name = "ThemKhoaThi";
            this.Text = "Thêm Khóa Thi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateKhoaThi;
        private System.Windows.Forms.Button btn_Them;
    }
}