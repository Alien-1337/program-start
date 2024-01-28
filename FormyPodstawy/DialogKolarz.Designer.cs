namespace FormyPodstawy
{
    partial class DialogKolarz
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
            btnAnuluj = new Button();
            btnOK = new Button();
            txtImie = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            txtTeam = new TextBox();
            txtNazwisko = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            checkWpisowe = new CheckBox();
            nmRanking = new NumericUpDown();
            nmWiek = new NumericUpDown();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmRanking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmWiek).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAnuluj
            // 
            btnAnuluj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnuluj.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnuluj.ImageKey = "remove.png";
            btnAnuluj.Location = new Point(518, 559);
            btnAnuluj.Margin = new Padding(4);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(174, 56);
            btnAnuluj.TabIndex = 5;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.ImageAlign = ContentAlignment.MiddleLeft;
            btnOK.ImageKey = "remove.png";
            btnOK.Location = new Point(337, 559);
            btnOK.Margin = new Padding(4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(174, 56);
            btnOK.TabIndex = 6;
            btnOK.Text = "Zapisz";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtImie
            // 
            txtImie.Anchor = AnchorStyles.Left;
            txtImie.Location = new Point(151, 158);
            txtImie.Margin = new Padding(4);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(523, 29);
            txtImie.TabIndex = 8;
            txtImie.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(71, 166);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 9;
            label1.Text = "Imie";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left;
            txtEmail.Location = new Point(151, 333);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(523, 29);
            txtEmail.TabIndex = 11;
            // 
            // txtTeam
            // 
            txtTeam.Anchor = AnchorStyles.Left;
            txtTeam.Location = new Point(151, 273);
            txtTeam.Margin = new Padding(4);
            txtTeam.Name = "txtTeam";
            txtTeam.Size = new Size(523, 29);
            txtTeam.TabIndex = 12;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Anchor = AnchorStyles.Left;
            txtNazwisko.Location = new Point(151, 216);
            txtNazwisko.Margin = new Padding(4);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(523, 29);
            txtNazwisko.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(70, 281);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 14;
            label2.Text = "Team";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(44, 456);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 15;
            label3.Text = "Ranking";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(66, 506);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 16;
            label4.Text = "Wiek";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(68, 341);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 17;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(51, 224);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 18;
            label6.Text = "Nazwisko";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(42, 402);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 19;
            label7.Text = "Wpisowe";
            // 
            // checkWpisowe
            // 
            checkWpisowe.Anchor = AnchorStyles.Left;
            checkWpisowe.AutoSize = true;
            checkWpisowe.Location = new Point(151, 398);
            checkWpisowe.Name = "checkWpisowe";
            checkWpisowe.Size = new Size(99, 25);
            checkWpisowe.TabIndex = 20;
            checkWpisowe.Text = "Wpłacono";
            checkWpisowe.UseVisualStyleBackColor = true;
            // 
            // nmRanking
            // 
            nmRanking.Anchor = AnchorStyles.Left;
            nmRanking.Location = new Point(151, 448);
            nmRanking.Margin = new Padding(4);
            nmRanking.Name = "nmRanking";
            nmRanking.Size = new Size(120, 29);
            nmRanking.TabIndex = 21;
            // 
            // nmWiek
            // 
            nmWiek.Anchor = AnchorStyles.Left;
            nmWiek.Location = new Point(151, 498);
            nmWiek.Margin = new Padding(4);
            nmWiek.Name = "nmWiek";
            nmWiek.Size = new Size(120, 29);
            nmWiek.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(-229, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 124);
            panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(15, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 95);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(470, 41);
            label8.Name = "label8";
            label8.Size = new Size(200, 32);
            label8.TabIndex = 0;
            label8.Text = "Edycja zawodnika";
            label8.Click += label8_Click;
            // 
            // DialogKolarz
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnAnuluj;
            ClientSize = new Size(707, 632);
            Controls.Add(panel1);
            Controls.Add(nmWiek);
            Controls.Add(nmRanking);
            Controls.Add(checkWpisowe);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNazwisko);
            Controls.Add(txtTeam);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtImie);
            Controls.Add(btnOK);
            Controls.Add(btnAnuluj);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DialogKolarz";
            Text = "Kolarz";
            Load += DialogKolarz_Load;
            ((System.ComponentModel.ISupportInitialize)nmRanking).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmWiek).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnuluj;
        private Button btnOK;
        private TextBox txtImie;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtTeam;
        private TextBox txtNazwisko;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox checkWpisowe;
        private NumericUpDown nmRanking;
        private NumericUpDown nmWiek;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label8;
    }
}