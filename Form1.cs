using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirKelimeBirİşlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int sayisayac = 0;
        int harfsayac = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnHarfUret.Enabled = false;
            BtnSayıÜret.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            harfsayac = 0;
            sayisayac = 0;

            BtnSayı1.Visible = false;
            BtnSayı2.Visible = false;
            BtnSayı3.Visible = false;
            BtnSayı4.Visible = false;
            BtnSayı5.Visible = false;
            BtnSayı6.Visible = false;
            BtnEsittir.Visible = false;
            BtnSoru.Visible = false;

            BtnHarf1.Visible = false;
            BtnHarf2.Visible = false;
            BtnHarf3.Visible = false;
            BtnHarf4.Visible = false;
            BtnHarf5.Visible = false;
            BtnHarf6.Visible = false;
            BtnHarf7.Visible = false;
            BtnHarf8.Visible = false;
            BtnJoker.Visible = false;
            BtnHarfUret.Enabled = true;
            BtnSayıÜret.Enabled = true;
        }

        private void BtnHarfUret_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            harfsayac++;
            string harf1, harf2, harf3, harf4, harf5, harf6, harf7, harf8;
            int harfler;
            string[] dizi = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };

            if(harfsayac==1)
            {
                harfler = rnd.Next(0, dizi.Length);
                harf1 = (dizi[harfler]);
                BtnHarf1.Text = harf1.ToString();
                BtnHarf1.Visible = true;  
            }

            if(harfsayac==2)
            {
                harfler = rnd.Next(0, dizi.Length);
                harf2 = (dizi[harfler]);
                BtnHarf2.Text = harf2.ToString();
                BtnHarf2.Visible = true;
            }

            if(harfsayac==3)
            {
                harfler = rnd.Next(0, dizi.Length);
                harf3 = (dizi[harfler]);
                BtnHarf3.Text = harf3.ToString();
                BtnHarf3.Visible = true;
            }

            if(harfsayac==4)
            {
                harfler = rnd.Next(0, dizi.Length);
                harf4 = (dizi[harfler]);
                BtnHarf4.Text = harf4.ToString();
                BtnHarf4.Visible = true;
            }

            if (harfsayac == 5)
            {
                harfler = rnd.Next(0, dizi.Length);
                harf5 = (dizi[harfler]);
                BtnHarf5.Text = harf5.ToString();
                BtnHarf5.Visible = true;
            }

            if (harfsayac == 6)
            {
                harfler = rnd.Next(0, dizi.Length);
                harf6 = (dizi[harfler]);
                BtnHarf6.Text = harf6.ToString();
                BtnHarf6.Visible = true;
            }

            if (harfsayac == 7)
            {
                harfler = rnd.Next(0, dizi.Length);
                harf7 = (dizi[harfler]);
                BtnHarf7.Text = harf7.ToString();
                BtnHarf7.Visible = true;
            }

            if (harfsayac == 8)
            {
                harfler = rnd.Next(0, dizi.Length);
                harf8 = (dizi[harfler]);
                BtnHarf8.Text = harf8.ToString();
                BtnHarf8.Visible = true;
                BtnJoker.Text = "?";
                BtnJoker.Visible = true;
                BtnHarfUret.Enabled = false;

            }



        }

        private void BtnSayıÜret_Click(object sender, EventArgs e)
        {
            sayisayac++;
            string sayı1, sayı2, sayı3, sayı4, sayı5, sayı6;
            int sayı7;
            int sayilar;
            string[] dizi2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] dizi3 = { "50", "60", "75" };

            if(sayisayac==1)
            {
                sayilar = rnd.Next(0, dizi2.Length);
                sayı1 = (dizi2[sayilar]);
                BtnSayı1.Text = sayı1.ToString();
                BtnSayı1.Visible = true;
            }

            if(sayisayac==2)
            {
                sayilar = rnd.Next(0, dizi2.Length);
                sayı2 = (dizi2[sayilar]);
                BtnSayı2.Text = sayı2.ToString();
                BtnSayı2.Visible = true;
            }

            if(sayisayac==3)
            {
                sayilar = rnd.Next(0, dizi2.Length);
                sayı3 = (dizi2[sayilar]);
                BtnSayı3.Text = sayı3.ToString();
                BtnSayı3.Visible = true;
            }

            if(sayisayac==4)
            {
                sayilar = rnd.Next(0, dizi2.Length);
                sayı4 = (dizi2[sayilar]);
                BtnSayı4.Text = sayı4.ToString();
                BtnSayı4.Visible = true;
            }

            if(sayisayac==5)
            {
                sayilar = rnd.Next(0, dizi2.Length);
                sayı5 = (dizi2[sayilar]);
                BtnSayı5.Text = sayı5.ToString();
                BtnSayı5.Visible = true;
            }

            if(sayisayac==6)
            {
                sayilar = rnd.Next(0, dizi3.Length);
                sayı6 = (dizi3[sayilar]);
                BtnSayı6.Text = sayı6.ToString();
                BtnSayı6.Visible = true;
            }

            if(sayisayac==7)
            {
                sayı7 = rnd.Next(100, 500);
                BtnSoru.Text = sayı7.ToString();
                BtnEsittir.Visible = true;
                BtnSoru.Visible = true;
                BtnSayıÜret.Enabled = false;
                button1.Enabled = true;
            }

        }
    }
}
