using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_ResizeBegin(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void fMain_ResizeEnd(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvTowns.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Ім'я";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Sename";
            column.Name = "Прізвище";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Father";
            column.Name = "По-батькові";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Gromad";
            column.Name = "Громадянство";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Adress";
            column.Name = "Адреса";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Phone";
            column.Name = "Номер тел.";
            column.Width = 80;
            gvTowns.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Student";
            column.Name = "Студент?";
            column.Width = 60;
            gvTowns.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Vik";
            column.Name = "Повнолітній?";
            column.Width = 60;
            gvTowns.Columns.Add(column);
            bindSrcTowns.Add(new Person("Сергій", "Кушінр", "Юрійович", "Украина", "Миколаїв", "55-66-77", true, true));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            PersonForm ft = new PersonForm(person);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTowns.Add(person);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Person person = (Person)bindSrcTowns.List[bindSrcTowns.Position];
            PersonForm ft = new PersonForm(person);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTowns.List[bindSrcTowns.Position] = person;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcTowns.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені","Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcTowns.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
