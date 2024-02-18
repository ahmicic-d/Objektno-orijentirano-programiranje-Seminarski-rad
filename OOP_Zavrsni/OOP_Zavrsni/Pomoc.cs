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
    public partial class Pomoc : Form
    {
        public Pomoc()
        {
            InitializeComponent();
        }

        private void pomocNazad(object sender, EventArgs e)
        {
            this.Hide();
            StartIzbornik startIzbornik = new StartIzbornik();
            startIzbornik.Show();
        }

        private void Zatvoren(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            StartIzbornik startIzbornik = new StartIzbornik();
            startIzbornik.Show();
        }
    }
}
