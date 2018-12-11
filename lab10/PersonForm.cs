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
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

         public Person ThePerson;
         public PersonForm(Person t)
         {
             ThePerson = t;
             InitializeComponent();
         }
        private void fTown_Load(object sender, EventArgs e)
        {
            if (ThePerson != null)
            {
                tbName.Text = ThePerson.Name;
                tbCountry.Text = ThePerson.Sename;
                tbRegion.Text = ThePerson.Father;
                tbPopulation.Text = ThePerson.Gromad;
                tbYearIncome.Text = ThePerson.Adress;
                tbSquare.Text = ThePerson.Phone;
                chbHasPort.Checked = ThePerson.Student;
                chbHasAirport.Checked = ThePerson.Vik;
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ThePerson.Name = tbName.Text.Trim();
            ThePerson.Sename = tbCountry.Text.Trim();
            ThePerson.Father = tbRegion.Text.Trim();
            ThePerson.Gromad = tbPopulation.Text.Trim();
            ThePerson.Adress = tbYearIncome.Text.Trim();
            ThePerson.Phone = tbSquare.Text.Trim();
            ThePerson.Student = chbHasPort.Checked;
            ThePerson.Vik = chbHasAirport.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
