using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Zavrsni
{
    public partial class StartIzbornik : Form
    {
        public static StartIzbornik instanca;
        public StartIzbornik()
        {
            InitializeComponent();
            instanca = this;
        }

        private void StartGame(object sender, EventArgs e)
        {
            CharacterIzbornik odabir = new CharacterIzbornik();
            odabir.Show();
            this.Hide();

        }

        private void startIzbornikZatvoren(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void zatvoriTipka(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pomocTipka(object sender, EventArgs e)
        {
            Pomoc pomocWindow = new Pomoc();
            pomocWindow.Show();
            this.Hide();
        }

        
    }
}
