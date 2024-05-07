namespace FrizerskiSalonWinUI
{
    partial class FormaRaspored
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
            dateTimePicker1 = new DateTimePicker();
            rButtonPrePodne = new RadioButton();
            rButtonPoslePodne = new RadioButton();
            groupBox1 = new GroupBox();
            btnSacuvajRaspored = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MMMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(12, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(133, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // rButtonPrePodne
            // 
            rButtonPrePodne.AutoSize = true;
            rButtonPrePodne.Location = new Point(47, 38);
            rButtonPrePodne.Name = "rButtonPrePodne";
            rButtonPrePodne.Size = new Size(76, 19);
            rButtonPrePodne.TabIndex = 3;
            rButtonPrePodne.TabStop = true;
            rButtonPrePodne.Text = "Prepodne";
            rButtonPrePodne.UseVisualStyleBackColor = true;
            // 
            // rButtonPoslePodne
            // 
            rButtonPoslePodne.AutoSize = true;
            rButtonPoslePodne.Location = new Point(45, 62);
            rButtonPoslePodne.Name = "rButtonPoslePodne";
            rButtonPoslePodne.Size = new Size(87, 19);
            rButtonPoslePodne.TabIndex = 4;
            rButtonPoslePodne.TabStop = true;
            rButtonPoslePodne.Text = "Poslepodne";
            rButtonPoslePodne.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rButtonPrePodne);
            groupBox1.Controls.Add(rButtonPoslePodne);
            groupBox1.Location = new Point(13, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 118);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prvu nedelju pocinje:";
            // 
            // btnSacuvajRaspored
            // 
            btnSacuvajRaspored.Location = new Point(295, 249);
            btnSacuvajRaspored.Name = "btnSacuvajRaspored";
            btnSacuvajRaspored.Size = new Size(75, 23);
            btnSacuvajRaspored.TabIndex = 6;
            btnSacuvajRaspored.Text = "Snimi";
            btnSacuvajRaspored.UseVisualStyleBackColor = true;
            btnSacuvajRaspored.Click += btnSacuvajRaspored_Click;
            // 
            // FormaRaspored
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 284);
            Controls.Add(btnSacuvajRaspored);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Name = "FormaRaspored";
            Text = "FormaRaspored";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private RadioButton rButtonPrePodne;
        private RadioButton rButtonPoslePodne;
        private GroupBox groupBox1;
        private Button btnSacuvajRaspored;
    }
}