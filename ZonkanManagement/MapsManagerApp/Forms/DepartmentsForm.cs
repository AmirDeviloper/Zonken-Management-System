using MapsManagerApp.Forms;
using MapsManagerApp.InitilizeFirstTime;
using MapsManagerDataLayer.Context;
using MapsManagerDataLayer.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MapsManagerApp
{
    public partial class DepartmentsForm : Form
    {
        private int _selected_department_id;
        private bool _should_run;
        public DepartmentsForm()
        {
            InitializeComponent();
            _should_run = InitDatabase.CreateIfNeed(); 
        }

        private void department_search_text_TextChanged(object sender, EventArgs e)
        {
            ShowDepartments(department_search_text.Text);
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            foreach (var textBox in groupBox2.Controls.OfType<TextBox>())
            {
                if(string.IsNullOrEmpty(textBox.Text))
                {
                    MessageBox.Show("لطفا مقادیر ورودی را بصورت کامل مقداردهی کنید.");
                    return;
                }
            }

            var act_insert = !disable_update_button.Enabled;
            using (var db = new UnitOfWork())
            {
                var department = new Department()
                {
                    ID = new Random().Next(),
                    Name = name_text.Text.Trim(),
                    Description = descriptions_text.Text.Trim(),
                };

                if (db.DepartmentRepository.Get(d => d.Name == department.Name).Any())
                {
                    MessageBox.Show("دپارتمانی با این نام درج شده است , نام دیگری را انتخاب کنید");
                    return;
                }

                if (act_insert)
                {
                    while (db.DepartmentRepository.GetById(department.ID) != null)
                    {
                        department.ID = new Random().Next();
                    }
                    db.DepartmentRepository.Insert(department);
                    MessageBox.Show("دپارتمان وارد شده با موفقیت درج شد");
                }
                else
                {
                    department.ID = _selected_department_id;
                    db.DepartmentRepository.Update(department);
                    MessageBox.Show("دپارتمان انتخاب شده با موفقیت ویرایش شد");
                }

                db.Save();
                ShowDepartments();
                disable_update_button_Click(null, null);
                foreach (var textBox in groupBox2.Controls.OfType<TextBox>())
                {
                    textBox.Clear();
                }
            }
        }

        private void departments_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void disable_update_button_Click(object sender, EventArgs e)
        {
            groupBox2.Text = "افزودن دپارتمان";
            disable_update_button.Enabled = false;
            confirm_button.Text = "ثبت";
            foreach (var textBox in groupBox2.Controls.OfType<TextBox>())
            {
                textBox.Clear();
            }
        }

        private void ringBinder_form_button_Click(object sender, EventArgs e)
        {
            Hide();
            new RingBindersForm().ShowDialog();
            Show();
            ShowDepartments();
        }

        private void DepartmentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("آیا میخواهید از برنامه خارج شوید؟", "تأیید خروج برنامه", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ShowDepartments(string filter = "")
        {
            using (var db = new UnitOfWork())
            {
                departments_list.ValueMember = "ID";
                departments_list.DisplayMember = "Name";
                var departments = filter == "" ? 
                    db.DepartmentRepository.Get() :
                    db.DepartmentRepository.Get(d => d.Name.Contains(filter));
                
                departments_list.DataSource = departments;

                info_departments_count_text.Text = $"{info_departments_count_text.AccessibleDescription} {departments.ToList().Count}";

                var bindersCounts = departments
                    .Select(d => new { RingBindersCount = d.RingBinder.Count() })
                    .Sum(d => d.RingBindersCount);
                info_ringBinders_count_text.Text = $"{info_ringBinders_count_text.AccessibleDescription} {bindersCounts}";

                var mapsCounts = departments
                    .Select(d => new { MapsCount = d.RingBinder.SelectMany(rb => rb.Map).Count() })
                    .Sum(d => d.MapsCount);
                info_maps_count_text.Text = $"{info_maps_count_text.AccessibleDescription} {mapsCounts}";
            }
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            if (_should_run) ShowDepartments();
            else Application.Exit();
        }

        private void departments_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (departments_list.SelectedIndex > -1)
            {
                groupBox2.Text = "ویرایش دپارتمان";
                disable_update_button.Enabled = true;
                confirm_button.Text = "ویرایش";
                _selected_department_id = int.Parse(departments_list.SelectedValue.ToString());

                using (var db = new UnitOfWork())
                {
                    var department = db.DepartmentRepository.GetById(_selected_department_id);
                    name_text.Text = department.Name;
                    descriptions_text.Text = department.Description;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            department_search_text.Clear();
        }
    }
}
