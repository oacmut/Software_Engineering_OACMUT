using gyakorlat2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyakorlat2
{
    public partial class UjUgyfelForm : Form
    {
        public Ugyfel SzerkesztettÜgyfél { get; set; }

        public UjUgyfelForm(Ugyfel ugyfel)
        {
            InitializeComponent();
            this.SzerkesztettÜgyfél = ugyfel;
            ugyfelBindingSource.DataSource = SzerkesztettÜgyfél;
        }

        public UjUgyfelForm()
        {
            InitializeComponent();
            this.SzerkesztettÜgyfél = new Ugyfel();
            ugyfelBindingSource.DataSource = SzerkesztettÜgyfél;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Kérjük, javítsa a hibás mezőket!");
                return;
            }
            ugyfelBindingSource.EndEdit();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxNev = new Regex(@"^[\p{L} .'-]+$");

            if (!rgxNev.IsMatch(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "A név csak kis- és nagybetűket jeleníthet meg.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
            if (!rgxEmail.IsMatch(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Hibás Email cím.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxTelefon = new Regex(@"^\+36(?:20|30|31|50|70)(\d{7})$");
            if (!rgxTelefon.IsMatch(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Hibás Telefonszám.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox3, "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
