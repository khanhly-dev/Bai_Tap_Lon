namespace Bai_Tap_Lon
{
    partial class SellForm
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
            this.Employee_BTN = new System.Windows.Forms.Button();
            this.Customer_BTN = new System.Windows.Forms.Button();
            this.Transfer_BTN = new System.Windows.Forms.Button();
            this.DashBoard_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cancel_BTN = new System.Windows.Forms.Button();
            this.CompleteBill_BTN = new System.Windows.Forms.Button();
            this.Print_BTN = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Add_BTN = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ProductSeach_CBB = new System.Windows.Forms.ComboBox();
            this.TypeSeach_CBB = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý bán hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Employee_BTN);
            this.panel1.Controls.Add(this.Customer_BTN);
            this.panel1.Controls.Add(this.Transfer_BTN);
            this.panel1.Controls.Add(this.DashBoard_BTN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 615);
            this.panel1.TabIndex = 2;
            // 
            // Employee_BTN
            // 
            this.Employee_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_BTN.Location = new System.Drawing.Point(3, 421);
            this.Employee_BTN.Name = "Employee_BTN";
            this.Employee_BTN.Size = new System.Drawing.Size(221, 115);
            this.Employee_BTN.TabIndex = 4;
            this.Employee_BTN.Text = "Nhân viên";
            this.Employee_BTN.UseVisualStyleBackColor = true;
            this.Employee_BTN.Click += new System.EventHandler(this.Employee_BTN_Click);
            // 
            // Customer_BTN
            // 
            this.Customer_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_BTN.Location = new System.Drawing.Point(3, 300);
            this.Customer_BTN.Name = "Customer_BTN";
            this.Customer_BTN.Size = new System.Drawing.Size(221, 115);
            this.Customer_BTN.TabIndex = 3;
            this.Customer_BTN.Text = "Khách hàng";
            this.Customer_BTN.UseVisualStyleBackColor = true;
            this.Customer_BTN.Click += new System.EventHandler(this.Customer_BTN_Click);
            // 
            // Transfer_BTN
            // 
            this.Transfer_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transfer_BTN.Location = new System.Drawing.Point(3, 179);
            this.Transfer_BTN.Name = "Transfer_BTN";
            this.Transfer_BTN.Size = new System.Drawing.Size(221, 115);
            this.Transfer_BTN.TabIndex = 2;
            this.Transfer_BTN.Text = "Giao dịch";
            this.Transfer_BTN.UseVisualStyleBackColor = true;
            this.Transfer_BTN.Click += new System.EventHandler(this.Transfer_BTN_Click);
            // 
            // DashBoard_BTN
            // 
            this.DashBoard_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard_BTN.Location = new System.Drawing.Point(3, 60);
            this.DashBoard_BTN.Name = "DashBoard_BTN";
            this.DashBoard_BTN.Size = new System.Drawing.Size(221, 115);
            this.DashBoard_BTN.TabIndex = 1;
            this.DashBoard_BTN.Text = "Danh mục";
            this.DashBoard_BTN.UseVisualStyleBackColor = true;
            this.DashBoard_BTN.Click += new System.EventHandler(this.DashBoard_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản lý";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Cancel_BTN);
            this.panel2.Controls.Add(this.CompleteBill_BTN);
            this.panel2.Controls.Add(this.Print_BTN);
            this.panel2.Location = new System.Drawing.Point(261, 644);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 72);
            this.panel2.TabIndex = 0;
            // 
            // Cancel_BTN
            // 
            this.Cancel_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_BTN.Location = new System.Drawing.Point(412, 14);
            this.Cancel_BTN.Name = "Cancel_BTN";
            this.Cancel_BTN.Size = new System.Drawing.Size(107, 45);
            this.Cancel_BTN.TabIndex = 2;
            this.Cancel_BTN.Text = "Hủy";
            this.Cancel_BTN.UseVisualStyleBackColor = true;
            // 
            // CompleteBill_BTN
            // 
            this.CompleteBill_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteBill_BTN.Location = new System.Drawing.Point(255, 14);
            this.CompleteBill_BTN.Name = "CompleteBill_BTN";
            this.CompleteBill_BTN.Size = new System.Drawing.Size(107, 45);
            this.CompleteBill_BTN.TabIndex = 1;
            this.CompleteBill_BTN.Text = "Thanh toán";
            this.CompleteBill_BTN.UseVisualStyleBackColor = true;
            // 
            // Print_BTN
            // 
            this.Print_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_BTN.Location = new System.Drawing.Point(92, 14);
            this.Print_BTN.Name = "Print_BTN";
            this.Print_BTN.Size = new System.Drawing.Size(107, 45);
            this.Print_BTN.TabIndex = 0;
            this.Print_BTN.Text = "In";
            this.Print_BTN.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(862, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 615);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.Add_BTN);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.ProductSeach_CBB);
            this.panel3.Controls.Add(this.TypeSeach_CBB);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(261, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 537);
            this.panel3.TabIndex = 3;
            // 
            // Add_BTN
            // 
            this.Add_BTN.Location = new System.Drawing.Point(553, 58);
            this.Add_BTN.Name = "Add_BTN";
            this.Add_BTN.Size = new System.Drawing.Size(39, 28);
            this.Add_BTN.TabIndex = 6;
            this.Add_BTN.Text = "thêm";
            this.Add_BTN.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(504, 60);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 26);
            this.numericUpDown1.TabIndex = 5;
            // 
            // ProductSeach_CBB
            // 
            this.ProductSeach_CBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSeach_CBB.FormattingEnabled = true;
            this.ProductSeach_CBB.Location = new System.Drawing.Point(126, 60);
            this.ProductSeach_CBB.Name = "ProductSeach_CBB";
            this.ProductSeach_CBB.Size = new System.Drawing.Size(372, 28);
            this.ProductSeach_CBB.TabIndex = 4;
            // 
            // TypeSeach_CBB
            // 
            this.TypeSeach_CBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeSeach_CBB.FormattingEnabled = true;
            this.TypeSeach_CBB.ItemHeight = 20;
            this.TypeSeach_CBB.Location = new System.Drawing.Point(3, 60);
            this.TypeSeach_CBB.Name = "TypeSeach_CBB";
            this.TypeSeach_CBB.Size = new System.Drawing.Size(117, 28);
            this.TypeSeach_CBB.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 94);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(589, 440);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bán hàng";
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 750);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "SellForm";
            this.Text = "SellForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cancel_BTN;
        private System.Windows.Forms.Button CompleteBill_BTN;
        private System.Windows.Forms.Button Print_BTN;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox ProductSeach_CBB;
        private System.Windows.Forms.ComboBox TypeSeach_CBB;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add_BTN;
        private System.Windows.Forms.Button Employee_BTN;
        private System.Windows.Forms.Button Customer_BTN;
        private System.Windows.Forms.Button Transfer_BTN;
        private System.Windows.Forms.Button DashBoard_BTN;
    }
}