namespace FrizerskiSalonWinUI
{
    partial class FormaNoviRadnik
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
            label1 = new Label();
            textBox1 = new TextBox();
            btnRadnikSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 45);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Ime i prezime:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 1;
            // 
            // btnRadnikSave
            // 
            btnRadnikSave.Location = new Point(653, 399);
            btnRadnikSave.Name = "btnRadnikSave";
            btnRadnikSave.Size = new Size(75, 23);
            btnRadnikSave.TabIndex = 2;
            btnRadnikSave.Text = "Snimi";
            btnRadnikSave.UseVisualStyleBackColor = true;
            btnRadnikSave.Click += btnRadnikSave_Click;
            // 
            // FormaNoviRadnik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRadnikSave);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormaNoviRadnik";
            Text = "FormaNoviRadnik";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnRadnikSave;
    }
}