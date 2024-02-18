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
    public partial class CharacterIzbornik : Form
    {
        public CharacterIzbornik()
        {
            InitializeComponent();
        }

        private void CharacterIzbornik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Igrica igrica = new Igrica();
            igrica.avion.Image = Properties.Resources.avion;
            igrica.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Igrica igrica = new Igrica();
            igrica.avion.Image = Properties.Resources.Ship1;
            igrica.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Igrica igrica = new Igrica();
            igrica.avion.Image = Properties.Resources.Ship2;
            igrica.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Igrica igrica = new Igrica();
            igrica.avion.Image = Properties.Resources.Ship3;
            igrica.Show();
            this.Hide();
        }
    }
}
