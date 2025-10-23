namespace MapsManagerApp.Forms
{
    partial class MapsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.change_size_button = new System.Windows.Forms.Button();
            this.disable_update_button = new System.Windows.Forms.Button();
            this.confirm_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.maps_list = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.map_search_text = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ringBinder_cb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.info_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clear_search_button = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.maps_list)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // change_size_button
            // 
            this.change_size_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.change_size_button.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.change_size_button.Location = new System.Drawing.Point(259, 365);
            this.change_size_button.Name = "change_size_button";
            this.change_size_button.Size = new System.Drawing.Size(44, 27);
            this.change_size_button.TabIndex = 9;
            this.change_size_button.Text = ">>";
            this.change_size_button.UseVisualStyleBackColor = false;
            this.change_size_button.Click += new System.EventHandler(this.change_size_button_ClickAsync);
            // 
            // disable_update_button
            // 
            this.disable_update_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.disable_update_button.Enabled = false;
            this.disable_update_button.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.disable_update_button.Location = new System.Drawing.Point(127, 288);
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
            this.confirm_button.Location = new System.Drawing.Point(26, 240);
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
            this.label5.Location = new System.Drawing.Point(202, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "زومکن:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام:";
            // 
            // name_text
            // 
            this.name_text.Font = new System.Drawing.Font("Tahoma", 14F);
            this.name_text.Location = new System.Drawing.Point(26, 45);
            this.name_text.MaxLength = 50;
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(171, 30);
            this.name_text.TabIndex = 0;
            // 
            // maps_list
            // 
            this.maps_list.AllowUserToAddRows = false;
            this.maps_list.AllowUserToDeleteRows = false;
            this.maps_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maps_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.maps_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maps_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.maps_list.DefaultCellStyle = dataGridViewCellStyle6;
            this.maps_list.Location = new System.Drawing.Point(20, 89);
            this.maps_list.MultiSelect = false;
            this.maps_list.Name = "maps_list";
            this.maps_list.ReadOnly = true;
            this.maps_list.RowHeadersVisible = false;
            this.maps_list.Size = new System.Drawing.Size(808, 252);
            this.maps_list.TabIndex = 7;
            this.maps_list.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.maps_list_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(769, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "جستجو:";
            // 
            // map_search_text
            // 
            this.map_search_text.Font = new System.Drawing.Font("Tahoma", 14F);
            this.map_search_text.Location = new System.Drawing.Point(556, 35);
            this.map_search_text.MaxLength = 50;
            this.map_search_text.Name = "map_search_text";
            this.map_search_text.Size = new System.Drawing.Size(207, 30);
            this.map_search_text.TabIndex = 0;
            this.map_search_text.TextChanged += new System.EventHandler(this.map_search_text_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.info_text);
            this.groupBox2.Controls.Add(this.ringBinder_cb);
            this.groupBox2.Controls.Add(this.disable_update_button);
            this.groupBox2.Controls.Add(this.confirm_button);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.name_text);
            this.groupBox2.Location = new System.Drawing.Point(27, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(276, 333);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "افزودن نقشه";
            // 
            // ringBinder_cb
            // 
            this.ringBinder_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ringBinder_cb.FormattingEnabled = true;
            this.ringBinder_cb.Location = new System.Drawing.Point(26, 83);
            this.ringBinder_cb.Name = "ringBinder_cb";
            this.ringBinder_cb.Size = new System.Drawing.Size(171, 36);
            this.ringBinder_cb.TabIndex = 3;
            this.ringBinder_cb.SelectedIndexChanged += new System.EventHandler(this.ringBinder_cb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear_search_button);
            this.groupBox1.Controls.Add(this.maps_list);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.map_search_text);
            this.groupBox1.Location = new System.Drawing.Point(326, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(841, 366);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست نقشه ها";
            // 
            // info_text
            // 
            this.info_text.AccessibleDescription = "";
            this.info_text.Location = new System.Drawing.Point(26, 125);
            this.info_text.MaxLength = 50;
            this.info_text.Multiline = true;
            this.info_text.Name = "info_text";
            this.info_text.ReadOnly = true;
            this.info_text.Size = new System.Drawing.Size(171, 109);
            this.info_text.TabIndex = 4;
            this.info_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 56);
            this.label3.TabIndex = 1;
            this.label3.Text = "اطلاعات\r\n تکمیلی:";
            // 
            // clear_search_button
            // 
            this.clear_search_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clear_search_button.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.clear_search_button.Location = new System.Drawing.Point(518, 34);
            this.clear_search_button.Name = "clear_search_button";
            this.clear_search_button.Size = new System.Drawing.Size(32, 33);
            this.clear_search_button.TabIndex = 9;
            this.clear_search_button.Text = "c";
            this.clear_search_button.UseVisualStyleBackColor = false;
            this.clear_search_button.Click += new System.EventHandler(this.clear_search_button_Click);
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
            this.Column2.HeaderText = "نام نقشه";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DepartmentName";
            this.Column5.HeaderText = "نام دپارتمان";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "RingBinderName";
            this.Column6.HeaderText = "نام زونکن";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
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
            // MapsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 404);
            this.Controls.Add(this.change_size_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MapsForm";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم مدیریت نقشه ها";
            this.Load += new System.EventHandler(this.MapsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maps_list)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button change_size_button;
        private System.Windows.Forms.Button disable_update_button;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.DataGridView maps_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox map_search_text;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ringBinder_cb;
        private System.Windows.Forms.TextBox info_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear_search_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}