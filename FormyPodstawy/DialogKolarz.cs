using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormyPodstawy
{
    public partial class DialogKolarz : Form
    {
        private int _id;
        public DialogKolarz(Kolarz _kolarz)
        {
            InitializeComponent();
            if (_kolarz.Id != 0)
            {
                _id = _kolarz.Id;
                wstawKolarza(_kolarz);
            }
            else
            {
                _kolarz.nowyNumer();
                _id = _kolarz.Id;
            }
        }

        private void wstawKolarza(Kolarz _kolarz)
        {
            txtImie.Text = _kolarz.Imie;
            txtNazwisko.Text = _kolarz.Nazwisko;
            txtTeam.Text = _kolarz.Team;
            txtEmail.Text = _kolarz.Email;
            checkWpisowe.Checked = _kolarz.Wpisowe;
            nmRanking.Value = _kolarz.Ranking;
            nmWiek.Value = _kolarz.Wiek;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DialogKolarz_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Kolarz nowyKolarz = new Kolarz();
            nowyKolarz.aktualizujID(_id);
            nowyKolarz.Imie = txtImie.Text;
            nowyKolarz.Nazwisko = txtNazwisko.Text;
            nowyKolarz.Team = txtTeam.Text;
            nowyKolarz.Email = txtEmail.Text;
            nowyKolarz.Wpisowe = checkWpisowe.Checked;
            nowyKolarz.Ranking = (int)nmRanking.Value;
            nowyKolarz.Wiek = (byte)nmWiek.Value;

            var kolarzDoUsuniecia = Program.listaKolarzy.FirstOrDefault(kl => kl.Id == _id);
            if (kolarzDoUsuniecia != null)
            {
                Program.listaKolarzy.Remove(kolarzDoUsuniecia);
            }
            Program.listaKolarzy.Add(nowyKolarz);
            
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
