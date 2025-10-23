namespace MapsManagerApp
{
    partial class DepartmentsForm
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
            this.departments_info_gp = new System.Windows.Forms.GroupBox();
            this.info_maps_count_text = new System.Windows.Forms.TextBox();
            this.info_ringBinders_count_text = new System.Windows.Forms.TextBox();
            this.info_departments_count_text = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.disable_update_button = new System.Windows.Forms.Button();
            this.confirm_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptions_text = new System.Windows.Forms.TextBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departments_list = new System.Windows.Forms.ListBox();
            this.department_search_text = new System.Windows.Forms.TextBox();
            this.ringBinder_form_button = new System.Windows.Forms.Button();
            this.clear_search_button = new System.Windows.Forms.Button();
            this.departments_info_gp.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // departments_info_gp
            // 
            this.departments_info_gp.Controls.Add(this.info_maps_count_text);
            this.departments_info_gp.Controls.Add(this.info_ringBinders_count_text);
            this.departments_info_gp.Controls.Add(this.info_departments_count_text);
            this.departments_info_gp.Location = new System.Drawing.Point(373, 349);
            this.departments_info_gp.Name = "departments_info_gp";
            this.departments_info_gp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.departments_info_gp.Size = new System.Drawing.Size(343, 212);
            this.departments_info_gp.TabIndex = 1;
            this.departments_info_gp.TabStop = false;
            this.departments_info_gp.Text = "اطلاعات تکمیلی";
            // 
            // info_maps_count_text
            // 
            this.info_maps_count_text.AccessibleDescription = "تعداد نقشه های موجود:";
            this.info_maps_count_text.Location = new System.Drawing.Point(24, 157);
            this.info_maps_count_text.MaxLength = 50;
            this.info_maps_count_text.Name = "info_maps_count_text";
            this.info_maps_count_text.ReadOnly = true;
            this.info_maps_count_text.Size = new System.Drawing.Size(301, 36);
            this.info_maps_count_text.TabIndex = 0;
            this.info_maps_count_text.Text = "تعداد نقشه های موجود:\r\n";
            this.info_maps_count_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // info_ringBinders_count_text
            // 
            this.info_ringBinders_count_text.AccessibleDescription = "تعداد زونکن های موجود:";
            this.info_ringBinders_count_text.Location = new System.Drawing.Point(24, 102);
            this.info_ringBinders_count_text.MaxLength = 50;
            this.info_ringBinders_count_text.Name = "info_ringBinders_count_text";
            this.info_ringBinders_count_text.ReadOnly = true;
            this.info_ringBinders_count_text.Size = new System.Drawing.Size(301, 36);
            this.info_ringBinders_count_text.TabIndex = 0;
            this.info_ringBinders_count_text.Text = "تعداد زونکن های موجود:";
            this.info_ringBinders_count_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // info_departments_count_text
            // 
            this.info_departments_count_text.AccessibleDescription = "تعداد دپارتمان های جستجو شده:";
            this.info_departments_count_text.Location = new System.Drawing.Point(24, 49);
            this.info_departments_count_text.MaxLength = 50;
            this.info_departments_count_text.Name = "info_departments_count_text";
            this.info_departments_count_text.ReadOnly = true;
            this.info_departments_count_text.Size = new System.Drawing.Size(301, 36);
            this.info_departments_count_text.TabIndex = 0;
            this.info_departments_count_text.Text = "تعداد دپارتمان های جستجو شده:";
            this.info_departments_count_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.disable_update_button);
            this.groupBox2.Controls.Add(this.confirm_button);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.descriptions_text);
            this.groupBox2.Controls.Add(this.name_text);
            this.groupBox2.Location = new System.Drawing.Point(373, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(343, 315);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "افزودن دپارتمان";
            // 
            // disable_update_button
            // 
            this.disable_update_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.disable_update_button.Enabled = false;
            this.disable_update_button.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.disable_update_button.Location = new System.Drawing.Point(211, 259);
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
            this.confirm_button.Location = new System.Drawing.Point(22, 254);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(106, 42);
            this.confirm_button.TabIndex = 2;
            this.confirm_button.Text = "ثبت";
            this.confirm_button.UseVisualStyleBackColor = false;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "توضیحات:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام:";
            // 
            // descriptions_text
            // 
            this.descriptions_text.Font = new System.Drawing.Font("Tahoma", 14F);
            this.descriptions_text.Location = new System.Drawing.Point(22, 79);
            this.descriptions_text.MaxLength = 500;
            this.descriptions_text.Multiline = true;
            this.descriptions_text.Name = "descriptions_text";
            this.descriptions_text.Size = new System.Drawing.Size(241, 160);
            this.descriptions_text.TabIndex = 0;
            this.descriptions_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name_text
            // 
            this.name_text.Font = new System.Drawing.Font("Tahoma", 14F);
            this.name_text.Location = new System.Drawing.Point(22, 37);
            this.name_text.MaxLength = 50;
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(241, 30);
            this.name_text.TabIndex = 0;
            this.name_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear_search_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.departments_list);
            this.groupBox1.Controls.Add(this.department_search_text);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(343, 492);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست دپارتمان ها";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "جستجو:";
            // 
            // departments_list
            // 
            this.departments_list.FormattingEnabled = true;
            this.departments_list.ItemHeight = 28;
            this.departments_list.Location = new System.Drawing.Point(24, 79);
            this.departments_list.Name = "departments_list";
            this.departments_list.Size = new System.Drawing.Size(301, 396);
            this.departments_list.TabIndex = 1;
            this.departments_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.departments_list_MouseDoubleClick);
            // 
            // department_search_text
            // 
            this.department_search_text.Font = new System.Drawing.Font("Tahoma", 14F);
            this.department_search_text.Location = new System.Drawing.Point(62, 37);
            this.department_search_text.MaxLength = 50;
            this.department_search_text.Name = "department_search_text";
            this.department_search_text.Size = new System.Drawing.Size(203, 30);
            this.department_search_text.TabIndex = 0;
            this.department_search_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.department_search_text.TextChanged += new System.EventHandler(this.department_search_text_TextChanged);
            // 
            // ringBinder_form_button
            // 
            this.ringBinder_form_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ringBinder_form_button.Location = new System.Drawing.Point(12, 519);
            this.ringBinder_form_button.Name = "ringBinder_form_button";
            this.ringBinder_form_button.Size = new System.Drawing.Size(141, 42);
            this.ringBinder_form_button.TabIndex = 2;
            this.ringBinder_form_button.Text = "مدیریت زونکن ها";
            this.ringBinder_form_button.UseVisualStyleBackColor = false;
            this.ringBinder_form_button.Click += new System.EventHandler(this.ringBinder_form_button_Click);
            // 
            // clear_search_button
            // 
            this.clear_search_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clear_search_button.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.clear_search_button.Location = new System.Drawing.Point(24, 33);
            this.clear_search_button.Name = "clear_search_button";
            this.clear_search_button.Size = new System.Drawing.Size(32, 33);
            this.clear_search_button.TabIndex = 2;
            this.clear_search_button.Text = "c";
            this.clear_search_button.UseVisualStyleBackColor = false;
            this.clear_search_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 582);
            this.Controls.Add(this.ringBinder_form_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.departments_info_gp);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "DepartmentsForm";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم مدیریت دپارتمان ها";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DepartmentsForm_FormClosing);
            this.Load += new System.EventHandler(this.DepartmentsForm_Load);
            this.departments_info_gp.ResumeLayout(false);
            this.departments_info_gp.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox departments_info_gp;
        private System.Windows.Forms.TextBox info_maps_count_text;
        private System.Windows.Forms.TextBox info_ringBinders_count_text;
        private System.Windows.Forms.TextBox info_departments_count_text;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptions_text;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox departments_list;
        private System.Windows.Forms.TextBox department_search_text;
        private System.Windows.Forms.Button disable_update_button;
        private System.Windows.Forms.Button ringBinder_form_button;
        private System.Windows.Forms.Button clear_search_button;
    }
}

