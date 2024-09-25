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
            treeViewKategoriak = new TreeView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // treeViewKategoriak
            // 
            treeViewKategoriak.Location = new Point(12, 12);
            treeViewKategoriak.Name = "treeViewKategoriak";
            treeViewKategoriak.Size = new Size(409, 288);
            treeViewKategoriak.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(534, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(435, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(534, 41);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(435, 137);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(534, 195);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 3;
            button1.Text = "Új testvér kat.";
            button1.UseVisualStyleBackColor = true;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 132);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // TermekKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(treeViewKategoriak);
            Name = "TermekKategoriaForm";
            Text = "TermekKategoriaForm";
            Load += TermekKategoriaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewKategoriak;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}