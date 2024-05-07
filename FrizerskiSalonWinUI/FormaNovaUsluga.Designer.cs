namespace FrizerskiSalonWinUI
{
    partial class FormaNovaUsluga
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
            lblUslugaNaziv = new Label();
            tBoxUslugaNaziv = new TextBox();
            tBoxUslugaTrajanje = new TextBox();
            tBoxUslugaCena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnUslugaSave = new Button();
            SuspendLayout();
            // 
            // lblUslugaNaziv
            // 
            lblUslugaNaziv.AutoSize = true;
            lblUslugaNaziv.Location = new Point(41, 55);
            lblUslugaNaziv.Name = "lblUslugaNaziv";
            lblUslugaNaziv.Size = new Size(36, 15);
            lblUslugaNaziv.TabIndex = 0;
            lblUslugaNaziv.Text = "Naziv";
            // 
            // tBoxUslugaNaziv
            // 
            tBoxUslugaNaziv.Location = new Point(112, 55);
            tBoxUslugaNaziv.Name = "tBoxUslugaNaziv";
            tBoxUslugaNaziv.Size = new Size(169, 23);
            tBoxUslugaNaziv.TabIndex = 1;
            // 
            // tBoxUslugaTrajanje
            // 
            tBoxUslugaTrajanje.Location = new Point(112, 84);
            tBoxUslugaTrajanje.Name = "tBoxUslugaTrajanje";
            tBoxUslugaTrajanje.Size = new Size(169, 23);
            tBoxUslugaTrajanje.TabIndex = 2;
            // 
            // tBoxUslugaCena
            // 
            tBoxUslugaCena.Location = new Point(116, 117);
            tBoxUslugaCena.Name = "tBoxUslugaCena";
            tBoxUslugaCena.Size = new Size(165, 23);
            tBoxUslugaCena.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 87);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "Trajanje";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 126);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Cena";
            // 
            // btnUslugaSave
            // 
            btnUslugaSave.Location = new Point(363, 214);
            btnUslugaSave.Name = "btnUslugaSave";
            btnUslugaSave.Size = new Size(75, 23);
            btnUslugaSave.TabIndex = 6;
            btnUslugaSave.Text = "Snimi";
            btnUslugaSave.UseVisualStyleBackColor = true;
            btnUslugaSave.Click += btnUslugaSave_Click;
            // 
            // FormaNovaUsluga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUslugaSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tBoxUslugaCena);
            Controls.Add(tBoxUslugaTrajanje);
            Controls.Add(tBoxUslugaNaziv);
            Controls.Add(lblUslugaNaziv);
            Name = "FormaNovaUsluga";
            Text = "FormaNovaUsluga";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUslugaNaziv;
        private TextBox tBoxUslugaNaziv;
        private TextBox tBoxUslugaTrajanje;
        private TextBox tBoxUslugaCena;
        private Label label1;
        private Label label2;
        private Button btnUslugaSave;
    }
}