namespace Bai_Tap_Lon
{
    partial class DashBoardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DashBoard_DGV = new System.Windows.Forms.DataGridView();
            this.ProductSeach_TBX = new System.Windows.Forms.TextBox();
            this.Seasch_BTN = new System.Windows.Forms.Button();
            this.TypeSeach_CBB = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Edit_BTN = new System.Windows.Forms.Button();
            this.Delete_BTN = new System.Windows.Forms.Button();
            this.Add_BTN = new System.Windows.Forms.Button();
            this.OK_BTN = new System.Windows.Forms.Button();
            this.Cancel_BTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoard_DGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DashBoard_DGV);
            this.panel1.Controls.Add(this.ProductSeach_TBX);
            this.panel1.Controls.Add(this.Seasch_BTN);
            this.panel1.Controls.Add(this.TypeSeach_CBB);
            this.panel1.Location = new System.Drawing.Point(159, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 446);
            this.panel1.TabIndex = 1;
            // 
            // DashBoard_DGV
            // 
            this.DashBoard_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DashBoard_DGV.Location = new System.Drawing.Point(4, 37);
            this.DashBoard_DGV.Name = "DashBoard_DGV";
            this.DashBoard_DGV.Size = new System.Drawing.Size(936, 406);
            this.DashBoard_DGV.TabIndex = 5;
            // 
            // ProductSeach_TBX
            // 
            this.ProductSeach_TBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSeach_TBX.Location = new System.Drawing.Point(112, 3);
            this.ProductSeach_TBX.Multiline = true;
            this.ProductSeach_TBX.Name = "ProductSeach_TBX";
            this.ProductSeach_TBX.Size = new System.Drawing.Size(385, 27);
            this.ProductSeach_TBX.TabIndex = 4;
            // 
            // Seasch_BTN
            // 
            this.Seasch_BTN.Location = new System.Drawing.Point(503, 3);
            this.Seasch_BTN.Name = "Seasch_BTN";
            this.Seasch_BTN.Size = new System.Drawing.Size(57, 28);
            this.Seasch_BTN.TabIndex = 3;
            this.Seasch_BTN.Text = "Tìm";
            this.Seasch_BTN.UseVisualStyleBackColor = true;
            this.Seasch_BTN.Click += new System.EventHandler(this.Seasch_BTN_Click);
            // 
            // TypeSeach_CBB
            // 
            this.TypeSeach_CBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeSeach_CBB.FormattingEnabled = true;
            this.TypeSeach_CBB.Items.AddRange(new object[] {
            "Khối lượng",
            "Loại",
            "Thời gian bảo hành"});
            this.TypeSeach_CBB.Location = new System.Drawing.Point(3, 3);
            this.TypeSeach_CBB.Name = "TypeSeach_CBB";
            this.TypeSeach_CBB.Size = new System.Drawing.Size(102, 28);
            this.TypeSeach_CBB.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Edit_BTN);
            this.panel2.Controls.Add(this.Delete_BTN);
            this.panel2.Controls.Add(this.Add_BTN);
            this.panel2.Location = new System.Drawing.Point(81, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 446);
            this.panel2.TabIndex = 2;
            // 
            // Edit_BTN
            // 
            this.Edit_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_BTN.Location = new System.Drawing.Point(12, 168);
            this.Edit_BTN.Name = "Edit_BTN";
            this.Edit_BTN.Size = new System.Drawing.Size(50, 50);
            this.Edit_BTN.TabIndex = 2;
            this.Edit_BTN.Text = "Sửa";
            this.Edit_BTN.UseVisualStyleBackColor = true;
            this.Edit_BTN.Click += new System.EventHandler(this.Edit_BTN_Click);
            // 
            // Delete_BTN
            // 
            this.Delete_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_BTN.Location = new System.Drawing.Point(12, 102);
            this.Delete_BTN.Name = "Delete_BTN";
            this.Delete_BTN.Size = new System.Drawing.Size(50, 50);
            this.Delete_BTN.TabIndex = 1;
            this.Delete_BTN.Text = "Xóa";
            this.Delete_BTN.UseVisualStyleBackColor = true;
            this.Delete_BTN.Click += new System.EventHandler(this.Delete_BTN_Click);
            // 
            // Add_BTN
            // 
            this.Add_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_BTN.Location = new System.Drawing.Point(12, 37);
            this.Add_BTN.Name = "Add_BTN";
            this.Add_BTN.Size = new System.Drawing.Size(50, 50);
            this.Add_BTN.TabIndex = 0;
            this.Add_BTN.Text = "Thêm";
            this.Add_BTN.UseVisualStyleBackColor = true;
            this.Add_BTN.Click += new System.EventHandler(this.Add_BTN_Click);
            // 
            // OK_BTN
            // 
            this.OK_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_BTN.Location = new System.Drawing.Point(678, 646);
            this.OK_BTN.Name = "OK_BTN";
            this.OK_BTN.Size = new System.Drawing.Size(107, 42);
            this.OK_BTN.TabIndex = 3;
            this.OK_BTN.Text = "OK";
            this.OK_BTN.UseVisualStyleBackColor = true;
            // 
            // Cancel_BTN
            // 
            this.Cancel_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_BTN.Location = new System.Drawing.Point(822, 646);
            this.Cancel_BTN.Name = "Cancel_BTN";
            this.Cancel_BTN.Size = new System.Drawing.Size(107, 42);
            this.Cancel_BTN.TabIndex = 4;
            this.Cancel_BTN.Text = "Cancel";
            this.Cancel_BTN.UseVisualStyleBackColor = true;
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 750);
            this.Controls.Add(this.Cancel_BTN);
            this.Controls.Add(this.OK_BTN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "DashBoardForm";
            this.Text = "DashBoardForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoard_DGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox TypeSeach_CBB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Seasch_BTN;
        private System.Windows.Forms.Button Edit_BTN;
        private System.Windows.Forms.Button Delete_BTN;
        private System.Windows.Forms.Button Add_BTN;
        private System.Windows.Forms.Button OK_BTN;
        private System.Windows.Forms.Button Cancel_BTN;
        private System.Windows.Forms.DataGridView DashBoard_DGV;
        private System.Windows.Forms.TextBox ProductSeach_TBX;
    }
}