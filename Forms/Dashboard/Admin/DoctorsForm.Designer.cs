﻿namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    partial class DoctorsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.crudPanel = new System.Windows.Forms.Panel();
            this.Specialization_combobox = new System.Windows.Forms.ComboBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_doc_btn = new System.Windows.Forms.Button();
            this.add_doc_btn = new System.Windows.Forms.Button();
            this.location_input = new System.Windows.Forms.ComboBox();
            this.Specialization_label = new System.Windows.Forms.Label();
            this.qualification_input = new System.Windows.Forms.ComboBox();
            this.qualification_label = new System.Windows.Forms.Label();
            this.last_name_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.hospital_address_input = new System.Windows.Forms.TextBox();
            this.home_address_input = new System.Windows.Forms.TextBox();
            this.phone_no_input = new System.Windows.Forms.TextBox();
            this.email_input = new System.Windows.Forms.TextBox();
            this.first_name_input = new System.Windows.Forms.TextBox();
            this.last_name_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.hospital_address_label = new System.Windows.Forms.Label();
            this.location_label = new System.Windows.Forms.Label();
            this.home_address_label = new System.Windows.Forms.Label();
            this.phone_no_label = new System.Windows.Forms.Label();
            this.email_address_label = new System.Windows.Forms.Label();
            this.first_name_label = new System.Windows.Forms.Label();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.doctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.crudPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // crudPanel
            // 
            this.crudPanel.Controls.Add(this.Specialization_combobox);
            this.crudPanel.Controls.Add(this.reset_btn);
            this.crudPanel.Controls.Add(this.delete_btn);
            this.crudPanel.Controls.Add(this.update_doc_btn);
            this.crudPanel.Controls.Add(this.add_doc_btn);
            this.crudPanel.Controls.Add(this.location_input);
            this.crudPanel.Controls.Add(this.Specialization_label);
            this.crudPanel.Controls.Add(this.qualification_input);
            this.crudPanel.Controls.Add(this.qualification_label);
            this.crudPanel.Controls.Add(this.last_name_input);
            this.crudPanel.Controls.Add(this.password_input);
            this.crudPanel.Controls.Add(this.hospital_address_input);
            this.crudPanel.Controls.Add(this.home_address_input);
            this.crudPanel.Controls.Add(this.phone_no_input);
            this.crudPanel.Controls.Add(this.email_input);
            this.crudPanel.Controls.Add(this.first_name_input);
            this.crudPanel.Controls.Add(this.last_name_label);
            this.crudPanel.Controls.Add(this.password_label);
            this.crudPanel.Controls.Add(this.hospital_address_label);
            this.crudPanel.Controls.Add(this.location_label);
            this.crudPanel.Controls.Add(this.home_address_label);
            this.crudPanel.Controls.Add(this.phone_no_label);
            this.crudPanel.Controls.Add(this.email_address_label);
            this.crudPanel.Controls.Add(this.first_name_label);
            this.crudPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudPanel.Location = new System.Drawing.Point(0, 0);
            this.crudPanel.Name = "crudPanel";
            this.crudPanel.Size = new System.Drawing.Size(800, 260);
            this.crudPanel.TabIndex = 0;
            // 
            // Specialization_combobox
            // 
            this.Specialization_combobox.BackColor = System.Drawing.Color.White;
            this.Specialization_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Specialization_combobox.FormattingEnabled = true;
            this.Specialization_combobox.Items.AddRange(new object[] {
            "Neurology",
            "Urology",
            "Family Medicine",
            "Psychiatry",
            "Dermatology",
            "Orthopedics",
            "Cardiology",
            "Gastroenterology",
            "Neurosurgery"});
            this.Specialization_combobox.Location = new System.Drawing.Point(271, 207);
            this.Specialization_combobox.Name = "Specialization_combobox";
            this.Specialization_combobox.Size = new System.Drawing.Size(143, 21);
            this.Specialization_combobox.TabIndex = 19;
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_btn.FlatAppearance.BorderSize = 0;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reset_btn.Location = new System.Drawing.Point(669, 184);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(119, 38);
            this.reset_btn.TabIndex = 27;
            this.reset_btn.Text = "Сброс";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.Reset_btn_ClickHandler);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(90)))));
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(530, 184);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(119, 38);
            this.delete_btn.TabIndex = 26;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // update_doc_btn
            // 
            this.update_doc_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(81)))));
            this.update_doc_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_doc_btn.FlatAppearance.BorderSize = 0;
            this.update_doc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_doc_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_doc_btn.Location = new System.Drawing.Point(669, 130);
            this.update_doc_btn.Name = "update_doc_btn";
            this.update_doc_btn.Size = new System.Drawing.Size(119, 48);
            this.update_doc_btn.TabIndex = 25;
            this.update_doc_btn.Text = "Обнавить данные";
            this.update_doc_btn.UseVisualStyleBackColor = false;
            this.update_doc_btn.Click += new System.EventHandler(this.Update_doc_btn_Click);
            // 
            // add_doc_btn
            // 
            this.add_doc_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.add_doc_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_doc_btn.FlatAppearance.BorderSize = 0;
            this.add_doc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_doc_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_doc_btn.Location = new System.Drawing.Point(530, 130);
            this.add_doc_btn.Name = "add_doc_btn";
            this.add_doc_btn.Size = new System.Drawing.Size(119, 48);
            this.add_doc_btn.TabIndex = 24;
            this.add_doc_btn.Text = "Добавить доктора";
            this.add_doc_btn.UseVisualStyleBackColor = false;
            this.add_doc_btn.Click += new System.EventHandler(this.Add_doc_btn_Click);
            // 
            // location_input
            // 
            this.location_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_input.FormattingEnabled = true;
            this.location_input.Items.AddRange(new object[] {
            "Kandy",
            "Colombo"});
            this.location_input.Location = new System.Drawing.Point(530, 90);
            this.location_input.Name = "location_input";
            this.location_input.Size = new System.Drawing.Size(152, 21);
            this.location_input.TabIndex = 23;
            // 
            // Specialization_label
            // 
            this.Specialization_label.AutoSize = true;
            this.Specialization_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Specialization_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specialization_label.Location = new System.Drawing.Point(267, 184);
            this.Specialization_label.Name = "Specialization_label";
            this.Specialization_label.Size = new System.Drawing.Size(112, 17);
            this.Specialization_label.TabIndex = 21;
            this.Specialization_label.Text = "Специализация";
            this.Specialization_label.UseMnemonic = false;
            // 
            // qualification_input
            // 
            this.qualification_input.BackColor = System.Drawing.Color.White;
            this.qualification_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualification_input.FormattingEnabled = true;
            this.qualification_input.Items.AddRange(new object[] {
            "SRN",
            "BM",
            "BS",
            "ChB",
            "BMedSci",
            "DFSRH",
            "MSc",
            "MBChB"});
            this.qualification_input.Location = new System.Drawing.Point(530, 33);
            this.qualification_input.Name = "qualification_input";
            this.qualification_input.Size = new System.Drawing.Size(143, 21);
            this.qualification_input.TabIndex = 20;
            // 
            // qualification_label
            // 
            this.qualification_label.AutoSize = true;
            this.qualification_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.qualification_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualification_label.Location = new System.Drawing.Point(526, 9);
            this.qualification_label.Name = "qualification_label";
            this.qualification_label.Size = new System.Drawing.Size(106, 17);
            this.qualification_label.TabIndex = 19;
            this.qualification_label.Text = "Квалификация";
            // 
            // last_name_input
            // 
            this.last_name_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.last_name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name_input.Location = new System.Drawing.Point(271, 32);
            this.last_name_input.MaxLength = 300;
            this.last_name_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.last_name_input.Name = "last_name_input";
            this.last_name_input.Size = new System.Drawing.Size(222, 20);
            this.last_name_input.TabIndex = 14;
            // 
            // password_input
            // 
            this.password_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_input.Location = new System.Drawing.Point(271, 90);
            this.password_input.MaxLength = 300;
            this.password_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(222, 20);
            this.password_input.TabIndex = 16;
            // 
            // hospital_address_input
            // 
            this.hospital_address_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hospital_address_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospital_address_input.Location = new System.Drawing.Point(16, 207);
            this.hospital_address_input.MaxLength = 300;
            this.hospital_address_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.hospital_address_input.Name = "hospital_address_input";
            this.hospital_address_input.Size = new System.Drawing.Size(222, 20);
            this.hospital_address_input.TabIndex = 18;
            // 
            // home_address_input
            // 
            this.home_address_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.home_address_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_address_input.Location = new System.Drawing.Point(271, 147);
            this.home_address_input.MaxLength = 300;
            this.home_address_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.home_address_input.Name = "home_address_input";
            this.home_address_input.Size = new System.Drawing.Size(222, 20);
            this.home_address_input.TabIndex = 18;
            // 
            // phone_no_input
            // 
            this.phone_no_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_no_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_no_input.Location = new System.Drawing.Point(16, 147);
            this.phone_no_input.MaxLength = 300;
            this.phone_no_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.phone_no_input.Name = "phone_no_input";
            this.phone_no_input.Size = new System.Drawing.Size(222, 20);
            this.phone_no_input.TabIndex = 17;
            // 
            // email_input
            // 
            this.email_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_input.Location = new System.Drawing.Point(16, 90);
            this.email_input.MaxLength = 300;
            this.email_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(222, 20);
            this.email_input.TabIndex = 15;
            // 
            // first_name_input
            // 
            this.first_name_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.first_name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name_input.Location = new System.Drawing.Point(16, 32);
            this.first_name_input.MaxLength = 300;
            this.first_name_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.first_name_input.Name = "first_name_input";
            this.first_name_input.Size = new System.Drawing.Size(222, 20);
            this.first_name_input.TabIndex = 13;
            // 
            // last_name_label
            // 
            this.last_name_label.AutoSize = true;
            this.last_name_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.last_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name_label.Location = new System.Drawing.Point(267, 9);
            this.last_name_label.Name = "last_name_label";
            this.last_name_label.Size = new System.Drawing.Size(35, 17);
            this.last_name_label.TabIndex = 7;
            this.last_name_label.Text = "Имя";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(267, 67);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(57, 17);
            this.password_label.TabIndex = 8;
            this.password_label.Text = "Пароль";
            // 
            // hospital_address_label
            // 
            this.hospital_address_label.AutoSize = true;
            this.hospital_address_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.hospital_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospital_address_label.Location = new System.Drawing.Point(12, 184);
            this.hospital_address_label.Name = "hospital_address_label";
            this.hospital_address_label.Size = new System.Drawing.Size(117, 17);
            this.hospital_address_label.TabIndex = 9;
            this.hospital_address_label.Text = "Адрес больницы";
            // 
            // location_label
            // 
            this.location_label.AutoSize = true;
            this.location_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.location_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_label.Location = new System.Drawing.Point(526, 67);
            this.location_label.Name = "location_label";
            this.location_label.Size = new System.Drawing.Size(60, 17);
            this.location_label.TabIndex = 9;
            this.location_label.Text = "Где он?";
            // 
            // home_address_label
            // 
            this.home_address_label.AutoSize = true;
            this.home_address_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.home_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_address_label.Location = new System.Drawing.Point(267, 124);
            this.home_address_label.Name = "home_address_label";
            this.home_address_label.Size = new System.Drawing.Size(132, 17);
            this.home_address_label.TabIndex = 9;
            this.home_address_label.Text = "Адрес проживания";
            // 
            // phone_no_label
            // 
            this.phone_no_label.AutoSize = true;
            this.phone_no_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.phone_no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_no_label.Location = new System.Drawing.Point(12, 124);
            this.phone_no_label.Name = "phone_no_label";
            this.phone_no_label.Size = new System.Drawing.Size(121, 17);
            this.phone_no_label.TabIndex = 10;
            this.phone_no_label.Text = "Номер телефона";
            // 
            // email_address_label
            // 
            this.email_address_label.AutoSize = true;
            this.email_address_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.email_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_address_label.Location = new System.Drawing.Point(12, 67);
            this.email_address_label.Name = "email_address_label";
            this.email_address_label.Size = new System.Drawing.Size(182, 17);
            this.email_address_label.TabIndex = 11;
            this.email_address_label.Text = "Адрес электронной почты";
            // 
            // first_name_label
            // 
            this.first_name_label.AutoSize = true;
            this.first_name_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.first_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name_label.Location = new System.Drawing.Point(12, 9);
            this.first_name_label.Name = "first_name_label";
            this.first_name_label.Size = new System.Drawing.Size(70, 17);
            this.first_name_label.TabIndex = 12;
            this.first_name_label.Text = "Фамилия";
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.doctorsDataGridView);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(0, 260);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(800, 190);
            this.dataPanel.TabIndex = 1;
            // 
            // doctorsDataGridView
            // 
            this.doctorsDataGridView.AllowUserToAddRows = false;
            this.doctorsDataGridView.AllowUserToDeleteRows = false;
            this.doctorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctorsDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.doctorsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.doctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorsDataGridView.EnableHeadersVisualStyles = false;
            this.doctorsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.doctorsDataGridView.MultiSelect = false;
            this.doctorsDataGridView.Name = "doctorsDataGridView";
            this.doctorsDataGridView.ReadOnly = true;
            this.doctorsDataGridView.Size = new System.Drawing.Size(800, 190);
            this.doctorsDataGridView.TabIndex = 0;
            this.doctorsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellDoubleClick);
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.crudPanel);
            this.Name = "DoctorsForm";
            this.Text = "Доктора";
            this.Load += new System.EventHandler(this.DoctorsForm_Load);
            this.crudPanel.ResumeLayout(false);
            this.crudPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel crudPanel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.TextBox last_name_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.TextBox home_address_input;
        private System.Windows.Forms.TextBox phone_no_input;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.TextBox first_name_input;
        private System.Windows.Forms.Label last_name_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label home_address_label;
        private System.Windows.Forms.Label phone_no_label;
        private System.Windows.Forms.Label email_address_label;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.ComboBox qualification_input;
        private System.Windows.Forms.Label qualification_label;
        private System.Windows.Forms.Label Specialization_label;
        private System.Windows.Forms.TextBox hospital_address_input;
        private System.Windows.Forms.Label hospital_address_label;
        private System.Windows.Forms.ComboBox location_input;
        private System.Windows.Forms.Label location_label;
        private System.Windows.Forms.Button update_doc_btn;
        private System.Windows.Forms.Button add_doc_btn;
        private System.Windows.Forms.DataGridView doctorsDataGridView;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ComboBox Specialization_combobox;
    }
}