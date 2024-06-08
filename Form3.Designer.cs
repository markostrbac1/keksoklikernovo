namespace keksoklikernovo
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            listBox1 = new ListBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Bisque;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Cursor = Cursors.Hand;
            listBox1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ForeColor = Color.Maroon;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(135, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(527, 333);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Maroon;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(12, 540);
            button1.Name = "button1";
            button1.Size = new Size(300, 51);
            button1.TabIndex = 4;
            button1.Text = "KUPI";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(670, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Bisque;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Maroon;
            button2.FlatAppearance.BorderSize = 5;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Maroon;
            button2.Location = new Point(318, 540);
            button2.Name = "button2";
            button2.Size = new Size(300, 51);
            button2.TabIndex = 7;
            button2.Text = "ZATVORI";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Bisque;
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Cursor = Cursors.Hand;
            listBox2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            listBox2.ForeColor = Color.Maroon;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 37;
            listBox2.Location = new Point(693, 318);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(259, 222);
            listBox2.TabIndex = 8;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.Bisque;
            listBox3.BorderStyle = BorderStyle.None;
            listBox3.Cursor = Cursors.Hand;
            listBox3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            listBox3.ForeColor = Color.Maroon;
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 37;
            listBox3.Location = new Point(12, 12);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(106, 333);
            listBox3.TabIndex = 9;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 603);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private ListBox listBox2;
        private ListBox listBox3;
    }
}