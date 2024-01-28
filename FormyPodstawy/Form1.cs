namespace FormyPodstawy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kolarzBindSource.DataSource = Program.listaKolarzy;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        #region Metody odpowiadajace za dane
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DialogKolarz dlg = new DialogKolarz(new Kolarz());
            dlg.ShowDialog();
            Pliki.zapiszPlik();
            Refreshing();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            var wybrany = (Kolarz)kolarzBindSource.Current;
            DialogKolarz dlg = new DialogKolarz(wybrany);
            dlg.ShowDialog();
            Pliki.zapiszPlik();
            Refreshing();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            var kolarzDoUsuniecia = (Kolarz)kolarzBindSource.Current;
            if (kolarzDoUsuniecia != null)
            {
                Program.listaKolarzy.Remove(kolarzDoUsuniecia);
                Pliki.zapiszPlik();
                Refreshing();
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void Form1_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Za³adowano dane");//
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kolarzBindSource;
            Refreshing();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kolarzBindSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltr_Click(object sender, EventArgs e)
        {
            kolarzBindSource.DataSource = Program.listaKolarzy.OrderBy(k=>k.Id).Where(k => k.Nazwisko.StartsWith(txtFiltr.Text));
            kolarzBindSource.Filter = "Nazwisko = 'Gr'";
            Refreshing();
        }

        public void Refreshing()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kolarzBindSource;
        }
    }
}