using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra_Wisielec
{
    public partial class Szubienica : Form
    {
        public Szubienica()
        {
            InitializeComponent();
        }
        Rozgrywka MojaRozgrywka;
        public Szubienica(Rozgrywka rozgrywka)
        {
            InitializeComponent();
            MojaRozgrywka = rozgrywka;

        }

        public byte UstawPoziom;
        public string NapisPoziom;
       
        private void Trudnosc()
        {
            if (UstawPoziom == 1)
                NapisPoziom = "łatwy";
            else if (UstawPoziom == 2)
                NapisPoziom = "średni";
            else
                NapisPoziom = "trudny";
        }

        private void BtnWyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void BtnGraj_Click(object sender, EventArgs e)
        {
            Trudnosc();
            Rozgrywka rozgrywka = new Rozgrywka(this);
            this.Visible = false;
            rozgrywka.Owner = this;
            rozgrywka.ShowDialog();
        }

        private void BtnSredni_MouseDown(object sender, MouseEventArgs e)
        {
            UstawPoziom = 2;
        }

        private void BtnLatwy_MouseDown(object sender, MouseEventArgs e)
        {
            UstawPoziom = 1;
        }

        private void BtnTrudny_MouseDown(object sender, MouseEventArgs e)
        {
            UstawPoziom = 3;
        }
    }
}
