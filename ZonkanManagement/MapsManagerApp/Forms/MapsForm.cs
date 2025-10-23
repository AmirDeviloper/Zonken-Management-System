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
    public partial class MapsForm : Form
    {
        private int _selected_map_id;

        public MapsForm()
        {
            InitializeComponent();
            _selected_map_id = 0;
            maps_list.RowTemplate.Height = 35;
        }

        private void ShowRingBinders()
        {
            ringBinder_cb.ValueMember = "ID";
            ringBinder_cb.DisplayMember = "Name";

            using (var db = new UnitOfWork())
            {
                var ringBinders = db.RingBinderRepository.Get().ToList();
                ringBinder_cb.DataSource = ringBinders;
            }
        }

        private void ShowMaps(string filter = "")
        {
            using (var db = new UnitOfWork())
            {
                var maps = filter == "" ? db.MapRepository.Get()
                    : db.MapRepository.Get(m => m.Name.Contains(filter) || m.RingBinder.Name.Contains(filter) || m.RingBinder.Department.Name.Contains(filter));

                var mapsViewModel = maps.ToList().Select(m => new MapViewModel()
                {
                    ID = m.ID,
                    Name = m.Name,
                    RowNumber = m.RingBinder.RowNumber,
                    RingBinderName = m.RingBinder.Name,
                    ShelfNumber = m.RingBinder.ShelfNumber,
                    DepartmentName = m.RingBinder.Department.Name,
                });

                maps_list.DataSource = mapsViewModel.ToList();
            }
        }
        
        private void MapsForm_Load(object sender, EventArgs e)
        {
            ShowRingBinders();
            ShowMaps();
        }

        private async void change_size_button_ClickAsync(object sender, EventArgs e)
        {
            change_size_button.Enabled = false;

            if (change_size_button.Text == "<<")
            {
                while (Width >= 335)
                {
                    Width -= 20;
                    await Task.Delay(2);
                }
            }
            else
            {
                while (Width <= 1200)
                {
                    Width += 20;
                    await Task.Delay(2);
                }
                Width -= 5;
                // 355 , 1200
            }

            var condition = change_size_button.Text == "<<";
            change_size_button.Text = condition ? ">>" : "<<";
            groupBox1.Enabled = !condition;
            change_size_button.Enabled = true;
        }

        private void disable_update_button_Click(object sender, EventArgs e)
        {
            groupBox2.Text = "افزودن نقشه";
            disable_update_button.Enabled = false;
            confirm_button.Text = "ثبت";
            ClearInputs();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name_text.Text) || ringBinder_cb.SelectedIndex == -1)
            {
                MessageBox.Show("لطفا مقادیر ورودی را بصورت کامل مقداردهی کنید.");
                return;
            }

            var act_insert = !disable_update_button.Enabled;
            using (var db = new UnitOfWork())
            {
                var map = new Map()
                {
                    ID = new Random().Next(),
                    Name = name_text.Text.Trim(),
                    RingBinderID = int.Parse(ringBinder_cb.SelectedValue.ToString()),
                };

                if (db.MapRepository.Get(m => m.Name == map.Name && m.RingBinderID == map.RingBinderID).Any())
                {
                    MessageBox.Show("نقشه ای با این نام در این زونکن ثبت شده است ,نام دیگری را انتخاب کنید");
                    return;
                }

                if (act_insert)
                {
                    while (db.MapRepository.GetById(map.ID) != null)
                    {
                        map.ID = new Random().Next();
                    }
                    db.MapRepository.Insert(map);
                    MessageBox.Show("نقشه وارد شده با موفقیت درج شد");
                }
                else
                {
                    map.ID = _selected_map_id;
                    db.MapRepository.Update(map);
                    MessageBox.Show("نقشه انتخاب شده با موفقیت ویرایش شد");
                }

                db.Save();
                ShowMaps();
                disable_update_button_Click(null, null);
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            name_text.Clear();
            ringBinder_cb.SelectedIndex = -1;
            info_text.Clear();
        }

        private string GetInfoFromRingBinder(RingBinder ringBinder)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"دپارتمان {ringBinder.Department.Name}");
            stringBuilder.AppendLine($"ردیف {ringBinder.RowNumber}");
            stringBuilder.Append($"قفسه {ringBinder.ShelfNumber}");

            return stringBuilder.ToString();
        }

        private void ringBinder_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ringBinder_cb.SelectedIndex > -1)
            {
                using (var db = new UnitOfWork())
                {
                    var ringBinder_id = int.Parse(ringBinder_cb.SelectedValue.ToString());
                    var ringBinder = db.RingBinderRepository.GetById(ringBinder_id);

                    info_text.Text = GetInfoFromRingBinder(ringBinder);
                }
            }
        }

        private void maps_list_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (maps_list.CurrentRow != null)
            {
                groupBox2.Text = "ویرایش نقشه";
                disable_update_button.Enabled = true;
                confirm_button.Text = "ویرایش";
                _selected_map_id = int.Parse(maps_list.CurrentRow.Cells[0].Value.ToString());

                using (var db = new UnitOfWork())
                {
                    var map = db.MapRepository.GetById(_selected_map_id);
                    name_text.Text = map.Name;
                    ringBinder_cb.Text = map.RingBinder.Name;

                    info_text.Text = GetInfoFromRingBinder(map.RingBinder);
                }

            }
        }

        private void clear_search_button_Click(object sender, EventArgs e)
        {
            map_search_text.Clear();
        }

        private void map_search_text_TextChanged(object sender, EventArgs e)
        {
            ShowMaps(map_search_text.Text);
        }
    }
}
