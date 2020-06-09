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
            this.TransferTC = new System.Windows.Forms.TabControl();
            this.Export_TC = new System.Windows.Forms.TabPage();
            this.ExportBill_DGV = new System.Windows.Forms.DataGridView();
            this.ExportSeach_BTN = new System.Windows.Forms.Button();
            this.ExportSeachBill_CBB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Import_TC = new System.Windows.Forms.TabPage();
            this.ImportBill_DGV = new System.Windows.Forms.DataGridView();
            this.Supplier_BTN = new System.Windows.Forms.Button();
            this.Import_BTN = new System.Windows.Forms.Button();
            this.ImportSeach_BTN = new System.Windows.Forms.Button();
            this.TypeSeach_CBB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OK_BTN = new System.Windows.Forms.Button();
            this.Cancel_BTN = new System.Windows.Forms.Button();
            this.ImportSeach_TBX = new System.Windows.Forms.TextBox();
            this.TransferTC.SuspendLayout();
            this.Export_TC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExportBill_DGV)).BeginInit();
            this.Import_TC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBill_DGV)).BeginInit();
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
            // TransferTC
            // 
            this.TransferTC.Controls.Add(this.Export_TC);
            this.TransferTC.Controls.Add(this.Import_TC);
            this.TransferTC.Location = new System.Drawing.Point(72, 113);
            this.TransferTC.Name = "TransferTC";
            this.TransferTC.SelectedIndex = 0;
            this.TransferTC.Size = new System.Drawing.Size(1040, 502);
            this.TransferTC.TabIndex = 1;
            // 
            // Export_TC
            // 
            this.Export_TC.Controls.Add(this.ExportBill_DGV);
            this.Export_TC.Controls.Add(this.ExportSeach_BTN);
            this.Export_TC.Controls.Add(this.ExportSeachBill_CBB);
            this.Export_TC.Controls.Add(this.label2);
            this.Export_TC.Location = new System.Drawing.Point(4, 22);
            this.Export_TC.Name = "Export_TC";
            this.Export_TC.Padding = new System.Windows.Forms.Padding(3);
            this.Export_TC.Size = new System.Drawing.Size(1032, 476);
            this.Export_TC.TabIndex = 0;
            this.Export_TC.Text = "Hóa đơn xuất";
            this.Export_TC.UseVisualStyleBackColor = true;
            // 
            // ExportBill_DGV
            // 
            this.ExportBill_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExportBill_DGV.Location = new System.Drawing.Point(6, 95);
            this.ExportBill_DGV.Name = "ExportBill_DGV";
            this.ExportBill_DGV.Size = new System.Drawing.Size(1020, 375);
            this.ExportBill_DGV.TabIndex = 4;
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
            // ExportSeachBill_CBB
            // 
            this.ExportSeachBill_CBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportSeachBill_CBB.FormattingEnabled = true;
            this.ExportSeachBill_CBB.Location = new System.Drawing.Point(6, 61);
            this.ExportSeachBill_CBB.Name = "ExportSeachBill_CBB";
            this.ExportSeachBill_CBB.Size = new System.Drawing.Size(597, 28);
            this.ExportSeachBill_CBB.TabIndex = 2;
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
            // Import_TC
            // 
            this.Import_TC.Controls.Add(this.ImportSeach_TBX);
            this.Import_TC.Controls.Add(this.ImportBill_DGV);
            this.Import_TC.Controls.Add(this.Supplier_BTN);
            this.Import_TC.Controls.Add(this.Import_BTN);
            this.Import_TC.Controls.Add(this.ImportSeach_BTN);
            this.Import_TC.Controls.Add(this.TypeSeach_CBB);
            this.Import_TC.Controls.Add(this.label3);
            this.Import_TC.Location = new System.Drawing.Point(4, 22);
            this.Import_TC.Name = "Import_TC";
            this.Import_TC.Padding = new System.Windows.Forms.Padding(3);
            this.Import_TC.Size = new System.Drawing.Size(1032, 476);
            this.Import_TC.TabIndex = 1;
            this.Import_TC.Text = "Hóa đơn nhập";
            this.Import_TC.UseVisualStyleBackColor = true;
            // 
            // ImportBill_DGV
            // 
            this.ImportBill_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportBill_DGV.Location = new System.Drawing.Point(127, 130);
            this.ImportBill_DGV.Name = "ImportBill_DGV";
            this.ImportBill_DGV.Size = new System.Drawing.Size(899, 340);
            this.ImportBill_DGV.TabIndex = 7;
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
            // ImportSeach_BTN
            // 
            this.ImportSeach_BTN.Location = new System.Drawing.Point(764, 95);
            this.ImportSeach_BTN.Name = "ImportSeach_BTN";
            this.ImportSeach_BTN.Size = new System.Drawing.Size(75, 28);
            this.ImportSeach_BTN.TabIndex = 4;
            this.ImportSeach_BTN.Text = "Tìm";
            this.ImportSeach_BTN.UseVisualStyleBackColor = true;
            this.ImportSeach_BTN.Click += new System.EventHandler(this.ImportSeach_BTN_Click);
            // 
            // TypeSeach_CBB
            // 
            this.TypeSeach_CBB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TypeSeach_CBB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TypeSeach_CBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeSeach_CBB.FormattingEnabled = true;
            this.TypeSeach_CBB.Items.AddRange(new object[] {
            "Mã hàng",
            "Nhà cung cấp",
            "Ngày nhập"});
            this.TypeSeach_CBB.Location = new System.Drawing.Point(127, 95);
            this.TypeSeach_CBB.Name = "TypeSeach_CBB";
            this.TypeSeach_CBB.Size = new System.Drawing.Size(121, 28);
            this.TypeSeach_CBB.TabIndex = 2;
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
            // ImportSeach_TBX
            // 
            this.ImportSeach_TBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportSeach_TBX.Location = new System.Drawing.Point(255, 95);
            this.ImportSeach_TBX.Multiline = true;
            this.ImportSeach_TBX.Name = "ImportSeach_TBX";
            this.ImportSeach_TBX.Size = new System.Drawing.Size(503, 28);
            this.ImportSeach_TBX.TabIndex = 8;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 750);
            this.Controls.Add(this.Cancel_BTN);
            this.Controls.Add(this.OK_BTN);
            this.Controls.Add(this.TransferTC);
            this.Controls.Add(this.label1);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.TransferTC.ResumeLayout(false);
            this.Export_TC.ResumeLayout(false);
            this.Export_TC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExportBill_DGV)).EndInit();
            this.Import_TC.ResumeLayout(false);
            this.Import_TC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBill_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TransferTC;
        private System.Windows.Forms.TabPage Export_TC;
        private System.Windows.Forms.Button ExportSeach_BTN;
        private System.Windows.Forms.ComboBox ExportSeachBill_CBB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Import_TC;
        private System.Windows.Forms.Button ImportSeach_BTN;
        private System.Windows.Forms.ComboBox TypeSeach_CBB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OK_BTN;
        private System.Windows.Forms.Button Cancel_BTN;
        private System.Windows.Forms.Button Supplier_BTN;
        private System.Windows.Forms.Button Import_BTN;
        private System.Windows.Forms.DataGridView ImportBill_DGV;
        private System.Windows.Forms.DataGridView ExportBill_DGV;
        private System.Windows.Forms.TextBox ImportSeach_TBX;
    }
}