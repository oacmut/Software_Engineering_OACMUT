namespace gyakorlat2
{
    partial class TermekKategoriaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            treeViewKategoriak = new TreeView();
            contextMenuStripKategoria = new ContextMenuStrip(components);
            újFőkategóriaToolStripMenuItem = new ToolStripMenuItem();
            átnevezésToolStripMenuItem = new ToolStripMenuItem();
            újAlkategóriaToolStripMenuItem = new ToolStripMenuItem();
            törlésToolStripMenuItem = new ToolStripMenuItem();
            frissítésToolStripMenuItem = new ToolStripMenuItem();
            txtNev = new TextBox();
            txtLeiras = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            contextMenuStripKategoria.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewKategoriak
            // 
            treeViewKategoriak.ContextMenuStrip = contextMenuStripKategoria;
            treeViewKategoriak.Location = new Point(12, 12);
            treeViewKategoriak.Name = "treeViewKategoriak";
            treeViewKategoriak.Size = new Size(409, 288);
            treeViewKategoriak.TabIndex = 0;
            treeViewKategoriak.AfterSelect += treeViewKategoriak_AfterSelect;
            // 
            // contextMenuStripKategoria
            // 
            contextMenuStripKategoria.Items.AddRange(new ToolStripItem[] { újFőkategóriaToolStripMenuItem, átnevezésToolStripMenuItem, újAlkategóriaToolStripMenuItem, törlésToolStripMenuItem, frissítésToolStripMenuItem });
            contextMenuStripKategoria.Name = "contextMenuStripKategoria";
            contextMenuStripKategoria.RenderMode = ToolStripRenderMode.Professional;
            contextMenuStripKategoria.Size = new Size(149, 114);
            // 
            // újFőkategóriaToolStripMenuItem
            // 
            újFőkategóriaToolStripMenuItem.Name = "újFőkategóriaToolStripMenuItem";
            újFőkategóriaToolStripMenuItem.Size = new Size(148, 22);
            újFőkategóriaToolStripMenuItem.Text = "Új főkategória";
            újFőkategóriaToolStripMenuItem.Click += újFőkategóriaToolStripMenuItem_Click;
            // 
            // átnevezésToolStripMenuItem
            // 
            átnevezésToolStripMenuItem.Name = "átnevezésToolStripMenuItem";
            átnevezésToolStripMenuItem.Size = new Size(148, 22);
            átnevezésToolStripMenuItem.Text = "Átnevezés";
            // 
            // újAlkategóriaToolStripMenuItem
            // 
            újAlkategóriaToolStripMenuItem.Name = "újAlkategóriaToolStripMenuItem";
            újAlkategóriaToolStripMenuItem.Size = new Size(148, 22);
            újAlkategóriaToolStripMenuItem.Text = "Új alkategória";
            // 
            // törlésToolStripMenuItem
            // 
            törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            törlésToolStripMenuItem.Size = new Size(148, 22);
            törlésToolStripMenuItem.Text = "Törlés";
            // 
            // frissítésToolStripMenuItem
            // 
            frissítésToolStripMenuItem.Name = "frissítésToolStripMenuItem";
            frissítésToolStripMenuItem.Size = new Size(148, 22);
            frissítésToolStripMenuItem.Text = "Frissítés";
            // 
            // txtNev
            // 
            txtNev.Location = new Point(534, 12);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(435, 23);
            txtNev.TabIndex = 1;
            // 
            // txtLeiras
            // 
            txtLeiras.Location = new Point(534, 41);
            txtLeiras.Multiline = true;
            txtLeiras.Name = "txtLeiras";
            txtLeiras.Size = new Size(435, 137);
            txtLeiras.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(534, 195);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 3;
            button1.Text = "Új testvér kat.";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(653, 195);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 4;
            button2.Text = "Új gyermek kat.";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(792, 195);
            button3.Name = "button3";
            button3.Size = new Size(79, 23);
            button3.TabIndex = 5;
            button3.Text = "Mentés";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(890, 195);
            button4.Name = "button4";
            button4.Size = new Size(79, 23);
            button4.TabIndex = 6;
            button4.Text = "Törlés";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(469, 15);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 7;
            label1.Text = "Név";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 44);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 8;
            label2.Text = "Leírás";
            // 
            // TermekKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtLeiras);
            Controls.Add(txtNev);
            Controls.Add(treeViewKategoriak);
            Name = "TermekKategoriaForm";
            Text = "TermekKategoriaForm";
            Load += TermekKategoriaForm_Load;
            contextMenuStripKategoria.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewKategoriak;
        private TextBox txtNev;
        private TextBox txtLeiras;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStripKategoria;
        private ToolStripMenuItem átnevezésToolStripMenuItem;
        private ToolStripMenuItem újFőkategóriaToolStripMenuItem;
        private ToolStripMenuItem újAlkategóriaToolStripMenuItem;
        private ToolStripMenuItem törlésToolStripMenuItem;
        private ToolStripMenuItem frissítésToolStripMenuItem;
    }
}