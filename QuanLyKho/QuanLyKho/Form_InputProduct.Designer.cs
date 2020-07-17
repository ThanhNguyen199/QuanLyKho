namespace QuanLyKho
{
    partial class Form_InputProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_show = new System.Windows.Forms.Panel();
            this.panel_list = new System.Windows.Forms.Panel();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.panel_add = new System.Windows.Forms.Panel();
            this.lb_IdInput = new System.Windows.Forms.Label();
            this.cbb_user = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label11 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.matax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_list.SuspendLayout();
            this.panel_add.SuspendLayout();
            this.grb_supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_show
            // 
            this.panel_show.Location = new System.Drawing.Point(0, 65);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(750, 495);
            this.panel_show.TabIndex = 163;
            // 
            // panel_list
            // 
            this.panel_list.Controls.Add(this.btn_addproduct);
            this.panel_list.Controls.Add(this.panel_add);
            this.panel_list.Controls.Add(this.grb_supplier);
            this.panel_list.Controls.Add(this.label11);
            this.panel_list.Controls.Add(this.btn_cancel);
            this.panel_list.Controls.Add(this.btn_close);
            this.panel_list.Controls.Add(this.btn_add);
            this.panel_list.Controls.Add(this.btn_save);
            this.panel_list.Controls.Add(this.dgv_data);
            this.panel_list.Location = new System.Drawing.Point(0, 0);
            this.panel_list.Name = "panel_list";
            this.panel_list.Size = new System.Drawing.Size(750, 560);
            this.panel_list.TabIndex = 162;
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.BackColor = System.Drawing.Color.Transparent;
            this.btn_addproduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_addproduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_addproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addproduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addproduct.Location = new System.Drawing.Point(633, 208);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(80, 30);
            this.btn_addproduct.TabIndex = 160;
            this.btn_addproduct.Text = "Thêm SP";
            this.btn_addproduct.UseVisualStyleBackColor = false;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // panel_add
            // 
            this.panel_add.Controls.Add(this.lb_IdInput);
            this.panel_add.Controls.Add(this.cbb_user);
            this.panel_add.Controls.Add(this.label2);
            this.panel_add.Controls.Add(this.dateTimePicker1);
            this.panel_add.Controls.Add(this.label7);
            this.panel_add.Controls.Add(this.label1);
            this.panel_add.Location = new System.Drawing.Point(43, 266);
            this.panel_add.Name = "panel_add";
            this.panel_add.Size = new System.Drawing.Size(682, 65);
            this.panel_add.TabIndex = 158;
            // 
            // lb_IdInput
            // 
            this.lb_IdInput.AutoSize = true;
            this.lb_IdInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdInput.Location = new System.Drawing.Point(126, 23);
            this.lb_IdInput.Name = "lb_IdInput";
            this.lb_IdInput.Size = new System.Drawing.Size(53, 19);
            this.lb_IdInput.TabIndex = 149;
            this.lb_IdInput.Text = "IdInput";
            // 
            // cbb_user
            // 
            this.cbb_user.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_user.FormattingEnabled = true;
            this.cbb_user.Location = new System.Drawing.Point(306, 20);
            this.cbb_user.Name = "cbb_user";
            this.cbb_user.Size = new System.Drawing.Size(137, 27);
            this.cbb_user.TabIndex = 148;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 147;
            this.label2.Text = "Người lập:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(535, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(451, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ngày nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã phiếu nhập:";
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
            this.grb_supplier.Location = new System.Drawing.Point(66, 66);
            this.grb_supplier.Name = "grb_supplier";
            this.grb_supplier.Size = new System.Drawing.Size(549, 194);
            this.grb_supplier.TabIndex = 157;
            this.grb_supplier.TabStop = false;
            this.grb_supplier.Text = "Nhà cung cấp";
            // 
            // lb_mail
            // 
            this.lb_mail.AutoSize = true;
            this.lb_mail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mail.Location = new System.Drawing.Point(336, 58);
            this.lb_mail.Name = "lb_mail";
            this.lb_mail.Size = new System.Drawing.Size(36, 19);
            this.lb_mail.TabIndex = 152;
            this.lb_mail.Text = "Mail";
            // 
            // lb_note
            // 
            this.lb_note.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_note.Location = new System.Drawing.Point(336, 92);
            this.lb_note.Name = "lb_note";
            this.lb_note.Size = new System.Drawing.Size(149, 38);
            this.lb_note.TabIndex = 153;
            this.lb_note.Text = "Ghi chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(291, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 150;
            this.label9.Text = "Mail:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(272, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 19);
            this.label12.TabIndex = 151;
            this.label12.Text = "Ghi chú:";
            // 
            // lb_supplier
            // 
            this.lb_supplier.AutoSize = true;
            this.lb_supplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplier.Location = new System.Drawing.Point(80, 58);
            this.lb_supplier.Name = "lb_supplier";
            this.lb_supplier.Size = new System.Drawing.Size(115, 19);
            this.lb_supplier.TabIndex = 147;
            this.lb_supplier.Text = "Tên nhà cung cấp";
            // 
            // lb_address
            // 
            this.lb_address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(80, 134);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(405, 38);
            this.lb_address.TabIndex = 149;
            this.lb_address.Text = "Địa chỉ";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(80, 92);
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
            this.cbb_taxcode.Size = new System.Drawing.Size(172, 27);
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
            this.label4.Location = new System.Drawing.Point(5, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 132;
            this.label4.Text = "Tên NCC:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 143;
            this.label10.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 134;
            this.label5.Text = "SĐT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 28);
            this.label11.TabIndex = 156;
            this.label11.Text = "Nhập kho";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(633, 168);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 30);
            this.btn_cancel.TabIndex = 152;
            this.btn_cancel.Text = "Huỷ";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(638, 30);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 155;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(633, 88);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(80, 30);
            this.btn_add.TabIndex = 154;
            this.btn_add.Text = "Thêm mới";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(633, 128);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 30);
            this.btn_save.TabIndex = 153;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToResizeColumns = false;
            this.dgv_data.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Format = "N0";
            this.dgv_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.name,
            this.matax,
            this.price,
            this.quantity,
            this.sumprice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            this.dgv_data.Location = new System.Drawing.Point(25, 337);
            this.dgv_data.Name = "dgv_data";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_data.RowHeadersVisible = false;
            this.dgv_data.Size = new System.Drawing.Size(700, 200);
            this.dgv_data.TabIndex = 159;
            this.dgv_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_CellClick);
            this.dgv_data.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_CellValueChanged);
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
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.name.Width = 190;
            // 
            // matax
            // 
            this.matax.DataPropertyName = "unit";
            this.matax.HeaderText = "Đơn vị tính";
            this.matax.Name = "matax";
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            dataGridViewCellStyle3.Format = "N0";
            this.price.DefaultCellStyle = dataGridViewCellStyle3;
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Số lượng";
            this.quantity.Name = "quantity";
            // 
            // sumprice
            // 
            dataGridViewCellStyle4.Format = "N0";
            this.sumprice.DefaultCellStyle = dataGridViewCellStyle4;
            this.sumprice.HeaderText = "Giá trị đơn hàng";
            this.sumprice.Name = "sumprice";
            this.sumprice.Width = 130;
            // 
            // Form_InputProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 560);
            this.Controls.Add(this.panel_show);
            this.Controls.Add(this.panel_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_InputProduct";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form_InputProduct_Load);
            this.panel_list.ResumeLayout(false);
            this.panel_list.PerformLayout();
            this.panel_add.ResumeLayout(false);
            this.panel_add.PerformLayout();
            this.grb_supplier.ResumeLayout(false);
            this.grb_supplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.Panel panel_list;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewComboBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn matax;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumprice;
        private System.Windows.Forms.Panel panel_add;
        private System.Windows.Forms.Label lb_IdInput;
        private System.Windows.Forms.ComboBox cbb_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_addproduct;
    }
}