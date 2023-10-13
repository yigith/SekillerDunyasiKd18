using System.Drawing.Imaging;

namespace SekillerDunyasiKd18
{
    public partial class Form1 : Form
    {
        List<Sekil> sekiller = new List<Sekil>();
        readonly Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void pnlCizim_Paint(object sender, PaintEventArgs e)
        {
            foreach (var sekil in sekiller)
                sekil.Ciz(e.Graphics);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sekil s;

            switch (cboTur.SelectedItem?.ToString())
            {
                case "Dikdörtgen":
                    s = new Dikdortgen();
                    break;
                case "Elips":
                    s = new Elips();
                    break;
                default:
                    MessageBox.Show("Lütfen bir þekil seçiniz.");
                    return;
            }
            s.X = (int)nudX.Value;
            s.Y = (int)nudY.Value;
            s.Genislik = (int)nudGenislik.Value;
            s.Yukseklik = (int)nudYukseklik.Value;
            s.Renk = pboRenk.BackColor;
            sekiller.Add(s);
            SekilleriListele();
            lstSekiller.SelectedItem = s;
        }

        private void SekilleriListele()
        {
            lstSekiller.Items.Clear();

            foreach (Sekil sekil in sekiller)
            {
                lstSekiller.Items.Add(sekil);
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
            sekiller.Clear();
            SekilleriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;
            if (sid == -1) return;
            sekiller.RemoveAt(sid);
            SekilleriListele();
            lstSekiller.SelectedIndex = Math.Min(sid, sekiller.Count - 1);
        }

        void SeciliyiTasi(int hedefIndeks)
        {
            if (lstSekiller.SelectedItem == null || hedefIndeks < 0 || hedefIndeks >= sekiller.Count)
                return;

            Sekil secili = (Sekil)lstSekiller.SelectedItem;
            sekiller.Remove(secili);
            sekiller.Insert(hedefIndeks, secili);
            SekilleriListele();
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
    }
}