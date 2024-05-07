namespace FrizerskiSalonWinUI
{
    partial class Dan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            danNaziv = new Label();
            SuspendLayout();
            // 
            // danNaziv
            // 
            danNaziv.BackColor = Color.LightGreen;
            danNaziv.Dock = DockStyle.Top;
            danNaziv.Location = new Point(0, 0);
            danNaziv.Name = "danNaziv";
            danNaziv.Size = new Size(187, 24);
            danNaziv.TabIndex = 0;
            danNaziv.Text = "label1";
            // 
            // Dan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(danNaziv);
            Name = "Dan";
            Size = new Size(187, 707);
            ResumeLayout(false);
        }

        #endregion

        private Label danNaziv;
    }
}
