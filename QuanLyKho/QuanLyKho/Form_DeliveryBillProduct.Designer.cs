namespace QuanLyKho
{
    partial class Form_DeliveryBillProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_add = new System.Windows.Forms.Panel();
            this.cbb_user = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_IdDelivery = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.grb_customer = new System.Windows.Forms.GroupBox();
            this.lb_custaxcode = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lb_cusleganame = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lb_cusmail = new System.Windows.Forms.Label();
            this.lb_cusnote = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_cusname = new System.Windows.Forms.Label();
            this.lb_cusaddress = new System.Windows.Forms.Label();
            this.lb_cusphone = new System.Windows.Forms.Label();
            this.cbb_cusId = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.matax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_supplier = new System.Windows.Forms.GroupBox();
            this.lb_supplier = new System.Windows.Forms.Label();
            this.cbb_taxcode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_add.SuspendLayout();
            this.grb_customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.grb_supplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã phiếu xuất:";
            // 
            // panel_add
            // 
            this.panel_add.Controls.Add(this.cbb_user);
            this.panel_add.Controls.Add(this.label2);
            this.panel_add.Controls.Add(this.lb_IdDelivery);
            this.panel_add.Controls.Add(this.dateTimePicker1);
            this.panel_add.Controls.Add(this.label1);
            this.panel_add.Location = new System.Drawing.Point(25, 293);
            this.panel_add.Name = "panel_add";
            this.panel_add.Size = new System.Drawing.Size(602, 38);
            this.panel_add.TabIndex = 157;
            // 
            // cbb_user
            // 
            this.cbb_user.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_user.FormattingEnabled = true;
            this.cbb_user.Location = new System.Drawing.Point(330, 6);
            this.cbb_user.Name = "cbb_user";
            this.cbb_user.Size = new System.Drawing.Size(137, 27);
            this.cbb_user.TabIndex = 160;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 159;
            this.label2.Text = "Người lập:";
            // 
            // lb_IdDelivery
            // 
            this.lb_IdDelivery.AutoSize = true;
            this.lb_IdDelivery.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdDelivery.Location = new System.Drawing.Point(129, 9);
            this.lb_IdDelivery.Name = "lb_IdDelivery";
            this.lb_IdDelivery.Size = new System.Drawing.Size(95, 19);
            this.lb_IdDelivery.TabIndex = 158;
            this.lb_IdDelivery.Text = "Mã phiếu xuất";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(271, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(0, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(633, 78);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(80, 30);
            this.btn_add.TabIndex = 153;
            this.btn_add.Text = "Thêm mới";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(633, 120);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 30);
            this.btn_save.TabIndex = 152;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(633, 162);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 30);
            this.btn_cancel.TabIndex = 151;
            this.btn_cancel.Text = "Huỷ";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 28);
            this.label11.TabIndex = 155;
            this.label11.Text = "Xuất kho";
            // 
            // grb_customer
            // 
            this.grb_customer.Controls.Add(this.lb_custaxcode);
            this.grb_customer.Controls.Add(this.label21);
            this.grb_customer.Controls.Add(this.lb_cusleganame);
            this.grb_customer.Controls.Add(this.label20);
            this.grb_customer.Controls.Add(this.lb_cusmail);
            this.grb_customer.Controls.Add(this.lb_cusnote);
            this.grb_customer.Controls.Add(this.label7);
            this.grb_customer.Controls.Add(this.label8);
            this.grb_customer.Controls.Add(this.lb_cusname);
            this.grb_customer.Controls.Add(this.lb_cusaddress);
            this.grb_customer.Controls.Add(this.lb_cusphone);
            this.grb_customer.Controls.Add(this.cbb_cusId);
            this.grb_customer.Controls.Add(this.label16);
            this.grb_customer.Controls.Add(this.label17);
            this.grb_customer.Controls.Add(this.label18);
            this.grb_customer.Controls.Add(this.label19);
            this.grb_customer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_customer.Location = new System.Drawing.Point(25, 56);
            this.grb_customer.Name = "grb_customer";
            this.grb_customer.Size = new System.Drawing.Size(602, 159);
            this.grb_customer.TabIndex = 159;
            this.grb_customer.TabStop = false;
            this.grb_customer.Text = "Khách hàng";
            // 
            // lb_custaxcode
            // 
            this.lb_custaxcode.AutoSize = true;
            this.lb_custaxcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_custaxcode.Location = new System.Drawing.Point(82, 95);
            this.lb_custaxcode.Name = "lb_custaxcode";
            this.lb_custaxcode.Size = new System.Drawing.Size(52, 19);
            this.lb_custaxcode.TabIndex = 157;
            this.lb_custaxcode.Text = "Mã tax";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(17, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 19);
            this.label21.TabIndex = 156;
            this.label21.Text = "Mã Tax:";
            // 
            // lb_cusleganame
            // 
            this.lb_cusleganame.AutoSize = true;
            this.lb_cusleganame.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cusleganame.Location = new System.Drawing.Point(271, 28);
            this.lb_cusleganame.Name = "lb_cusleganame";
            this.lb_cusleganame.Size = new System.Drawing.Size(80, 19);
            this.lb_cusleganame.TabIndex = 155;
            this.lb_cusleganame.Text = "Tên pháp lý";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(208, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 19);
            this.label20.TabIndex = 154;
            this.label20.Text = "Tên PL:";
            // 
            // lb_cusmail
            // 
            this.lb_cusmail.AutoSize = true;
            this.lb_cusmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cusmail.Location = new System.Drawing.Point(431, 28);
            this.lb_cusmail.Name = "lb_cusmail";
            this.lb_cusmail.Size = new System.Drawing.Size(36, 19);
            this.lb_cusmail.TabIndex = 152;
            this.lb_cusmail.Text = "Mail";
            // 
            // lb_cusnote
            // 
            this.lb_cusnote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cusnote.Location = new System.Drawing.Point(278, 64);
            this.lb_cusnote.Name = "lb_cusnote";
            this.lb_cusnote.Size = new System.Drawing.Size(224, 38);
            this.lb_cusnote.TabIndex = 153;
            this.lb_cusnote.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 150;
            this.label7.Text = "Mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(207, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 151;
            this.label8.Text = "Ghi chú:";
            // 
            // lb_cusname
            // 
            this.lb_cusname.AutoSize = true;
            this.lb_cusname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cusname.Location = new System.Drawing.Point(82, 64);
            this.lb_cusname.Name = "lb_cusname";
            this.lb_cusname.Size = new System.Drawing.Size(104, 19);
            this.lb_cusname.TabIndex = 147;
            this.lb_cusname.Text = "Tên khách hàng";
            // 
            // lb_cusaddress
            // 
            this.lb_cusaddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cusaddress.Location = new System.Drawing.Point(278, 113);
            this.lb_cusaddress.Name = "lb_cusaddress";
            this.lb_cusaddress.Size = new System.Drawing.Size(224, 38);
            this.lb_cusaddress.TabIndex = 149;
            this.lb_cusaddress.Text = "Địa chỉ";
            // 
            // lb_cusphone
            // 
            this.lb_cusphone.AutoSize = true;
            this.lb_cusphone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cusphone.Location = new System.Drawing.Point(82, 126);
            this.lb_cusphone.Name = "lb_cusphone";
            this.lb_cusphone.Size = new System.Drawing.Size(88, 19);
            this.lb_cusphone.TabIndex = 148;
            this.lb_cusphone.Text = "Số điện thoại";
            // 
            // cbb_cusId
            // 
            this.cbb_cusId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_cusId.FormattingEnabled = true;
            this.cbb_cusId.Location = new System.Drawing.Point(82, 25);
            this.cbb_cusId.Name = "cbb_cusId";
            this.cbb_cusId.Size = new System.Drawing.Size(120, 27);
            this.cbb_cusId.TabIndex = 146;
            this.cbb_cusId.SelectedIndexChanged += new System.EventHandler(this.cbb_cusId_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 19);
            this.label16.TabIndex = 131;
            this.label16.Text = "Mã KH:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 19);
            this.label17.TabIndex = 132;
            this.label17.Text = "Tên KH:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(208, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 19);
            this.label18.TabIndex = 143;
            this.label18.Text = "Địa chỉ:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(17, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 19);
            this.label19.TabIndex = 134;
            this.label19.Text = "SĐT:";
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToResizeColumns = false;
            this.dgv_data.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Format = "N0";
            this.dgv_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.inventory,
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
            this.dgv_data.RowHeadersVisible = false;
            this.dgv_data.Size = new System.Drawing.Size(700, 200);
            this.dgv_data.TabIndex = 160;
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
            this.name.Width = 150;
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
            // inventory
            // 
            this.inventory.DataPropertyName = "Inventory";
            this.inventory.HeaderText = "Tồn";
            this.inventory.Name = "inventory";
            this.inventory.Width = 50;
            // 
            // sumprice
            // 
            dataGridViewCellStyle4.Format = "N0";
            this.sumprice.DefaultCellStyle = dataGridViewCellStyle4;
            this.sumprice.HeaderText = "Giá trị đơn hàng";
            this.sumprice.Name = "sumprice";
            this.sumprice.Width = 130;
            // 
            // grb_supplier
            // 
            this.grb_supplier.Controls.Add(this.lb_supplier);
            this.grb_supplier.Controls.Add(this.cbb_taxcode);
            this.grb_supplier.Controls.Add(this.label3);
            this.grb_supplier.Controls.Add(this.label4);
            this.grb_supplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_supplier.Location = new System.Drawing.Point(25, 221);
            this.grb_supplier.Name = "grb_supplier";
            this.grb_supplier.Size = new System.Drawing.Size(602, 60);
            this.grb_supplier.TabIndex = 161;
            this.grb_supplier.TabStop = false;
            this.grb_supplier.Text = "Nhà cung cấp";
            // 
            // lb_supplier
            // 
            this.lb_supplier.AutoSize = true;
            this.lb_supplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplier.Location = new System.Drawing.Point(278, 22);
            this.lb_supplier.Name = "lb_supplier";
            this.lb_supplier.Size = new System.Drawing.Size(115, 19);
            this.lb_supplier.TabIndex = 147;
            this.lb_supplier.Text = "Tên nhà cung cấp";
            // 
            // cbb_taxcode
            // 
            this.cbb_taxcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_taxcode.FormattingEnabled = true;
            this.cbb_taxcode.Location = new System.Drawing.Point(79, 19);
            this.cbb_taxcode.Name = "cbb_taxcode";
            this.cbb_taxcode.Size = new System.Drawing.Size(120, 27);
            this.cbb_taxcode.TabIndex = 146;
            this.cbb_taxcode.SelectedIndexChanged += new System.EventHandler(this.cbb_taxcode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 131;
            this.label3.Text = "Mã Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 132;
            this.label4.Text = "Tên NCC:";
            // 
            // Form_DeliveryBillProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 560);
            this.Controls.Add(this.grb_supplier);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.grb_customer);
            this.Controls.Add(this.panel_add);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_DeliveryBillProduct";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form_DeliveryBillProduct_Load);
            this.panel_add.ResumeLayout(false);
            this.panel_add.PerformLayout();
            this.grb_customer.ResumeLayout(false);
            this.grb_customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.grb_supplier.ResumeLayout(false);
            this.grb_supplier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_add;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grb_customer;
        private System.Windows.Forms.Label lb_cusmail;
        private System.Windows.Forms.Label lb_cusnote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_cusname;
        private System.Windows.Forms.Label lb_cusaddress;
        private System.Windows.Forms.Label lb_cusphone;
        private System.Windows.Forms.ComboBox cbb_cusId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lb_custaxcode;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lb_cusleganame;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Label lb_IdDelivery;
        private System.Windows.Forms.ComboBox cbb_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewComboBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn matax;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumprice;
        private System.Windows.Forms.GroupBox grb_supplier;
        private System.Windows.Forms.Label lb_supplier;
        private System.Windows.Forms.ComboBox cbb_taxcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}