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
    public partial class TermekKategoriaForm : Form
    {
        public TermekKategoriaForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadKategoriak();
        }
        private RendelesDbContext _context;
        private void TermekKategoriaForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadKategoriak()
        {
            var kategoriak = (from k in _context.TermekKategoria
                              select k).ToList();

            treeViewKategoriak.Nodes.Clear();
            var fokategoriak = from k in kategoriak
                               where k.SzuloKategoriaId == null
                               select k;

            foreach (var kategoria in fokategoriak)
            {
                var node = CreateTreeNode(kategoria, kategoriak);
                treeViewKategoriak.Nodes.Add(node);
            }
        }
        private TreeNode CreateTreeNode(TermekKategoria kategoria, List<TermekKategoria> osszeKategoria)
        {
            var node = new TreeNode(kategoria.Nev) { Tag = kategoria };
            var alkategoriak = from k in osszeKategoria
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;

            foreach (var gyerekKategoria in alkategoriak)
            {
                node.Nodes.Add(CreateTreeNode(gyerekKategoria, osszeKategoria));
            }
            return node;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void újFőkategóriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermekKategoria kategoria = new TermekKategoria();
            _context.TermekKategoria.Add(kategoria);
            _context.SaveChanges();
            TreeNode uj = new TreeNode();
        }

        private void treeViewKategoriak_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
