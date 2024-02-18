using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Zavrsni
{
    public partial class Igrica : Form
    {
        int brzinaMeteora;
        int brzinaAviona = 16;
        int rezultat;
        public static Igrica instancaIgrice;

        Random pozicijaMeteora = new Random();

        bool Lijevo, Desno, Gore, Dolje;
        public Igrica()
        {
            InitializeComponent();
            ponoviIgru();
            instancaIgrice = this;
        }

        private void TipkaPritisnuta(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) {
                Lijevo = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                Desno = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                Gore = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                Dolje = true;
            }

        }

        private void TipkaPustena(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Lijevo = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                Desno = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                Gore = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                Dolje = false;
            }
        }

        private void TimerIgreEvent(object sender, EventArgs e)
        {
            rezultatTXT.Text = "Rezultat: " + (rezultat+1);
            rezultat++;

            if (Lijevo == true && avion.Left > 20) {
                avion.Left -= brzinaAviona;            
            }

            if (Desno == true && avion.Left < 650)
            {
                avion.Left += brzinaAviona;
            }

            if (Gore == true && avion.Top > 0)
            {
                avion.Top -= brzinaAviona;
            }
            if (Dolje == true && avion.Top + avion.Height < this.ClientSize.Height - 70)
            {
                avion.Top += brzinaAviona;
            }


            Meteor1.Top += brzinaMeteora;
            Meteor2.Top += brzinaMeteora;
            Meteor3.Top += brzinaMeteora;
            Meteor4.Top += brzinaMeteora;


            if (Meteor1.Top > 1000) {
                MeteorPozicija(Meteor1);
            }
            if (Meteor2.Top > 1000)
            {
                MeteorPozicija(Meteor2);
            }
            if (Meteor3.Top > 1000)
            {
                MeteorPozicija(Meteor3);
            }
            if (Meteor4.Top > 1000)
            {
                MeteorPozicija(Meteor4);
            }



            if (avion.Bounds.IntersectsWith(Meteor1.Bounds) || avion.Bounds.IntersectsWith(Meteor2.Bounds) || 
                avion.Bounds.IntersectsWith(Meteor3.Bounds) || avion.Bounds.IntersectsWith(Meteor4.Bounds)) {
                ZavrsenaIgra();
            }


        }


        private void resetGame(object sender, EventArgs e)
        {
            ponoviIgru();
        }

        private void igricaZatvorena(object sender, FormClosedEventArgs e)
        {
            StartIzbornik startIzbornik = new StartIzbornik();
            startIzbornik.Show();
        }

        private void tipkaNazad(object sender, EventArgs e)
        {
            this.Close();
            StartIzbornik startIzbornik = new StartIzbornik();
        }

        private void Igrica_Load(object sender, EventArgs e)
        {

        }

        private void MeteorPozicija(PictureBox meteorT) {
            meteorT.Top = pozicijaMeteora.Next(200, 500) * -1;

            if ((string)meteorT.Tag == "prviMeteor") { 
                meteorT.Left = pozicijaMeteora.Next(0, 140);
            }

            if ((string)meteorT.Tag == "drugiMeteor")
            {
                meteorT.Left = pozicijaMeteora.Next(160, 300);
            }

            if ((string)meteorT.Tag == "treciMeteor")
            {
                meteorT.Left = pozicijaMeteora.Next(320, 460);
            }
            if ((string)meteorT.Tag == "cetvrtiMeteor")
            {
                meteorT.Left = pozicijaMeteora.Next(480, 650);
            }


        }

        private void ZavrsenaIgra()
        {
            GameTimer.Stop();

            gameOverBox.Show();
            restartTipka.Show();
            restartTipka.Enabled = true;

            TipkaNazad.Show();
            TipkaNazad.Enabled = true;

            rezultat2TXT.Text = "Tvoj rezultat: " + rezultat;

            string fileName = @"scorelog.txt";

            using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(rezultat); 
            }


            using (StreamReader sr = File.OpenText("scorelog.txt"))
            {
                List<string> lista1 = new List<string>();

                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    lista1.Add(s);
                }
                List<int> lista2 = lista1.Select(int.Parse).ToList();
                int najveci_element;
                lista2.Sort();
                najveci_element = lista2.Last();


                highScoreTXT.Text = "Najbolji rezultat: " + najveci_element;


            }
        }




            private void ponoviIgru() {

            rezultat = 0;
            restartTipka.Enabled = false;
            restartTipka.Hide();
            TipkaNazad.Enabled = false;
            TipkaNazad.Hide();
            gameOverBox.Hide();

            Lijevo = false;
            Desno = false;

            brzinaMeteora = 15;


            Meteor1.Top = pozicijaMeteora.Next(200, 500) * -1;
            Meteor1.Left = pozicijaMeteora.Next(0, 140);

            Meteor2.Top = pozicijaMeteora.Next(200, 500) * -1;
            Meteor2.Left = pozicijaMeteora.Next(160, 300);

            Meteor3.Top = pozicijaMeteora.Next(200, 500) * -1;
            Meteor3.Left = pozicijaMeteora.Next(320, 460);

            Meteor4.Top = pozicijaMeteora.Next(200, 500) * -1;
            Meteor4.Left = pozicijaMeteora.Next(480, 650);


            GameTimer.Start();
        } 
    }
}
