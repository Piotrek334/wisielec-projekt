using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace gra_Wisielec
{
    public partial class Rozgrywka : Form
    {
        private Image[] HangImages = { gra_Wisielec.Properties.Resources.s0, gra_Wisielec.Properties.Resources.s1, gra_Wisielec.Properties.Resources.s2,
                                       gra_Wisielec.Properties.Resources.s3, gra_Wisielec.Properties.Resources.s4, gra_Wisielec.Properties.Resources.s5,
                                       gra_Wisielec.Properties.Resources.s6, gra_Wisielec.Properties.Resources.s7, gra_Wisielec.Properties.Resources.s8,
                                       gra_Wisielec.Properties.Resources.s9};
        private int ZlyWybor = 0;
        private string[] Wyraz;
        private string[] Latwy;
        private string[] Sredni;
        private string[] Trudny;
        private string Current = "";
        private string CopyCurrent = "";

        public Rozgrywka()
        {
            InitializeComponent();
           
        }
        Szubienica MojaRozgrywka;
        Szubienica szubienica;
        public Rozgrywka(Szubienica szubienica)
        {
            this.szubienica = szubienica;
            InitializeComponent();
            MojaRozgrywka = szubienica;
            
        }
        
        public void przyciskiON()
        {
            A.Enabled = true;
            Ą.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            Ć.Enabled = true;
            D.Enabled = true;
            E.Enabled = true;
            Ę.Enabled = true;
            F.Enabled = true;
            G.Enabled = true;
            H.Enabled = true;
            I.Enabled = true;
            J.Enabled = true;
            K.Enabled = true;
            L.Enabled = true;
            Ł.Enabled = true;
            M.Enabled = true;
            N.Enabled = true;
            Ń.Enabled = true;
            O.Enabled = true;
            Ó.Enabled = true;
            P.Enabled = true;
            Q.Enabled = true;
            R.Enabled = true;
            S.Enabled = true;
            Ś.Enabled = true;
            T.Enabled = true;
            U.Enabled = true;
            V.Enabled = true;
            W.Enabled = true;
            X.Enabled = true;
            Y.Enabled = true;
            Z.Enabled = true;
            Ź.Enabled = true;
            Ż.Enabled = true;

            A.BackColor = Color.White;
            Ą.BackColor = Color.White;
            B.BackColor = Color.White;
            C.BackColor = Color.White;
            Ć.BackColor = Color.White;
            D.BackColor = Color.White;
            E.BackColor = Color.White;
            Ę.BackColor = Color.White;
            F.BackColor = Color.White;
            G.BackColor = Color.White;
            H.BackColor = Color.White;
            I.BackColor = Color.White;
            J.BackColor = Color.White;
            K.BackColor = Color.White;
            L.BackColor = Color.White;
            Ł.BackColor = Color.White;
            M.BackColor = Color.White;
            N.BackColor = Color.White;
            Ń.BackColor = Color.White;
            O.BackColor = Color.White;
            Ó.BackColor = Color.White;
            P.BackColor = Color.White;
            Q.BackColor = Color.White;
            R.BackColor = Color.White;
            S.BackColor = Color.White;
            Ś.BackColor = Color.White;
            T.BackColor = Color.White;
            U.BackColor = Color.White;
            V.BackColor = Color.White;
            W.BackColor = Color.White;
            X.BackColor = Color.White;
            Y.BackColor = Color.White;
            Z.BackColor = Color.White;
            Ź.BackColor = Color.White;
            Ż.BackColor = Color.White;
        }
        public void przyciskiOFF()
        {
            A.Enabled = false;
            Ą.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            Ć.Enabled = false;
            D.Enabled = false;
            E.Enabled = false;
            Ę.Enabled = false;
            F.Enabled = false;
            G.Enabled = false;
            H.Enabled = false;
            I.Enabled = false;
            J.Enabled = false;
            K.Enabled = false;
            L.Enabled = false;
            Ł.Enabled = false;
            M.Enabled = false;
            N.Enabled = false;
            Ń.Enabled = false;
            O.Enabled = false;
            Ó.Enabled = false;
            P.Enabled = false;
            Q.Enabled = false;
            R.Enabled = false;
            S.Enabled = false;
            Ś.Enabled = false;
            T.Enabled = false;
            U.Enabled = false;
            V.Enabled = false;
            W.Enabled = false;
            X.Enabled = false;
            Y.Enabled = false;
            Z.Enabled = false;
            Ź.Enabled = false;
            Ż.Enabled = false;
        }

        private void Rozgrywka_FormClosing(object sender, FormClosingEventArgs e)
        {
            MojaRozgrywka.Visible = true;
        }
        private void PobierzWyraz()
        {
            char[] Separator = { ',' };
            string[] readText = File.ReadAllLines("wyrazy.txt");
            Wyraz = new string[readText.Length];
            int index = 0;
            foreach (string s in readText)
            {
                string[] line = s.Split(Separator);
                Wyraz[index++] = line[1];
            }
        }

        private void UstawWyraz()
        {
            ZlyWybor = 0;
            ObrazSzubienica.Image = HangImages[ZlyWybor];
            if (szubienica.UstawPoziom == 1)
            {
                int WyrazIndex = (new Random()).Next(Latwy.Length);
                Current = Latwy[WyrazIndex];
            }
            else if (szubienica.UstawPoziom == 2)
            {
                int WyrazIndex = (new Random()).Next(Sredni.Length);
                Current = Sredni[WyrazIndex];
            }
            else
            {
                int WyrazIndex = (new Random()).Next(Trudny.Length);
                Current = Trudny[WyrazIndex];
            }
            CopyCurrent = "";

            for(int index=0; index<Current.Length; index++)
            {
                CopyCurrent += "_";
            }
            WyswietlUkrytyWyraz();
        }

        private void WyswietlUkrytyWyraz()
        {
            LblPokazWyraz.Text = "";
            for (int index = 0; index < CopyCurrent.Length; index++)
            {
                LblPokazWyraz.Text += CopyCurrent.Substring(index, 1);
                LblPokazWyraz.Text += " ";
            }
        }

        private void RozdzielWyraz()
        {
            int i = 0;
            int j = 0;
            int n = 0;
            int i1 = 0;
            int j1 = 0;
            int n1 = 0;

            for (int index = 0; index < Wyraz.Length; index++)
            {

                string Tmp = Wyraz[index];

                if (Tmp.Length < 8)
                {
                    i++;
                }
                else if (Tmp.Length > 7 && Tmp.Length < 11)
                {
                    j++;
                }
                else
                {
                    n++;
                }
            }

            Latwy = new string[i];
            Sredni = new string[j];
            Trudny = new string[n];


            for (int index = 0; index < Wyraz.Length; index++ )
            {
                string Tmp = Wyraz[index];

                if (Tmp.Length < 8)
                {
                    Latwy[i1] = Tmp;
                    i1++;
                }
                else if (Tmp.Length > 7 && Tmp.Length < 11)
                {
                    Sredni[j1] = Tmp;
                    j1++;
                }
                else
                {
                    Trudny[n1] = Tmp;
                    n1++;
                }
            }
        }

        private void WspolnyPrzycisk(object sender, EventArgs e)
        {
            Button choice = sender as Button;
            choice.Enabled = false;
            if(Current.Contains(choice.Text))
            {
                char[] tmp = CopyCurrent.ToCharArray();
                char[] znajdz = Current.ToCharArray();
                char GuessChar = choice.Text.ElementAt(0);
                for(int index = 0; index < znajdz.Length; index++)
                {
                    if(znajdz[index] == GuessChar)
                    {
                        tmp[index] = GuessChar;
                    }

                }
                CopyCurrent = new string(tmp);
                WyswietlUkrytyWyraz();
                choice.BackColor = Color.Green;

            }
            else
            {
                ZlyWybor++;
                choice.BackColor = Color.Red;
            }

            if (ZlyWybor < 10)
            {
                ObrazSzubienica.Image = HangImages[ZlyWybor];
            }
            if(ZlyWybor==9)
            {                
                LblWynik.Text = "Przegrałeś!!!!";
                WyrazPrzegrana.Text = " Wylosowany wyraz to: " + Current;
                przyciskiOFF();
                BtnExit.Visible = true;
                BtnRestart.Visible = true;
                WyrazPrzegrana.Visible = true;
                ZmienTrudnosc.Visible = true;
            }

            if (CopyCurrent.Equals(Current))
            {
                LblWynik.Text = "Wygrałeś!!!!";
                przyciskiOFF();
                BtnExit.Visible = true;
                BtnRestart.Visible = true;
                WyrazPrzegrana.Visible = true;
                ZmienTrudnosc.Visible = true;
            }
        }

        private void Rozgrywka_Load(object sender, EventArgs e)
        {
            WybranyPoziom.Text = "wybraleś " + szubienica.NapisPoziom + " poziom trudności";
            PobierzWyraz();
            RozdzielWyraz();
            UstawWyraz();
            BtnExit.Visible = false;
            BtnRestart.Visible = false;
            ZmienTrudnosc.Visible = false;
            WyrazPrzegrana.Visible = false;
        }

        private void WybranyPoziom_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            UstawWyraz();
            LblWynik.Text = "";
            WyrazPrzegrana.Text = "";
            przyciskiON();
            BtnExit.Visible = false;
            BtnRestart.Visible = false;
            ZmienTrudnosc.Visible = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ZmienTrudnosc_Click(object sender, EventArgs e)
        {
            Szubienica szubienica1 = new Szubienica(this);
            this.Visible = false;
            szubienica1.Owner = this;
            szubienica1.ShowDialog();
        }
    }
}
