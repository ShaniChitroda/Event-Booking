namespace EventBooking
{
    partial class bookingsection
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
            button1 = new Button();
            panel1 = new Panel();
            listBox1 = new ListBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 17);
            label1.Name = "label1";
            label1.Size = new Size(144, 22);
            label1.TabIndex = 0;
            label1.Text = "Booking Section";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(180, 311);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(185, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 390);
            panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Marriage.", "Anniversary.", "Birthday Party.", "Sports Event." });
            listBox1.Location = new Point(166, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(153, 34);
            listBox1.TabIndex = 17;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(166, 261);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(153, 23);
            textBox5.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(166, 227);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(153, 23);
            textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 23);
            textBox2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 269);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 12;
            label6.Text = "Cost Per Dishes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 230);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 11;
            label5.Text = "No. of Dishes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 183);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 10;
            label4.Text = "No. of Chairs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 136);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 9;
            label3.Text = "No. of persons";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 98);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "Event";
            // 
            // bookingsection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "bookingsection";
            Text = "bookingsection";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private ListBox listBox1;
    }
}