namespace gyakorlat2
{
    partial class RendelesForm
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
            ugyfellistBox = new ListBox();
            ugyfelBindingSource = new BindingSource(components);
            lbRendeles = new ListBox();
            rendelesBindingSource = new BindingSource(components);
            termeklistBox = new ListBox();
            termekBindingSource = new BindingSource(components);
            ugyfelszurestextBox = new TextBox();
            kedvezmenytextBox = new TextBox();
            mennyisegtextBox = new TextBox();
            ujrendelesButton = new Button();
            hozzaadasButton = new Button();
            torlesButton = new Button();
            mentesButton = new Button();
            cimcomboBox = new ComboBox();
            cimEgybenDTOBindingSource = new BindingSource(components);
            statuszcomboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            rendelesIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            szallitasiCimIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rendelesDatumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statuszDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kedvezmenyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vegosszegDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rendelesTetelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            szallitasiCimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cimEgybenDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ugyfellistBox
            // 
            ugyfellistBox.DataSource = ugyfelBindingSource;
            ugyfellistBox.DisplayMember = "Nev";
            ugyfellistBox.FormattingEnabled = true;
            ugyfellistBox.ItemHeight = 15;
            ugyfellistBox.Location = new Point(28, 115);
            ugyfellistBox.Name = "ugyfellistBox";
            ugyfellistBox.Size = new Size(120, 349);
            ugyfellistBox.TabIndex = 0;
            ugyfellistBox.ValueMember = "UgyfelId";
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // lbRendeles
            // 
            lbRendeles.DataSource = rendelesBindingSource;
            lbRendeles.DisplayMember = "RendelesDatum";
            lbRendeles.FormattingEnabled = true;
            lbRendeles.ItemHeight = 15;
            lbRendeles.Location = new Point(172, 115);
            lbRendeles.Name = "lbRendeles";
            lbRendeles.Size = new Size(120, 349);
            lbRendeles.TabIndex = 1;
            lbRendeles.ValueMember = "RendelesId";
            lbRendeles.SelectedIndexChanged += lbRendeles_SelectedIndexChanged;
            // 
            // rendelesBindingSource
            // 
            rendelesBindingSource.DataSource = typeof(Models.Rendeles);
            // 
            // termeklistBox
            // 
            termeklistBox.DataSource = termekBindingSource;
            termeklistBox.DisplayMember = "Nev";
            termeklistBox.FormattingEnabled = true;
            termeklistBox.ItemHeight = 15;
            termeklistBox.Location = new Point(947, 115);
            termeklistBox.Name = "termeklistBox";
            termeklistBox.Size = new Size(120, 349);
            termeklistBox.TabIndex = 2;
            termeklistBox.ValueMember = "TermekId";
            // 
            // termekBindingSource
            // 
            termekBindingSource.DataSource = typeof(Models.Termek);
            // 
            // ugyfelszurestextBox
            // 
            ugyfelszurestextBox.Location = new Point(28, 48);
            ugyfelszurestextBox.Name = "ugyfelszurestextBox";
            ugyfelszurestextBox.Size = new Size(120, 23);
            ugyfelszurestextBox.TabIndex = 3;
            ugyfelszurestextBox.TextChanged += ugyfelszurestextBox_TextChanged;
            // 
            // kedvezmenytextBox
            // 
            kedvezmenytextBox.Location = new Point(567, 48);
            kedvezmenytextBox.Name = "kedvezmenytextBox";
            kedvezmenytextBox.Size = new Size(120, 23);
            kedvezmenytextBox.TabIndex = 4;
            // 
            // mennyisegtextBox
            // 
            mennyisegtextBox.Location = new Point(813, 244);
            mennyisegtextBox.Name = "mennyisegtextBox";
            mennyisegtextBox.Size = new Size(120, 23);
            mennyisegtextBox.TabIndex = 5;
            // 
            // ujrendelesButton
            // 
            ujrendelesButton.Location = new Point(172, 470);
            ujrendelesButton.Name = "ujrendelesButton";
            ujrendelesButton.Size = new Size(120, 23);
            ujrendelesButton.TabIndex = 6;
            ujrendelesButton.Text = "Új rendelés";
            ujrendelesButton.UseVisualStyleBackColor = true;
            // 
            // hozzaadasButton
            // 
            hozzaadasButton.Location = new Point(813, 273);
            hozzaadasButton.Name = "hozzaadasButton";
            hozzaadasButton.Size = new Size(120, 23);
            hozzaadasButton.TabIndex = 7;
            hozzaadasButton.Text = "Tétel hozzáadása";
            hozzaadasButton.UseVisualStyleBackColor = true;
            // 
            // torlesButton
            // 
            torlesButton.Location = new Point(813, 302);
            torlesButton.Name = "torlesButton";
            torlesButton.Size = new Size(120, 23);
            torlesButton.TabIndex = 8;
            torlesButton.Text = "Tétel törlése";
            torlesButton.UseVisualStyleBackColor = true;
            // 
            // mentesButton
            // 
            mentesButton.Location = new Point(672, 470);
            mentesButton.Name = "mentesButton";
            mentesButton.Size = new Size(120, 23);
            mentesButton.TabIndex = 9;
            mentesButton.Text = "Mentés";
            mentesButton.UseVisualStyleBackColor = true;
            // 
            // cimcomboBox
            // 
            cimcomboBox.DataSource = cimEgybenDTOBindingSource;
            cimcomboBox.DisplayMember = "CimEgyben";
            cimcomboBox.FormattingEnabled = true;
            cimcomboBox.Location = new Point(299, 48);
            cimcomboBox.Name = "cimcomboBox";
            cimcomboBox.Size = new Size(262, 23);
            cimcomboBox.TabIndex = 10;
            // 
            // cimEgybenDTOBindingSource
            // 
            cimEgybenDTOBindingSource.DataSource = typeof(CimEgybenDTO);
            // 
            // statuszcomboBox
            // 
            statuszcomboBox.FormattingEnabled = true;
            statuszcomboBox.Location = new Point(693, 48);
            statuszcomboBox.Name = "statuszcomboBox";
            statuszcomboBox.Size = new Size(98, 23);
            statuszcomboBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 12;
            label1.Text = "Ügyfelek szűrése";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 30);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 13;
            label2.Text = "Rendelés címe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(567, 30);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 14;
            label3.Text = "Kedvezmény";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(693, 30);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 15;
            label4.Text = "Státusz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(813, 226);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 16;
            label5.Text = "Mennyiség";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(947, 97);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 17;
            label6.Text = "Termékek";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(172, 97);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 18;
            label7.Text = "Rendelések";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 97);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 19;
            label8.Text = "Ügyfelek";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { rendelesIdDataGridViewTextBoxColumn, ugyfelIdDataGridViewTextBoxColumn, szallitasiCimIdDataGridViewTextBoxColumn, rendelesDatumDataGridViewTextBoxColumn, statuszDataGridViewTextBoxColumn, kedvezmenyDataGridViewTextBoxColumn, vegosszegDataGridViewTextBoxColumn, rendelesTetelDataGridViewTextBoxColumn, szallitasiCimDataGridViewTextBoxColumn, ugyfelDataGridViewTextBoxColumn });
            dataGridView1.DataSource = rendelesBindingSource;
            dataGridView1.Location = new Point(299, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(493, 349);
            dataGridView1.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(299, 97);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 21;
            label9.Text = "Rendelt tételek";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(299, 474);
            label10.Name = "label10";
            label10.Size = new Size(144, 15);
            label10.TabIndex = 22;
            label10.Text = "Rendelés teljes értéke: 0 Ft";
            // 
            // rendelesIdDataGridViewTextBoxColumn
            // 
            rendelesIdDataGridViewTextBoxColumn.DataPropertyName = "RendelesId";
            rendelesIdDataGridViewTextBoxColumn.HeaderText = "RendelesId";
            rendelesIdDataGridViewTextBoxColumn.Name = "rendelesIdDataGridViewTextBoxColumn";
            // 
            // ugyfelIdDataGridViewTextBoxColumn
            // 
            ugyfelIdDataGridViewTextBoxColumn.DataPropertyName = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.HeaderText = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.Name = "ugyfelIdDataGridViewTextBoxColumn";
            // 
            // szallitasiCimIdDataGridViewTextBoxColumn
            // 
            szallitasiCimIdDataGridViewTextBoxColumn.DataPropertyName = "SzallitasiCimId";
            szallitasiCimIdDataGridViewTextBoxColumn.HeaderText = "SzallitasiCimId";
            szallitasiCimIdDataGridViewTextBoxColumn.Name = "szallitasiCimIdDataGridViewTextBoxColumn";
            // 
            // rendelesDatumDataGridViewTextBoxColumn
            // 
            rendelesDatumDataGridViewTextBoxColumn.DataPropertyName = "RendelesDatum";
            rendelesDatumDataGridViewTextBoxColumn.HeaderText = "RendelesDatum";
            rendelesDatumDataGridViewTextBoxColumn.Name = "rendelesDatumDataGridViewTextBoxColumn";
            // 
            // statuszDataGridViewTextBoxColumn
            // 
            statuszDataGridViewTextBoxColumn.DataPropertyName = "Statusz";
            statuszDataGridViewTextBoxColumn.HeaderText = "Statusz";
            statuszDataGridViewTextBoxColumn.Name = "statuszDataGridViewTextBoxColumn";
            // 
            // kedvezmenyDataGridViewTextBoxColumn
            // 
            kedvezmenyDataGridViewTextBoxColumn.DataPropertyName = "Kedvezmeny";
            kedvezmenyDataGridViewTextBoxColumn.HeaderText = "Kedvezmeny";
            kedvezmenyDataGridViewTextBoxColumn.Name = "kedvezmenyDataGridViewTextBoxColumn";
            // 
            // vegosszegDataGridViewTextBoxColumn
            // 
            vegosszegDataGridViewTextBoxColumn.DataPropertyName = "Vegosszeg";
            vegosszegDataGridViewTextBoxColumn.HeaderText = "Vegosszeg";
            vegosszegDataGridViewTextBoxColumn.Name = "vegosszegDataGridViewTextBoxColumn";
            // 
            // rendelesTetelDataGridViewTextBoxColumn
            // 
            rendelesTetelDataGridViewTextBoxColumn.DataPropertyName = "RendelesTetel";
            rendelesTetelDataGridViewTextBoxColumn.HeaderText = "RendelesTetel";
            rendelesTetelDataGridViewTextBoxColumn.Name = "rendelesTetelDataGridViewTextBoxColumn";
            rendelesTetelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szallitasiCimDataGridViewTextBoxColumn
            // 
            szallitasiCimDataGridViewTextBoxColumn.DataPropertyName = "SzallitasiCim";
            szallitasiCimDataGridViewTextBoxColumn.HeaderText = "SzallitasiCim";
            szallitasiCimDataGridViewTextBoxColumn.Name = "szallitasiCimDataGridViewTextBoxColumn";
            // 
            // ugyfelDataGridViewTextBoxColumn
            // 
            ugyfelDataGridViewTextBoxColumn.DataPropertyName = "Ugyfel";
            ugyfelDataGridViewTextBoxColumn.HeaderText = "Ugyfel";
            ugyfelDataGridViewTextBoxColumn.Name = "ugyfelDataGridViewTextBoxColumn";
            // 
            // RendelesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 567);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(statuszcomboBox);
            Controls.Add(cimcomboBox);
            Controls.Add(mentesButton);
            Controls.Add(torlesButton);
            Controls.Add(hozzaadasButton);
            Controls.Add(ujrendelesButton);
            Controls.Add(mennyisegtextBox);
            Controls.Add(kedvezmenytextBox);
            Controls.Add(ugyfelszurestextBox);
            Controls.Add(termeklistBox);
            Controls.Add(lbRendeles);
            Controls.Add(ugyfellistBox);
            Name = "RendelesForm";
            Text = "RendelesForm";
            Load += RendelesForm_Load;
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cimEgybenDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ugyfellistBox;
        private ListBox lbRendeles;
        private ListBox termeklistBox;
        private TextBox ugyfelszurestextBox;
        private TextBox kedvezmenytextBox;
        private TextBox mennyisegtextBox;
        private Button ujrendelesButton;
        private Button hozzaadasButton;
        private Button torlesButton;
        private Button mentesButton;
        private ComboBox cimcomboBox;
        private ComboBox statuszcomboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView1;
        private Label label9;
        private Label label10;
        private BindingSource ugyfelBindingSource;
        private BindingSource termekBindingSource;
        private BindingSource cimEgybenDTOBindingSource;
        private BindingSource rendelesBindingSource;
        private DataGridViewTextBoxColumn rendelesIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ugyfelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szallitasiCimIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rendelesDatumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statuszDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kedvezmenyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vegosszegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rendelesTetelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szallitasiCimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ugyfelDataGridViewTextBoxColumn;
    }
}