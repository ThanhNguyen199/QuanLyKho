﻿namespace QuanLyKho
{
    partial class Form_SupplierInfor
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
            this.label11 = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_taxcode = new System.Windows.Forms.TextBox();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_unlock = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_lock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(212, 28);
            this.label11.TabIndex = 53;
            this.label11.Text = "Nhóm nhà cung cấp";
            // 
            // btn_change
            // 
            this.btn_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change.BackColor = System.Drawing.Color.Transparent;
            this.btn_change.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_change.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.Location = new System.Drawing.Point(143, 286);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(86, 30);
            this.btn_change.TabIndex = 8;
            this.btn_change.Text = "Chỉnh sửa";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(165, 202);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(447, 26);
            this.txt_address.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 49;
            this.label10.Text = "Địa chỉ:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(394, 160);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(218, 26);
            this.txt_email.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(343, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 47;
            this.label9.Text = "Email:";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(165, 160);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(172, 26);
            this.txt_phone.TabIndex = 3;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(116, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "SĐT:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(165, 120);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(447, 26);
            this.txt_name.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tên NCC:";
            // 
            // txt_note
            // 
            this.txt_note.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_note.Location = new System.Drawing.Point(165, 243);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(447, 26);
            this.txt_note.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Ghi chú:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mã Tax:";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(51, 286);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 30);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Thêm mới";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(236, 286);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 30);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_taxcode
            // 
            this.txt_taxcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taxcode.Location = new System.Drawing.Point(165, 79);
            this.txt_taxcode.Name = "txt_taxcode";
            this.txt_taxcode.Size = new System.Drawing.Size(266, 26);
            this.txt_taxcode.TabIndex = 1;
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToDeleteRows = false;
            this.dgv_data.AllowUserToResizeColumns = false;
            this.dgv_data.AllowUserToResizeRows = false;
            this.dgv_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_data.BackgroundColor = System.Drawing.Color.White;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.matax,
            this.name,
            this.sdt,
            this.email,
            this.diachi,
            this.note});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            this.dgv_data.Location = new System.Drawing.Point(25, 337);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data.RowHeadersVisible = false;
            this.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data.Size = new System.Drawing.Size(700, 200);
            this.dgv_data.TabIndex = 31;
            this.dgv_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_CellClick);
            this.dgv_data.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_data_RowsAdded);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 40;
            // 
            // matax
            // 
            this.matax.DataPropertyName = "TaxCode";
            this.matax.HeaderText = "Mã Tax";
            this.matax.Name = "matax";
            this.matax.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "DisplayName";
            this.name.HeaderText = "Tên Ncc";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 156;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "Phone";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "Address";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // note
            // 
            this.note.DataPropertyName = "MoreInfo";
            this.note.HeaderText = "Ghi chú";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(332, 286);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(86, 30);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Huỷ";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_unlock
            // 
            this.btn_unlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_unlock.BackColor = System.Drawing.Color.Transparent;
            this.btn_unlock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_unlock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_unlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_unlock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unlock.Location = new System.Drawing.Point(608, 286);
            this.btn_unlock.Name = "btn_unlock";
            this.btn_unlock.Size = new System.Drawing.Size(86, 30);
            this.btn_unlock.TabIndex = 130;
            this.btn_unlock.Text = "Khôi phục";
            this.btn_unlock.UseVisualStyleBackColor = false;
            this.btn_unlock.Click += new System.EventHandler(this.btn_unlock_Click);
            // 
            // btn_list
            // 
            this.btn_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_list.BackColor = System.Drawing.Color.Transparent;
            this.btn_list.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_list.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_list.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_list.Location = new System.Drawing.Point(424, 286);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(86, 30);
            this.btn_list.TabIndex = 129;
            this.btn_list.Text = "DS đã xóa";
            this.btn_list.UseVisualStyleBackColor = false;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_lock
            // 
            this.btn_lock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lock.BackColor = System.Drawing.Color.Transparent;
            this.btn_lock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_lock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(107)))), ((int)(((byte)(217)))));
            this.btn_lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lock.Location = new System.Drawing.Point(516, 286);
            this.btn_lock.Name = "btn_lock";
            this.btn_lock.Size = new System.Drawing.Size(86, 30);
            this.btn_lock.TabIndex = 128;
            this.btn_lock.Text = "Xoá";
            this.btn_lock.UseVisualStyleBackColor = false;
            this.btn_lock.Click += new System.EventHandler(this.btn_lock_Click);
            // 
            // Form_SupplierInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 560);
            this.Controls.Add(this.btn_unlock);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.btn_lock);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_taxcode);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.btn_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SupplierInfor";
            this.Text = "Form_SupplierInfor";
            this.Load += new System.EventHandler(this.Form_SupplierInfor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_taxcode;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn matax;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.Button btn_unlock;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_lock;
    }
}