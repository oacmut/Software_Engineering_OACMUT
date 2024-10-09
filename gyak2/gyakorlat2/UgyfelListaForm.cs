using gyakorlat2.Data;
using gyakorlat2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyakorlat2
{
    public partial class UgyfelListaForm : Form
    {
        private RendelesDbContext _context;
        private BindingList<Ugyfel> ugyfelBindingList;
        public UgyfelListaForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UjUgyfelForm ujUgyfelForm = new UjUgyfelForm();
            if (ujUgyfelForm.ShowDialog() == DialogResult.OK)
            {
                ugyfelBindingList.Add(ujUgyfelForm.SzerkesztettÜgyfél);
                Mentés();
            }
        }
        void Mentés()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UgyfelListaForm_Load(object sender, EventArgs e)
        {
            _context.Ugyfel.Load();
            ugyfelBindingList = _context.Ugyfel.Local.ToBindingList();
            ugyfelBindingSource.DataSource = ugyfelBindingList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterString = textBox1.Text.ToLower();
            ugyfelBindingSource.DataSource = from u in ugyfelBindingList
                                             where u.Nev.ToLower().Contains(filterString) ||
                                             u.Email.ToLower().Contains(filterString) ||
                                             (u.Telefonszam != null && u.Telefonszam.Contains(filterString))
                                             orderby u.UgyfelId
                                             select u;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UjUgyfelForm ujUgyfelForm = new UjUgyfelForm((Ugyfel)ugyfelBindingSource.Current);
            if (ujUgyfelForm.ShowDialog() == DialogResult.OK)
            {
                //ugyfelBindingList.Add(ujUgyfelForm.SzerkesztettÜgyfél);
                Mentés();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan Törölni akarod a rekordot?", "Törlés", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK && ugyfelBindingSource.Current != null)
            {
                ugyfelBindingSource.RemoveCurrent();
                Mentés();
            }
        }
    }
}
