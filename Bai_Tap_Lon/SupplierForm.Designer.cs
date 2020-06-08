namespace Bai_Tap_Lon
{
    partial class SupplierForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Seach_CBB = new System.Windows.Forms.ComboBox();
            this.Seach_BTN = new System.Windows.Forms.Button();
            this.Add_BTN = new System.Windows.Forms.Button();
            this.Delete_BTN = new System.Windows.Forms.Button();
            this.Edit_BTN = new System.Windows.Forms.Button();
            this.OK_BTN = new System.Windows.Forms.Button();
            this.Cancel_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhà cung cấp";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(198, 177);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(883, 430);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Seach_CBB
            // 
            this.Seach_CBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seach_CBB.FormattingEnabled = true;
            this.Seach_CBB.Location = new System.Drawing.Point(198, 142);
            this.Seach_CBB.Name = "Seach_CBB";
            this.Seach_CBB.Size = new System.Drawing.Size(535, 28);
            this.Seach_CBB.TabIndex = 2;
            // 
            // Seach_BTN
            // 
            this.Seach_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seach_BTN.Location = new System.Drawing.Point(739, 142);
            this.Seach_BTN.Name = "Seach_BTN";
            this.Seach_BTN.Size = new System.Drawing.Size(75, 28);
            this.Seach_BTN.TabIndex = 3;
            this.Seach_BTN.Text = "Tìm";
            this.Seach_BTN.UseVisualStyleBackColor = true;
            // 
            // Add_BTN
            // 
            this.Add_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_BTN.Location = new System.Drawing.Point(74, 177);
            this.Add_BTN.Name = "Add_BTN";
            this.Add_BTN.Size = new System.Drawing.Size(95, 50);
            this.Add_BTN.TabIndex = 4;
            this.Add_BTN.Text = "Thêm";
            this.Add_BTN.UseVisualStyleBackColor = true;
            // 
            // Delete_BTN
            // 
            this.Delete_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_BTN.Location = new System.Drawing.Point(74, 249);
            this.Delete_BTN.Name = "Delete_BTN";
            this.Delete_BTN.Size = new System.Drawing.Size(95, 50);
            this.Delete_BTN.TabIndex = 5;
            this.Delete_BTN.Text = "Xóa";
            this.Delete_BTN.UseVisualStyleBackColor = true;
            // 
            // Edit_BTN
            // 
            this.Edit_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_BTN.Location = new System.Drawing.Point(74, 323);
            this.Edit_BTN.Name = "Edit_BTN";
            this.Edit_BTN.Size = new System.Drawing.Size(95, 50);
            this.Edit_BTN.TabIndex = 6;
            this.Edit_BTN.Text = "Sửa";
            this.Edit_BTN.UseVisualStyleBackColor = true;
            // 
            // OK_BTN
            // 
            this.OK_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_BTN.Location = new System.Drawing.Point(719, 651);
            this.OK_BTN.Name = "OK_BTN";
            this.OK_BTN.Size = new System.Drawing.Size(115, 49);
            this.OK_BTN.TabIndex = 7;
            this.OK_BTN.Text = "OK";
            this.OK_BTN.UseVisualStyleBackColor = true;
            // 
            // Cancel_BTN
            // 
            this.Cancel_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_BTN.Location = new System.Drawing.Point(863, 651);
            this.Cancel_BTN.Name = "Cancel_BTN";
            this.Cancel_BTN.Size = new System.Drawing.Size(115, 49);
            this.Cancel_BTN.TabIndex = 8;
            this.Cancel_BTN.Text = "Cancel";
            this.Cancel_BTN.UseVisualStyleBackColor = true;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 750);
            this.Controls.Add(this.Cancel_BTN);
            this.Controls.Add(this.OK_BTN);
            this.Controls.Add(this.Edit_BTN);
            this.Controls.Add(this.Delete_BTN);
            this.Controls.Add(this.Add_BTN);
            this.Controls.Add(this.Seach_BTN);
            this.Controls.Add(this.Seach_CBB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox Seach_CBB;
        private System.Windows.Forms.Button Seach_BTN;
        private System.Windows.Forms.Button Add_BTN;
        private System.Windows.Forms.Button Delete_BTN;
        private System.Windows.Forms.Button Edit_BTN;
        private System.Windows.Forms.Button OK_BTN;
        private System.Windows.Forms.Button Cancel_BTN;
    }
}