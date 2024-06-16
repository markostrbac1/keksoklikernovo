namespace keksoklikernovo
{
    partial class Form2
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
            keks = new PictureBox();
            buttontrgovina = new Button();
            label1 = new Label();
            labelbodovi = new Label();
            label3 = new Label();
            pbpekar = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonSPREMI = new Button();
            label2 = new Label();
            labelzlato = new Label();
            ((System.ComponentModel.ISupportInitialize)keks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpekar).BeginInit();
            SuspendLayout();
            // 
            // keks
            // 
            keks.Cursor = Cursors.Hand;
            keks.Location = new Point(318, 95);
            keks.Name = "keks";
            keks.Size = new Size(300, 300);
            keks.TabIndex = 1;
            keks.TabStop = false;
            keks.Click += keks_Click_1;
            keks.DoubleClick += keks_Click_1;
            // 
            // buttontrgovina
            // 
            buttontrgovina.BackColor = Color.Bisque;
            buttontrgovina.BackgroundImageLayout = ImageLayout.None;
            buttontrgovina.Cursor = Cursors.Hand;
            buttontrgovina.FlatAppearance.BorderColor = Color.Maroon;
            buttontrgovina.FlatAppearance.BorderSize = 5;
            buttontrgovina.FlatStyle = FlatStyle.Flat;
            buttontrgovina.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttontrgovina.ForeColor = Color.Maroon;
            buttontrgovina.Location = new Point(12, 95);
            buttontrgovina.Name = "buttontrgovina";
            buttontrgovina.Size = new Size(300, 75);
            buttontrgovina.TabIndex = 3;
            buttontrgovina.Text = "TRGOVINA";
            buttontrgovina.UseVisualStyleBackColor = false;
            buttontrgovina.Click += buttontrgovina_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(12, 410);
            label1.Name = "label1";
            label1.Size = new Size(258, 81);
            label1.TabIndex = 5;
            label1.Text = "NOVAC:";
            // 
            // labelbodovi
            // 
            labelbodovi.AutoSize = true;
            labelbodovi.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelbodovi.ForeColor = Color.Maroon;
            labelbodovi.Location = new Point(276, 410);
            labelbodovi.Name = "labelbodovi";
            labelbodovi.Size = new Size(70, 81);
            labelbodovi.TabIndex = 6;
            labelbodovi.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(743, 398);
            label3.Name = "label3";
            label3.Size = new Size(164, 60);
            label3.TabIndex = 7;
            label3.Text = "PEKAR";
            // 
            // pbpekar
            // 
            pbpekar.Location = new Point(726, 195);
            pbpekar.Name = "pbpekar";
            pbpekar.Size = new Size(200, 200);
            pbpekar.TabIndex = 8;
            pbpekar.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // buttonSPREMI
            // 
            buttonSPREMI.BackColor = Color.Bisque;
            buttonSPREMI.BackgroundImageLayout = ImageLayout.None;
            buttonSPREMI.Cursor = Cursors.Hand;
            buttonSPREMI.FlatAppearance.BorderColor = Color.Maroon;
            buttonSPREMI.FlatAppearance.BorderSize = 5;
            buttonSPREMI.FlatStyle = FlatStyle.Flat;
            buttonSPREMI.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSPREMI.ForeColor = Color.Maroon;
            buttonSPREMI.Location = new Point(12, 195);
            buttonSPREMI.Name = "buttonSPREMI";
            buttonSPREMI.Size = new Size(300, 76);
            buttonSPREMI.TabIndex = 9;
            buttonSPREMI.Text = "SPREMI I ZATVORI";
            buttonSPREMI.UseVisualStyleBackColor = false;
            buttonSPREMI.Click += buttonSPREMI_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(12, 491);
            label2.Name = "label2";
            label2.Size = new Size(235, 81);
            label2.TabIndex = 10;
            label2.Text = "ZLATO:";
            // 
            // labelzlato
            // 
            labelzlato.AutoSize = true;
            labelzlato.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelzlato.ForeColor = Color.Maroon;
            labelzlato.Location = new Point(276, 491);
            labelzlato.Name = "labelzlato";
            labelzlato.Size = new Size(70, 81);
            labelzlato.TabIndex = 11;
            labelzlato.Text = "0";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(982, 603);
            Controls.Add(labelzlato);
            Controls.Add(label2);
            Controls.Add(buttonSPREMI);
            Controls.Add(pbpekar);
            Controls.Add(label3);
            Controls.Add(labelbodovi);
            Controls.Add(label1);
            Controls.Add(buttontrgovina);
            Controls.Add(keks);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)keks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpekar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox keks;
        private Button buttontrgovina;
        private Label label1;
        private Label labelbodovi;
        private Label label3;
        private PictureBox pbpekar;
        private System.Windows.Forms.Timer timer1;
        private Button buttonSPREMI;
        private Label label2;
        private Label labelzlato;
    }
}