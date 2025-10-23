using MapsManagerDataLayer.Context;
using MapsManagerDataLayer.Model;
using MapsManagerViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapsManagerApp.Forms
{
    public partial class RingBindersForm : Form
    {
        private int _selected_ringBinder_id;
        public RingBindersForm()
        {
            InitializeComponent();
            _selected_ringBinder_id = 0;

            //ringBinder_list.AutoGenerateColumns = false;
            ringBinder_list.RowTemplate.Height = 35;
        }

        private void disable_update_button_Click(object sender, EventArgs e)
        {
            groupBox2.Text = "ثبت زونکن";
            disable_update_button.Enabled = false;
            confirm_button.Text = "ثبت";
            ClearInputs();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name_text.Text) || department_cb.SelectedIndex == -1)
            {
                MessageBox.Show("لطفا مقادیر ورودی را بصورت کامل مقداردهی کنید.");
                return;
            }

            var act_insert = !disable_update_button.Enabled;
            using (var db = new UnitOfWork())
            {
                var ringBinder = new RingBinder()
                {
                    ID = new Random().Next(),
                    Name = name_text.Text.Trim(),
                    DepartmentID = int.Parse(department_cb.SelectedValue.ToString()),
                    RowNumber = (int)row_number.Value,
                    ShelfNumber = (int)shelf_number.Value,
                };

                if (db.RingBinderRepository.Get(rb => rb.Name == ringBinder.Name && rb.DepartmentID == ringBinder.DepartmentID).Any())
                {
                    MessageBox.Show("زونکنی با این نام در این دپارتمان ثبت شده است ,نام دیگری را انتخاب کنید");
                    return;
                }

                if (act_insert)
                {
                    while (db.RingBinderRepository.GetById(ringBinder.ID) != null)
                    {
                        ringBinder.ID = new Random().Next();
                    }
                    db.RingBinderRepository.Insert(ringBinder);
                    MessageBox.Show("زونکن وارد شده با موفقیت درج شد");
                }
                else
                {
                    ringBinder.ID = _selected_ringBinder_id;
                    db.RingBinderRepository.Update(ringBinder);
                    MessageBox.Show("زونکن انتخاب شده با موفقیت ویرایش شد");
                }

                db.Save();
                ShowRingBinders();
                disable_update_button_Click(null, null);
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            name_text.Clear();
            department_cb.SelectedIndex = -1;
            row_number.Value = 0;
            shelf_number.Value = 0;
        }

        private void ShowRingBinders(string filter = "")
        {
            using (var db = new UnitOfWork())
            {
                var ringBinders = filter == "" ? db.RingBinderRepository.Get() 
                    :db.RingBinderRepository.Get(d => d.Name.Contains(filter) || d.Department.Name.Contains(filter));

                var ringBindersViewModel = ringBinders.ToList().Select(rb => new RingBinderViewModel()
                {
                    ID = rb.ID,
                    Name = rb.Name,
                    RowNumber = rb.RowNumber,
                    ShelfNumber = rb.ShelfNumber,
                    DepartmentName = rb.Department.Name,
                });

                ringBinder_list.DataSource = ringBindersViewModel.ToList();
            }
        }

        private void maps_form_button_Click(object sender, EventArgs e)
        {
            Hide();
            new MapsForm().ShowDialog();
            Show();
        }

        private async void change_size_button_Click(object sender, EventArgs e)
        {
            change_size_button.Enabled = false;

            if (change_size_button.Text == "<<")
            {
                while (Width >= 350)
                {
                    Width -= 20;
                    await Task.Delay(2);
                }
                //Width += 5;
            }
            else
            {
                while (Width <= 1140)
                {
                    Width += 20;
                    await Task.Delay(2);
                }
                Width -= 5;
                // 355 , 1390
            }

            var condition = change_size_button.Text == "<<";
            change_size_button.Text = condition ? ">>" : "<<";
            groupBox1.Enabled = !condition;
            change_size_button.Enabled = true;
        }

        private void ringBinder_list_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ringBinder_list.CurrentRow != null)
            {
                groupBox2.Text = "ویرایش زونکن";
                disable_update_button.Enabled = true;
                confirm_button.Text = "ویرایش";
                _selected_ringBinder_id = int.Parse(ringBinder_list.CurrentRow.Cells[0].Value.ToString());

                using (var db = new UnitOfWork())
                {
                    var ringBinder = db.RingBinderRepository.GetById(_selected_ringBinder_id);
                    name_text.Text = ringBinder.Name;
                    row_number.Value = ringBinder.RowNumber;
                    shelf_number.Value=ringBinder.ShelfNumber;
                    department_cb.Text = db.DepartmentRepository.GetById(ringBinder.DepartmentID).Name;
                }
            }
        }

        private void ShowDepartments()
        {
            using (var db = new UnitOfWork())
            {
                department_cb.ValueMember = "ID";
                department_cb.DisplayMember = "Name";

                var departments = db.DepartmentRepository.Get().ToList();
                department_cb.DataSource = departments;
            }
        }
        private void RingBindersForm_Load(object sender, EventArgs e)
        {
            ShowRingBinders();
            ShowDepartments();
        }

        private void clear_search_button_Click(object sender, EventArgs e)
        {
            ringBinder_search_text.Clear();
        }

        private void ringBinder_search_text_TextChanged(object sender, EventArgs e)
        {
            ShowRingBinders(ringBinder_search_text.Text);
        }
    }
}
