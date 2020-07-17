namespace QuanLyKho
{
    partial class Form_ListOutputInfor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.lb_idinput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_pricetotal = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_supplier = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.matax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.lb_customer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_excel
            // 
            this.btn_excel.BackColor = System.Drawing.Color.Transparent;
            this.btn_excel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.Location = new System.Drawing.Point(484, 141);
            this.btn_excel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(200, 44);
            this.btn_excel.TabIndex = 185;
            this.btn_excel.Text = "In phiếu xuất(PDF)";
            this.btn_excel.UseVisualStyleBackColor = false;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.Transparent;
            this.btn_report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Location = new System.Drawing.Point(484, 85);
            this.btn_report.Margin = new System.Windows.Forms.Padding(4);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(200, 44);
            this.btn_report.TabIndex = 184;
            this.btn_report.Text = "Xem phiếu xuất";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // lb_idinput
            // 
            this.lb_idinput.AutoSize = true;
            this.lb_idinput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idinput.Location = new System.Drawing.Point(270, 22);
            this.lb_idinput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_idinput.Name = "lb_idinput";
            this.lb_idinput.Size = new System.Drawing.Size(115, 19);
            this.lb_idinput.TabIndex = 183;
            this.lb_idinput.Text = "Tên nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 182;
            this.label2.Text = "Mã phiếu xuất:";
            // 
            // lb_pricetotal
            // 
            this.lb_pricetotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_pricetotal.AutoSize = true;
            this.lb_pricetotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pricetotal.Location = new System.Drawing.Point(574, 437);
            this.lb_pricetotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pricetotal.Name = "lb_pricetotal";
            this.lb_pricetotal.Size = new System.Drawing.Size(136, 19);
            this.lb_pricetotal.TabIndex = 181;
            this.lb_pricetotal.Text = "Tổng giá trị đơn hàng";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(270, 174);
            this.lb_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(70, 19);
            this.lb_user.TabIndex = 180;
            this.lb_user.Text = "Người lập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(132, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 178;
            this.label9.Text = "Người lập:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(427, 437);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 19);
            this.label12.TabIndex = 179;
            this.label12.Text = "Tổng giá trị đơn hàng:";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "Quantity";
            this.quantity.HeaderText = "Số lượng";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            dataGridViewCellStyle7.Format = "N0";
            this.price.DefaultCellStyle = dataGridViewCellStyle7;
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            // 
            // lb_supplier
            // 
            this.lb_supplier.AutoSize = true;
            this.lb_supplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplier.Location = new System.Drawing.Point(270, 60);
            this.lb_supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_supplier.Name = "lb_supplier";
            this.lb_supplier.Size = new System.Drawing.Size(115, 19);
            this.lb_supplier.TabIndex = 176;
            this.lb_supplier.Text = "Tên nhà cung cấp";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(270, 136);
            this.lb_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(64, 19);
            this.lb_date.TabIndex = 177;
            this.lb_date.Text = "Ngày lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 174;
            this.label4.Text = "Tên nhà cung cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 175;
            this.label5.Text = "Ngày lập:";
            // 
            // matax
            // 
            this.matax.DataPropertyName = "unit";
            this.matax.HeaderText = "Đơn vị tính";
            this.matax.Name = "matax";
            // 
            // name
            // 
            this.name.DataPropertyName = "DisplayName";
            this.name.HeaderText = "Tên sản phẩm";
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name.Width = 190;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // sumprice
            // 
            this.sumprice.DataPropertyName = "PriceTotal";
            dataGridViewCellStyle8.Format = "N0";
            this.sumprice.DefaultCellStyle = dataGridViewCellStyle8;
            this.sumprice.HeaderText = "Giá trị đơn hàng";
            this.sumprice.Name = "sumprice";
            this.sumprice.Width = 130;
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToResizeColumns = false;
            this.dgv_data.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Format = "N0";
            this.dgv_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_data.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.name,
            this.matax,
            this.price,
            this.quantity,
            this.sumprice});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            this.dgv_data.Location = new System.Drawing.Point(25, 233);
            this.dgv_data.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_data.Name = "dgv_data";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_data.RowHeadersVisible = false;
            this.dgv_data.Size = new System.Drawing.Size(700, 200);
            this.dgv_data.TabIndex = 173;
            this.dgv_data.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_data_RowsAdded);
            // 
            // lb_customer
            // 
            this.lb_customer.AutoSize = true;
            this.lb_customer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customer.Location = new System.Drawing.Point(270, 98);
            this.lb_customer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_customer.Name = "lb_customer";
            this.lb_customer.Size = new System.Drawing.Size(104, 19);
            this.lb_customer.TabIndex = 187;
            this.lb_customer.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 186;
            this.label3.Text = "Tên khách hàng:";
            // 
            // Form_ListOutputInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 495);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_pricetotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.lb_customer);
            this.Controls.Add(this.lb_idinput);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lb_supplier);
            this.Controls.Add(this.lb_date);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ListOutputInfor";
            this.Text = "Form_ListOutputInfor";
            this.Load += new System.EventHandler(this.Form_ListOutputInfor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Label lb_idinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_pricetotal;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label lb_supplier;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn matax;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumprice;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Label lb_customer;
        private System.Windows.Forms.Label label3;
    }
}