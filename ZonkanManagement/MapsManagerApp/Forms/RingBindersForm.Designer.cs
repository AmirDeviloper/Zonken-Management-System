namespace MapsManagerApp.Forms
{
    partial class RingBindersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ringBinder_list = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ringBinder_search_text = new System.Windows.Forms.TextBox();
            this.maps_form_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.row_number = new System.Windows.Forms.NumericUpDown();
            this.shelf_number = new System.Windows.Forms.NumericUpDown();
            this.department_cb = new System.Windows.Forms.ComboBox();
            this.disable_update_button = new System.Windows.Forms.Button();
            this.confirm_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.change_size_button = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clear_search_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ringBinder_list)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.row_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelf_number)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear_search_button);
            this.groupBox1.Controls.Add(this.ringBinder_list);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ringBinder_search_text);
            this.groupBox1.Location = new System.Drawing.Point(340, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(772, 308);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست زونکن ها";
            // 
            // ringBinder_list
            // 
            this.ringBinder_list.AllowUserToAddRows = false;
            this.ringBinder_list.AllowUserToDeleteRows = false;
            this.ringBinder_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ringBinder_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.ringBinder_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ringBinder_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ringBinder_list.DefaultCellStyle = dataGridViewCellStyle16;
            this.ringBinder_list.Location = new System.Drawing.Point(24, 77);
            this.ringBinder_list.MultiSelect = false;
            this.ringBinder_list.Name = "ringBinder_list";
            this.ringBinder_list.ReadOnly = true;
            this.ringBinder_list.RowHeadersVisible = false;
            this.ringBinder_list.Size = new System.Drawing.Size(723, 210);
            this.ringBinder_list.TabIndex = 7;
            this.ringBinder_list.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ringBinder_list_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(693, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "جستجو:";
            // 
            // ringBinder_search_text
            // 
            this.ringBinder_search_text.Font = new System.Drawing.Font("Tahoma", 14F);
            this.ringBinder_search_text.Location = new System.Drawing.Point(480, 35);
            this.ringBinder_search_text.MaxLength = 50;
            this.ringBinder_search_text.Name = "ringBinder_search_text";
            this.ringBinder_search_text.Size = new System.Drawing.Size(207, 30);
            this.ringBinder_search_text.TabIndex = 0;
            this.ringBinder_search_text.TextChanged += new System.EventHandler(this.ringBinder_search_text_TextChanged);
            // 
            // maps_form_button
            // 
            this.maps_form_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.maps_form_button.Location = new System.Drawing.Point(22, 354);
            this.maps_form_button.Name = "maps_form_button";
            this.maps_form_button.Size = new System.Drawing.Size(141, 42);
            this.maps_form_button.TabIndex = 6;
            this.maps_form_button.Text = "مدیریت نقشه ها";
            this.maps_form_button.UseVisualStyleBackColor = false;
            this.maps_form_button.Click += new System.EventHandler(this.maps_form_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.row_number);
            this.groupBox2.Controls.Add(this.shelf_number);
            this.groupBox2.Controls.Add(this.department_cb);
            this.groupBox2.Controls.Add(this.disable_update_button);
            this.groupBox2.Controls.Add(this.confirm_button);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.name_text);
            this.groupBox2.Location = new System.Drawing.Point(22, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(292, 308);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "افزودن زونکن";
            // 
            // row_number
            // 
            this.row_number.Location = new System.Drawing.Point(24, 136);
            this.row_number.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.row_number.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.row_number.Name = "row_number";
            this.row_number.Size = new System.Drawing.Size(171, 36);
            this.row_number.TabIndex = 4;
            this.row_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shelf_number
            // 
            this.shelf_number.Location = new System.Drawing.Point(24, 86);
            this.shelf_number.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.shelf_number.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.shelf_number.Name = "shelf_number";
            this.shelf_number.Size = new System.Drawing.Size(171, 36);
            this.shelf_number.TabIndex = 4;
            this.shelf_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // department_cb
            // 
            this.department_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department_cb.FormattingEnabled = true;
            this.department_cb.Location = new System.Drawing.Point(24, 187);
            this.department_cb.Name = "department_cb";
            this.department_cb.Size = new System.Drawing.Size(171, 36);
            this.department_cb.TabIndex = 3;
            // 
            // disable_update_button
            // 
            this.disable_update_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.disable_update_button.Enabled = false;
            this.disable_update_button.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.disable_update_button.Location = new System.Drawing.Point(160, 254);
            this.disable_update_button.Name = "disable_update_button";
            this.disable_update_button.Size = new System.Drawing.Size(123, 33);
            this.disable_update_button.TabIndex = 2;
            this.disable_update_button.Text = "صرف نظر از بروزرسانی";
            this.disable_update_button.UseVisualStyleBackColor = false;
            this.disable_update_button.Click += new System.EventHandler(this.disable_update_button_Click);
            // 
            // confirm_button
            // 
            this.confirm_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.confirm_button.Location = new System.Drawing.Point(24, 249);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(106, 42);
            this.confirm_button.TabIndex = 2;
            this.confirm_button.Text = "ثبت";
            this.confirm_button.UseVisualStyleBackColor = false;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "دپارتمان:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "شماره ردیف:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "شماره قفسه:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام:";
            // 
            // name_text
            // 
            this.name_text.Font = new System.Drawing.Font("Tahoma", 14F);
            this.name_text.Location = new System.Drawing.Point(24, 37);
            this.name_text.MaxLength = 50;
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(171, 30);
            this.name_text.TabIndex = 0;
            // 
            // change_size_button
            // 
            this.change_size_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.change_size_button.Location = new System.Drawing.Point(270, 354);
            this.change_size_button.Name = "change_size_button";
            this.change_size_button.Size = new System.Drawing.Size(44, 42);
            this.change_size_button.TabIndex = 6;
            this.change_size_button.Text = ">>";
            this.change_size_button.UseVisualStyleBackColor = false;
            this.change_size_button.Click += new System.EventHandler(this.change_size_button_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "شناسه";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "نام زونکن";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ShelfNumber";
            this.Column3.HeaderText = "شماره قفسه";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "RowNumber";
            this.Column4.HeaderText = "شماره ردیف";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DepartmentName";
            this.Column5.HeaderText = "نام دپارتمان";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // clear_search_button
            // 
            this.clear_search_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clear_search_button.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.clear_search_button.Location = new System.Drawing.Point(442, 34);
            this.clear_search_button.Name = "clear_search_button";
            this.clear_search_button.Size = new System.Drawing.Size(32, 33);
            this.clear_search_button.TabIndex = 8;
            this.clear_search_button.Text = "c";
            this.clear_search_button.UseVisualStyleBackColor = false;
            this.clear_search_button.Click += new System.EventHandler(this.clear_search_button_Click);
            // 
            // RingBindersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.change_size_button);
            this.Controls.Add(this.maps_form_button);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "RingBindersForm";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم مدیریت زوم کن ها";
            this.Load += new System.EventHandler(this.RingBindersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ringBinder_list)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.row_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelf_number)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ringBinder_search_text;
        private System.Windows.Forms.Button maps_form_button;
        private System.Windows.Forms.DataGridView ringBinder_list;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown row_number;
        private System.Windows.Forms.NumericUpDown shelf_number;
        private System.Windows.Forms.ComboBox department_cb;
        private System.Windows.Forms.Button disable_update_button;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Button change_size_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button clear_search_button;
    }
}