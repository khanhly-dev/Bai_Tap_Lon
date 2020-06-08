namespace Bai_Tap_Lon
{
    partial class TransferForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Export_TC = new System.Windows.Forms.TabPage();
            this.Import_TC = new System.Windows.Forms.TabPage();
            this.OK_BTN = new System.Windows.Forms.Button();
            this.Cancel_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ListBill_LV = new System.Windows.Forms.ListView();
            this.ExportSeachBill_CBB = new System.Windows.Forms.ComboBox();
            this.ExportSeach_BTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ImportBill_LV = new System.Windows.Forms.ListView();
            this.TypeSeach_CBB = new System.Windows.Forms.ComboBox();
            this.ImportSeachBill_CBB = new System.Windows.Forms.ComboBox();
            this.ImportSeach_BTN = new System.Windows.Forms.Button();
            this.Import_BTN = new System.Windows.Forms.Button();
            this.Supplier_BTN = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Export_TC.SuspendLayout();
            this.Import_TC.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao dịch";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Export_TC);
            this.tabControl1.Controls.Add(this.Import_TC);
            this.tabControl1.Location = new System.Drawing.Point(72, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 502);
            this.tabControl1.TabIndex = 1;
            // 
            // Export_TC
            // 
            this.Export_TC.Controls.Add(this.ExportSeach_BTN);
            this.Export_TC.Controls.Add(this.ExportSeachBill_CBB);
            this.Export_TC.Controls.Add(this.ListBill_LV);
            this.Export_TC.Controls.Add(this.label2);
            this.Export_TC.Location = new System.Drawing.Point(4, 22);
            this.Export_TC.Name = "Export_TC";
            this.Export_TC.Padding = new System.Windows.Forms.Padding(3);
            this.Export_TC.Size = new System.Drawing.Size(1032, 476);
            this.Export_TC.TabIndex = 0;
            this.Export_TC.Text = "Hóa đơn xuất";
            this.Export_TC.UseVisualStyleBackColor = true;
            // 
            // Import_TC
            // 
            this.Import_TC.Controls.Add(this.Supplier_BTN);
            this.Import_TC.Controls.Add(this.Import_BTN);
            this.Import_TC.Controls.Add(this.ImportSeach_BTN);
            this.Import_TC.Controls.Add(this.ImportSeachBill_CBB);
            this.Import_TC.Controls.Add(this.TypeSeach_CBB);
            this.Import_TC.Controls.Add(this.ImportBill_LV);
            this.Import_TC.Controls.Add(this.label3);
            this.Import_TC.Location = new System.Drawing.Point(4, 22);
            this.Import_TC.Name = "Import_TC";
            this.Import_TC.Padding = new System.Windows.Forms.Padding(3);
            this.Import_TC.Size = new System.Drawing.Size(1032, 476);
            this.Import_TC.TabIndex = 1;
            this.Import_TC.Text = "Hóa đơn nhập";
            this.Import_TC.UseVisualStyleBackColor = true;
            // 
            // OK_BTN
            // 
            this.OK_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_BTN.Location = new System.Drawing.Point(691, 654);
            this.OK_BTN.Name = "OK_BTN";
            this.OK_BTN.Size = new System.Drawing.Size(108, 44);
            this.OK_BTN.TabIndex = 2;
            this.OK_BTN.Text = "OK";
            this.OK_BTN.UseVisualStyleBackColor = true;
            // 
            // Cancel_BTN
            // 
            this.Cancel_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_BTN.Location = new System.Drawing.Point(829, 654);
            this.Cancel_BTN.Name = "Cancel_BTN";
            this.Cancel_BTN.Size = new System.Drawing.Size(108, 44);
            this.Cancel_BTN.TabIndex = 3;
            this.Cancel_BTN.Text = "Cancel";
            this.Cancel_BTN.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "HĐ bán";
            // 
            // ListBill_LV
            // 
            this.ListBill_LV.HideSelection = false;
            this.ListBill_LV.Location = new System.Drawing.Point(6, 95);
            this.ListBill_LV.Name = "ListBill_LV";
            this.ListBill_LV.Size = new System.Drawing.Size(1020, 375);
            this.ListBill_LV.TabIndex = 1;
            this.ListBill_LV.UseCompatibleStateImageBehavior = false;
            // 
            // ExportSeachBill_CBB
            // 
            this.ExportSeachBill_CBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportSeachBill_CBB.FormattingEnabled = true;
            this.ExportSeachBill_CBB.Location = new System.Drawing.Point(6, 61);
            this.ExportSeachBill_CBB.Name = "ExportSeachBill_CBB";
            this.ExportSeachBill_CBB.Size = new System.Drawing.Size(597, 28);
            this.ExportSeachBill_CBB.TabIndex = 2;
            // 
            // ExportSeach_BTN
            // 
            this.ExportSeach_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportSeach_BTN.Location = new System.Drawing.Point(609, 61);
            this.ExportSeach_BTN.Name = "ExportSeach_BTN";
            this.ExportSeach_BTN.Size = new System.Drawing.Size(51, 28);
            this.ExportSeach_BTN.TabIndex = 3;
            this.ExportSeach_BTN.Text = "Tìm";
            this.ExportSeach_BTN.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "HĐ nhập";
            // 
            // ImportBill_LV
            // 
            this.ImportBill_LV.HideSelection = false;
            this.ImportBill_LV.Location = new System.Drawing.Point(127, 129);
            this.ImportBill_LV.Name = "ImportBill_LV";
            this.ImportBill_LV.Size = new System.Drawing.Size(899, 341);
            this.ImportBill_LV.TabIndex = 1;
            this.ImportBill_LV.UseCompatibleStateImageBehavior = false;
            // 
            // TypeSeach_CBB
            // 
            this.TypeSeach_CBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeSeach_CBB.FormattingEnabled = true;
            this.TypeSeach_CBB.Location = new System.Drawing.Point(127, 95);
            this.TypeSeach_CBB.Name = "TypeSeach_CBB";
            this.TypeSeach_CBB.Size = new System.Drawing.Size(121, 28);
            this.TypeSeach_CBB.TabIndex = 2;
            // 
            // ImportSeachBill_CBB
            // 
            this.ImportSeachBill_CBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportSeachBill_CBB.FormattingEnabled = true;
            this.ImportSeachBill_CBB.Location = new System.Drawing.Point(254, 95);
            this.ImportSeachBill_CBB.Name = "ImportSeachBill_CBB";
            this.ImportSeachBill_CBB.Size = new System.Drawing.Size(504, 28);
            this.ImportSeachBill_CBB.TabIndex = 3;
            // 
            // ImportSeach_BTN
            // 
            this.ImportSeach_BTN.Location = new System.Drawing.Point(764, 95);
            this.ImportSeach_BTN.Name = "ImportSeach_BTN";
            this.ImportSeach_BTN.Size = new System.Drawing.Size(75, 28);
            this.ImportSeach_BTN.TabIndex = 4;
            this.ImportSeach_BTN.Text = "Tìm";
            this.ImportSeach_BTN.UseVisualStyleBackColor = true;
            // 
            // Import_BTN
            // 
            this.Import_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Import_BTN.Location = new System.Drawing.Point(15, 129);
            this.Import_BTN.Name = "Import_BTN";
            this.Import_BTN.Size = new System.Drawing.Size(97, 42);
            this.Import_BTN.TabIndex = 5;
            this.Import_BTN.Text = "Nhập hàng";
            this.Import_BTN.UseVisualStyleBackColor = true;
            // 
            // Supplier_BTN
            // 
            this.Supplier_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_BTN.Location = new System.Drawing.Point(15, 191);
            this.Supplier_BTN.Name = "Supplier_BTN";
            this.Supplier_BTN.Size = new System.Drawing.Size(97, 42);
            this.Supplier_BTN.TabIndex = 6;
            this.Supplier_BTN.Text = "NCC";
            this.Supplier_BTN.UseVisualStyleBackColor = true;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 750);
            this.Controls.Add(this.Cancel_BTN);
            this.Controls.Add(this.OK_BTN);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.tabControl1.ResumeLayout(false);
            this.Export_TC.ResumeLayout(false);
            this.Export_TC.PerformLayout();
            this.Import_TC.ResumeLayout(false);
            this.Import_TC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Export_TC;
        private System.Windows.Forms.Button ExportSeach_BTN;
        private System.Windows.Forms.ComboBox ExportSeachBill_CBB;
        private System.Windows.Forms.ListView ListBill_LV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Import_TC;
        private System.Windows.Forms.Button ImportSeach_BTN;
        private System.Windows.Forms.ComboBox ImportSeachBill_CBB;
        private System.Windows.Forms.ComboBox TypeSeach_CBB;
        private System.Windows.Forms.ListView ImportBill_LV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OK_BTN;
        private System.Windows.Forms.Button Cancel_BTN;
        private System.Windows.Forms.Button Supplier_BTN;
        private System.Windows.Forms.Button Import_BTN;
    }
}