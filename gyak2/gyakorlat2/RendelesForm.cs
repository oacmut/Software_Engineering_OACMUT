using gyakorlat2.Data;
using gyakorlat2.Models;
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

    public partial class RendelesForm : Form
    {
        private readonly RendelesDbContext _context;

        public RendelesForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadUgyfelek();
            LoadTermekek();
            LoadCimek();
            LoadRendelesek();
        }

        private void RendelesForm_Load(object sender, EventArgs e)
        {

        }

        private void ugyfelszurestextBox_TextChanged(object sender, EventArgs e)
        {
            LoadUgyfelek();
        }
        private void LoadUgyfelek()
        {
            var q = from x in _context.Ugyfel
                    where x.Nev.Contains(ugyfelszurestextBox.Text) || x.Email.Contains(ugyfelszurestextBox.Text)
                    orderby x.Nev
                    select x;
            ugyfelBindingSource.DataSource = q.ToList();

            ugyfelBindingSource.ResetCurrentItem();
        }
        private void LoadTermekek()
        {
            var q = from x in _context.Termek
                    select x;
            termekBindingSource.DataSource = q.ToList();

            termekBindingSource.ResetCurrentItem();
        }
        private void LoadCimek()
        {
            var q = from x in _context.Cim
                    select new CimEgybenDTO
                    {
                        CimId = x.CimId,
                        CimEgyben = $"{x.Iranyitoszam}-{x.Varos}, {x.Orszag}: {x.Utca} {x.Hazszam}"
                    };
            cimEgybenDTOBindingSource.DataSource = q.ToList();
        }
        private void LoadRendelesek()
        {
            if (ugyfelBindingSource.Current == null) return;
            dataGridView1.DataSource = null;
            var rendeles = from x in _context.Rendeles
                           where x.UgyfelId == ((Ugyfel)ugyfelBindingSource.Current).UgyfelId
                           select x;

            rendelesBindingSource.DataSource = rendeles.ToList();

            lbRendeles.DataSource = rendelesBindingSource;

            if (lbRendeles.Items.Count > 0)
            {
                lbRendeles.SelectedIndex = 0;
            }

            rendelesBindingSource.DataSource = rendeles.ToList();

            rendelesBindingSource.ResetCurrentItem();
        }
        private void lbRendeles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lbUgyfelek_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesek();
        }
    }

    public class CimEgybenDTO
    {
        public int CimId { get; set; }
        public string? CimEgyben { get; set; }


    }
}
