using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro.Models;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Persona> persons;
        public Form1()
        {
            InitializeComponent();
            persons = new List<Persona>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
            person.FirstName = tbName.Text;
            person.LastName = tbLastName.Text;
            person.Birthdate = dtpBirthdate.Value;
            persons.Add(person);
            ShowPersons();
            ClearTb();

        }
        private void ShowPersons()
        {
            dgvPerson.DataSource = null;
            dgvPerson.DataSource = persons;
        }
        private void ClearTb()
        {
            tbName.Clear();
            tbLastName.Clear();
            dtpBirthdate.Value = DateTime.Now;
            tbName.Focus();
        }
    }
}
