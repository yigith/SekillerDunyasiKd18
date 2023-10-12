namespace SekillerDunyasiKd18
{
    public partial class Form1 : Form
    {
        List<Sekil> sekiller = new List<Sekil>();

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
    }
}