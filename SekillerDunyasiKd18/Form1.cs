using System.Drawing.Imaging;

namespace SekillerDunyasiKd18
{
    public partial class Form1 : Form
    {
        List<ICizilebilir> cizilebilirler = new List<ICizilebilir>();
        readonly Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void pnlCizim_Paint(object sender, PaintEventArgs e)
        {
            foreach (var cizilebilir in cizilebilirler)
                cizilebilir.Ciz(e.Graphics);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sekil s;

            switch (cboTur.SelectedItem?.ToString())
            {
                case "Dikd�rtgen":
                    s = new Dikdortgen();
                    break;
                case "Elips":
                    s = new Elips();
                    break;
                default:
                    MessageBox.Show("L�tfen bir �ekil se�iniz.");
                    return;
            }
            s.X = (int)nudX.Value;
            s.Y = (int)nudY.Value;
            s.Genislik = (int)nudGenislik.Value;
            s.Yukseklik = (int)nudYukseklik.Value;
            s.Renk = pboRenk.BackColor;
            cizilebilirler.Add(s);
            CizilebilirleriListele();
            lstSekiller.SelectedItem = s;
        }

        private void CizilebilirleriListele()
        {
            lstSekiller.Items.Clear();

            foreach (ICizilebilir cizilebilir in cizilebilirler)
            {
                lstSekiller.Items.Add(cizilebilir);
            }

            pnlCizim.Refresh();
        }

        private void pboRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pboRenk.BackColor = colorDialog1.Color;
        }

        private void btnRastgeleEkle_Click(object sender, EventArgs e)
        {
            int mx = (int)pnlCizim.Width; // max X
            int my = (int)pnlCizim.Height; // max Y
            int mw = (int)pnlCizim.Width; // max width
            int mh = (int)pnlCizim.Height; // max height
            int sc = (int)cboTur.Items.Count; // shapes count
            int mc = 256; // max color
            int x, y;

            nudX.Value = x = rnd.Next(mx);
            nudY.Value = y = rnd.Next(my);
            nudGenislik.Value = rnd.Next(mw - x);
            nudYukseklik.Value = rnd.Next(mh - y);
            pboRenk.BackColor = Color.FromArgb(rnd.Next(mc), rnd.Next(mc),
                rnd.Next(mc), rnd.Next(mc)); // alpha red green blue
            cboTur.SelectedIndex = rnd.Next(sc);
            btnEkle.PerformClick();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cizilebilirler.Clear();
            CizilebilirleriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;
            if (sid == -1) return;
            cizilebilirler.RemoveAt(sid);
            CizilebilirleriListele();
            lstSekiller.SelectedIndex = Math.Min(sid, cizilebilirler.Count - 1);
        }

        void SeciliyiTasi(int hedefIndeks)
        {
            if (lstSekiller.SelectedItem == null || hedefIndeks < 0 || hedefIndeks >= cizilebilirler.Count)
                return;

            ICizilebilir secili = (ICizilebilir)lstSekiller.SelectedItem;
            cizilebilirler.Remove(secili);
            cizilebilirler.Insert(hedefIndeks, secili);
            CizilebilirleriListele();
            lstSekiller.SelectedItem = secili;
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            SeciliyiTasi(lstSekiller.SelectedIndex - 1);
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            SeciliyiTasi(lstSekiller.SelectedIndex + 1);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pnlCizim.Width, pnlCizim.Height);
            pnlCizim.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            bmp.Save(masaustuYolu + @"\deneme.png", ImageFormat.Png);
        }

        private void btnMetinEkle_Click(object sender, EventArgs e)
        {
            Yazi yazi = new Yazi((int)nudX.Value, (int)nudY.Value, txtMetin.Text, pboRenk.BackColor);
            cizilebilirler.Add(yazi);
            CizilebilirleriListele();
        }
    }
}