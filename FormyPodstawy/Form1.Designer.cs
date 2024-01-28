namespace FormyPodstawy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            wpisoweDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            wiekDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nazwiskoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            teamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rankingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kolarzBindSource = new BindingSource(components);
            btnDodaj = new Button();
            imageList1 = new ImageList(components);
            btnEdytuj = new Button();
            btnUsun = new Button();
            btnZamknij = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            txtFiltr = new TextBox();
            btnFiltr = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kolarzBindSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, wpisoweDataGridViewCheckBoxColumn, wiekDataGridViewTextBoxColumn, imieDataGridViewTextBoxColumn, nazwiskoDataGridViewTextBoxColumn, teamDataGridViewTextBoxColumn, rankingDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn });
            dataGridView1.DataSource = kolarzBindSource;
            dataGridView1.Location = new Point(34, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1472, 449);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Wpisowe";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // wpisoweDataGridViewCheckBoxColumn
            // 
            wpisoweDataGridViewCheckBoxColumn.DataPropertyName = "Wpisowe";
            wpisoweDataGridViewCheckBoxColumn.HeaderText = "Wpisowe";
            wpisoweDataGridViewCheckBoxColumn.Name = "wpisoweDataGridViewCheckBoxColumn";
            // 
            // wiekDataGridViewTextBoxColumn
            // 
            wiekDataGridViewTextBoxColumn.DataPropertyName = "Wiek";
            wiekDataGridViewTextBoxColumn.HeaderText = "Wiek";
            wiekDataGridViewTextBoxColumn.Name = "wiekDataGridViewTextBoxColumn";
            // 
            // imieDataGridViewTextBoxColumn
            // 
            imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            teamDataGridViewTextBoxColumn.HeaderText = "Team";
            teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            // 
            // rankingDataGridViewTextBoxColumn
            // 
            rankingDataGridViewTextBoxColumn.DataPropertyName = "Ranking";
            rankingDataGridViewTextBoxColumn.HeaderText = "Ranking";
            rankingDataGridViewTextBoxColumn.Name = "rankingDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // kolarzBindSource
            // 
            kolarzBindSource.DataSource = typeof(Kolarz);
            kolarzBindSource.Sort = "Id ASC";
            kolarzBindSource.CurrentChanged += kolarzBindSource_CurrentChanged;
            // 
            // btnDodaj
            // 
            btnDodaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDodaj.ImageAlign = ContentAlignment.MiddleLeft;
            btnDodaj.ImageIndex = 0;
            btnDodaj.ImageList = imageList1;
            btnDodaj.Location = new Point(34, 693);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(135, 40);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj Kolarza";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "106230_add_icon.png");
            imageList1.Images.SetKeyName(1, "close.png");
            imageList1.Images.SetKeyName(2, "edit.png");
            imageList1.Images.SetKeyName(3, "remove.png");
            imageList1.Images.SetKeyName(4, "6827633_advertising_business_filter_funnel_marketing_icon (1).png");
            // 
            // btnEdytuj
            // 
            btnEdytuj.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdytuj.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdytuj.ImageKey = "edit.png";
            btnEdytuj.ImageList = imageList1;
            btnEdytuj.Location = new Point(175, 693);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(135, 40);
            btnEdytuj.TabIndex = 3;
            btnEdytuj.Text = "Edytuj Kolarza";
            btnEdytuj.UseVisualStyleBackColor = true;
            btnEdytuj.Click += btnEdytuj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUsun.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsun.ImageKey = "remove.png";
            btnUsun.ImageList = imageList1;
            btnUsun.Location = new Point(316, 693);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(135, 40);
            btnUsun.TabIndex = 4;
            btnUsun.Text = "Usuń Kolarza";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnZamknij
            // 
            btnZamknij.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnZamknij.ImageAlign = ContentAlignment.MiddleLeft;
            btnZamknij.ImageKey = "close.png";
            btnZamknij.ImageList = imageList1;
            btnZamknij.Location = new Point(1371, 693);
            btnZamknij.Name = "btnZamknij";
            btnZamknij.Size = new Size(135, 40);
            btnZamknij.TabIndex = 5;
            btnZamknij.Text = "Zamknij";
            btnZamknij.UseVisualStyleBackColor = true;
            btnZamknij.Click += btnZamknij_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(34, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1472, 111);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(15, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 86);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(492, 40);
            label1.Name = "label1";
            label1.Size = new Size(444, 32);
            label1.TabIndex = 0;
            label1.Text = "Aplikacja do zarządzania TourDePologne";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(btnFiltr);
            panel2.Controls.Add(txtFiltr);
            panel2.Controls.Add(label2);
            panel2.ForeColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(34, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(1472, 42);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 5);
            label2.Name = "label2";
            label2.Size = new Size(66, 32);
            label2.TabIndex = 0;
            label2.Text = "Filtry";
            // 
            // txtFiltr
            // 
            txtFiltr.Anchor = AnchorStyles.Left;
            txtFiltr.Location = new Point(81, 14);
            txtFiltr.Margin = new Padding(4);
            txtFiltr.Name = "txtFiltr";
            txtFiltr.Size = new Size(159, 23);
            txtFiltr.TabIndex = 9;
            // 
            // btnFiltr
            // 
            btnFiltr.ImageKey = "6827633_advertising_business_filter_funnel_marketing_icon (1).png";
            btnFiltr.ImageList = imageList1;
            btnFiltr.Location = new Point(263, 3);
            btnFiltr.Name = "btnFiltr";
            btnFiltr.Size = new Size(52, 36);
            btnFiltr.TabIndex = 10;
            btnFiltr.UseVisualStyleBackColor = true;
            btnFiltr.Click += btnFiltr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1554, 754);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnZamknij);
            Controls.Add(btnUsun);
            Controls.Add(btnEdytuj);
            Controls.Add(btnDodaj);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Aplikacja do zarządzania TourDePologne";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kolarzBindSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btnDodaj;
        private Button btnEdytuj;
        private Button btnUsun;
        private Button btnZamknij;
        private ImageList imageList1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private BindingSource kolarzBindSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewCheckBoxColumn wpisoweDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn wiekDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rankingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private Panel panel2;
        private Label label2;
        private TextBox txtFiltr;
        private Button btnFiltr;
    }
}