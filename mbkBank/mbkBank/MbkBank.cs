using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mbkBank.Abstract;
using mbkBank.Concrete;
using mbkBank.ExceptionLibrary;
using mbkBank.Interface;

namespace mbkBank
{
    public partial class MbkBank : Form
    {
        #region Fields

        private readonly List<KagitPara> KagitParalar;
        private readonly List<BozukPara> BozukParalar;

        Kumbara kumbara;
        Para secilenPara;
        bool katlandiMi = false;
        double toplamMinHacim = 0;
        double toplamFazlaHacim = 0;
        double katlanmisParaHacmi = 0;
        int kumbaraKirilmaSayisi = 0;
        double kumbaraKalanHacim = 75000;

        #endregion
        #region Constructor

        public MbkBank()
        {
            InitializeComponent();
            if (KagitParalar == null)
            {
                KagitParalar = new List<KagitPara>();
            }

            if (BozukParalar == null)
            {
                BozukParalar = new List<BozukPara>();
            }

            if (kumbara == null)
            {
                kumbara = new Kumbara(75000);
            }

        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBozukPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            string atilacakPara = string.Empty;
            if (cbBozukPara.SelectedIndex > 0)
            {
                cbKagitPara.Enabled = false;
                buttonKatla.Enabled = false;
                atilacakPara = cbBozukPara.SelectedItem.ToString();
                foreach (var item in BozukParalar)
                {
                    if (atilacakPara == item.Ad)
                    {
                        secilenPara = item;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MbkBank_Load(object sender, EventArgs e)
        {
            BozukParalar.Add(new BozukPara() { Ad = "1 Kuruş", Miktar = 0.01, Cap = 16.50, Yukseklik = 1.35 });
            BozukParalar.Add(new BozukPara() { Ad = "5 Kuruş", Miktar = 0.05, Cap = 17.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "10 Kuruş", Miktar = 0.10, Cap = 18.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "25 Kuruş", Miktar = 0.25, Cap = 20.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "50 Kuruş", Miktar = 0.50, Cap = 23.85, Yukseklik = 1.90 });
            BozukParalar.Add(new BozukPara() { Ad = "1 Lira", Miktar = 1.0, Cap = 26.15, Yukseklik = 1.90 });

            KagitParalar.Add(new KagitPara() { Ad = "5 Lira", Miktar = 5.0, En = 64.0, Boy = 130.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "10 Lira", Miktar = 10.0, En = 64.0, Boy = 136.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "20 Lira", Miktar = 20.0, En = 68.0, Boy = 142.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "50 Lira", Miktar = 50.0, En = 68.0, Boy = 148.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "100 Lira", Miktar = 100.0, En = 72.0, Boy = 154.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "200 Lira", Miktar = 200.0, En = 72.0, Boy = 160.0, Yukseklik = 0.25 });

            cbKagitPara.Items.Add("Seçiniz");
            foreach (var item in KagitParalar)
            {
                cbKagitPara.Items.Add(item.Ad);
            }
            cbKagitPara.SelectedIndex = 0;

            cbBozukPara.Items.Add("Seçiniz");
            foreach (var item in BozukParalar)
            {
                cbBozukPara.Items.Add(item.Ad);
            }
            cbBozukPara.SelectedIndex = 0;
            buttonKatla.Enabled = false;
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonKir_Click(object sender, EventArgs e)
        {
            try
            {
                kumbaraKirilmaSayisi += 1;
                kumbaraKalanHacim = 75000;
                
                
                kalanHacim.Text = kumbaraKalanHacim.ToString();
                if (kumbaraKirilmaSayisi > 1)
                {
                    BackgroundImage = mbkBank.Properties.Resources.banka2;
                    MessageBox.Show("Kumbara tekrar kullanılamayacak şekilde kırıldı.İçinden "+ kumbara.BirikenParaMiktari + " TL çıktı. Güle güle harcayın.");
                    kalanHacim.Text = "0";
                    buttonKir.Enabled = false;
                    

                    return;

                }
                string message = "Kumbarayı kırdınız. İçinden " + kumbara.BirikenParaMiktari + " TL çıktı. Güle güle harcayın.";
                MessageBox.Show(message);
                if (kumbaraKirilmaSayisi < 2)
                {
                    //lbKumbara.Items.Clear();
                    var paralar = kumbara.Break();

                    if (paralar == null)
                    {
                        throw new KumbaradaParaYok();
                    }

                    

                    //foreach (var item in paralar)
                    //{
                    //    lbKumbara.Items.Add(item.Ad);
                    //}

                    if (kumbara != null)
                    {
                        kumbara = new Kumbara(75000);
                    }
                    toplamPara.Text = string.Concat(kumbara.BirikenParaMiktari.ToString(), " TL");
                }

                else
                {
                    throw new MaxBirKereKiril();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonKir.Enabled = false;
        }

        private void buttonParaAt_Click(object sender, EventArgs e)
        {
            try
            {
                if (kumbaraKirilmaSayisi > 1)
                {
                    throw new KumbaraYok();
                }
                double hacim = 0, fazlaHacim = 0;

                //if (lbKumbara.Items.Count > 0)
                //{
                //    lbKumbara.Items.Clear();
                //}

                if (secilenPara == null)
                {
                    throw new ParaSecimiYapilmadi();
                }

                if (secilenPara is BozukPara)
                {
                    BozukPara bozukPara = (BozukPara)secilenPara;
                    hacim = bozukPara.Hacim();
                    fazlaHacim = bozukPara.FazladanHacimEkle(hacim);

                    if (kumbara.BirikenHacim + hacim + fazlaHacim > kumbara.KumbaraHacmi)
                    {
                        throw new KumbaraDoldu();
                    }

                    toplamFazlaHacim += fazlaHacim;
                    kumbara.BirikenHacim += hacim + fazlaHacim;
                    toplamMinHacim += bozukPara.MinHacimHesapla(hacim);

                    kumbara.ParaEkle(bozukPara);

                }
                else if (secilenPara is KagitPara)
                {
                    KagitPara kagitPara = (KagitPara)secilenPara;

                    if (katlandiMi == false)
                    {
                        throw new ParaKatla();
                    }

                    hacim = katlanmisParaHacmi;
                    fazlaHacim = kagitPara.FazladanHacimEkle(hacim);

                    if (kumbara.BirikenHacim + hacim + fazlaHacim > kumbara.KumbaraHacmi)
                    {
                        throw new KumbaraDoldu();
                    }

                    toplamFazlaHacim += fazlaHacim;
                    kumbara.BirikenHacim += hacim + fazlaHacim;
                    toplamMinHacim += kagitPara.MinHacimHesapla(hacim);

                    kumbara.ParaEkle(kagitPara);
                }
                else
                {
                    MessageBox.Show("Seçilen para türü bulunamadı");
                }

                katlandiMi = false;
                cbBozukPara.Enabled = true;
                cbKagitPara.Enabled = true;
                buttonKatla.Enabled = true;
                cbBozukPara.SelectedIndex = 0;
                cbKagitPara.SelectedIndex = 0;
                toplamPara.Text = string.Concat(kumbara.BirikenParaMiktari.ToString(), " TL");
                HacimYazdir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            button1.Enabled = true;
            buttonKir.Enabled = true;
        }

        private void HacimYazdir()
        {
            //lblFazlaHacim.Text = toplamFazlaHacim.ToString();
            kalanHacim.Text = (kumbaraKalanHacim - kumbara.BirikenHacim).ToString();
            
            
        }

        private void buttonSalla_Click(object sender, EventArgs e)
        {
            if (kumbara.BirikenHacim > toplamFazlaHacim && toplamFazlaHacim > 0)
            {
                toplamFazlaHacim = 0;
                kumbara.Shake(toplamMinHacim);
                HacimYazdir();
            }
            button1.Enabled = false;
        }

        private void cbKagitPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonKatla.Enabled = true;
            string atilacakPara = string.Empty;
            if (cbKagitPara.SelectedIndex > 0)
            {
                cbBozukPara.Enabled = false;
          
                atilacakPara = cbKagitPara.SelectedItem.ToString();
                foreach (var item in KagitParalar)
                {
                    if (atilacakPara == item.Ad)
                    {
                        secilenPara = item;
                    }
                }
            }
        }

        private void buttonKatla_Click(object sender, EventArgs e)
        {
            KagitPara katlanacak = (KagitPara)secilenPara;
            if (katlanacak != null)
            {
                katlandiMi = true;
                katlanmisParaHacmi = katlanacak.Katla(katlanacak.Hacim());
            }
        }

        private void kalanHacim_TextChanged(object sender, EventArgs e)
        {

        }

        private void toplamPara_TextChanged(object sender, EventArgs e)
        {

        }

        private void pb_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
