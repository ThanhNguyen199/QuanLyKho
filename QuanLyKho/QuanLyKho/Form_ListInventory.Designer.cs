namespace QuanLyKho
{
    partial class Form_ListInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.lb_price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grb_supplier = new System.Windows.Forms.GroupBox();
            this.lb_mail = new System.Windows.Forms.Label();
            this.lb_note = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_supplier = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.cbb_taxcode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.grb_supplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 28);
            this.label11.TabIndex = 156;
            this.label11.Text = "Tồn kho";
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToResizeColumns = false;
            this.dgv_data.AllowUserToResizeRows = false;
            this.dgv_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_data.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.name,
            this.supplier,
            this.matax,
            this.price,
            this.quantity,
            this.sumprice});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            this.dgv_data.Location = new System.Drawing.Point(25, 337);
            this.dgv_data.Name = "dgv_data";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_data.RowHeadersVisible = false;
            this.dgv_data.Size = new System.Drawing.Size(700, 200);
            this.dgv_data.TabIndex = 159;
            this.dgv_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_CellClick);
            this.dgv_data.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_data_RowsAdded);
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(261, 282);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(77, 19);
            this.lb_price.TabIndex = 161;
            this.lb_price.Text = "Tổng giá trị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 19);
            this.label2.TabIndex = 160;
            this.label2.Text = "Tổng giá trị hàng trong kho:";
            // 
            // grb_supplier
            // 
            this.grb_supplier.Controls.Add(this.lb_mail);
            this.grb_supplier.Controls.Add(this.lb_note);
            this.grb_supplier.Controls.Add(this.label9);
            this.grb_supplier.Controls.Add(this.label12);
            this.grb_supplier.Controls.Add(this.lb_supplier);
            this.grb_supplier.Controls.Add(this.lb_address);
            this.grb_supplier.Controls.Add(this.lb_phone);
            this.grb_supplier.Controls.Add(this.cbb_taxcode);
            this.grb_supplier.Controls.Add(this.label3);
            this.grb_supplier.Controls.Add(this.label4);
            this.grb_supplier.Controls.Add(this.label10);
            this.grb_supplier.Controls.Add(this.label5);
            this.grb_supplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_supplier.Location = new System.Drawing.Point(43, 55);
            this.grb_supplier.Name = "grb_supplier";
            this.grb_supplier.Size = new System.Drawing.Size(549, 194);
            this.grb_supplier.TabIndex = 162;
            this.grb_supplier.TabStop = false;
            this.grb_supplier.Text = "Nhà cung cấp";
            // 
            // lb_mail
            // 
            this.lb_mail.AutoSize = true;
            this.lb_mail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mail.Location = new System.Drawing.Point(289, 58);
            this.lb_mail.Name = "lb_mail";
            this.lb_mail.Size = new System.Drawing.Size(36, 19);
            this.lb_mail.TabIndex = 152;
            this.lb_mail.Text = "Mail";
            // 
            // lb_note
            // 
            this.lb_note.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_note.Location = new System.Drawing.Point(84, 85);
            this.lb_note.Name = "lb_note";
            this.lb_note.Size = new System.Drawing.Size(253, 38);
            this.lb_note.TabIndex = 153;
            this.lb_note.Text = "Ghi chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(210, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 150;
            this.label9.Text = "Mail:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 19);
            this.label12.TabIndex = 151;
            this.label12.Text = "Ghi chú:";
            // 
            // lb_supplier
            // 
            this.lb_supplier.AutoSize = true;
            this.lb_supplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplier.Location = new System.Drawing.Point(289, 22);
            this.lb_supplier.Name = "lb_supplier";
            this.lb_supplier.Size = new System.Drawing.Size(115, 19);
            this.lb_supplier.TabIndex = 147;
            this.lb_supplier.Text = "Tên nhà cung cấp";
            // 
            // lb_address
            // 
            this.lb_address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(84, 133);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(253, 38);
            this.lb_address.TabIndex = 149;
            this.lb_address.Text = "Địa chỉ";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(84, 56);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(88, 19);
            this.lb_phone.TabIndex = 148;
            this.lb_phone.Text = "Số điện thoại";
            // 
            // cbb_taxcode
            // 
            this.cbb_taxcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_taxcode.FormattingEnabled = true;
            this.cbb_taxcode.Location = new System.Drawing.Point(84, 19);
            this.cbb_taxcode.Name = "cbb_taxcode";
            this.cbb_taxcode.Size = new System.Drawing.Size(120, 27);
            this.cbb_taxcode.TabIndex = 146;
            this.cbb_taxcode.SelectedIndexChanged += new System.EventHandler(this.cbb_taxcode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 131;
            this.label3.Text = "Mã Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 132;
            this.label4.Text = "Tên NCC:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 143;
            this.label10.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 134;
            this.label5.Text = "SĐT:";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(633, 90);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(80, 30);
            this.btn_search.TabIndex = 170;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(633, 134);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 30);
            this.btn_cancel.TabIndex = 171;
            this.btn_cancel.Text = "Huỷ";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "DisplayName";
            this.name.HeaderText = "Tên sản phẩm";
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name.Width = 190;
            // 
            // supplier
            // 
            this.supplier.DataPropertyName = "namesupplier";
            this.supplier.HeaderText = "Nhà cung cấp";
            this.supplier.Name = "supplier";
            this.supplier.Width = 250;
            // 
            // matax
            // 
            this.matax.DataPropertyName = "unit";
            this.matax.HeaderText = "Đơn vị tính";
            this.matax.Name = "matax";
            this.matax.Width = 70;
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "N0";
            this.price.DefaultCellStyle = dataGridViewCellStyle2;
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "Inventory";
            this.quantity.HeaderText = "Số lượng";
            this.quantity.Name = "quantity";
            this.quantity.Width = 60;
            // 
            // sumprice
            // 
            this.sumprice.DataPropertyName = "PriceTotal";
            dataGridViewCellStyle3.Format = "N0";
            this.sumprice.DefaultCellStyle = dataGridViewCellStyle3;
            this.sumprice.HeaderText = "Giá trị đơn hàng";
            this.sumprice.Name = "sumprice";
            this.sumprice.Width = 130;
            // 
            // Form_ListInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 560);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.grb_supplier);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgv_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ListInventory";
            this.Text = "Form_ListInventory";
            this.Load += new System.EventHandler(this.Form_ListInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.grb_supplier.ResumeLayout(false);
            this.grb_supplier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grb_supplier;
        private System.Windows.Forms.Label lb_mail;
        private System.Windows.Forms.Label lb_note;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_supplier;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.ComboBox cbb_taxcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn matax;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumprice;
    }
}