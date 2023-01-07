using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sutcift
{
    public partial class Dashboard : Form
    {
        DB_SUTEntities2 sut = new DB_SUTEntities2();
        public Dashboard()
        {
            InitializeComponent();

            List<Tb_inek> list_inek = sut.Tb_inek.ToList();
            lbinekler.Text = list_inek.Count.ToString();
            List<Tb_Sut> list_sut = sut.Tb_Sut.ToList();
            lbsütüretimi.Text = list_sut.Count.ToString();
            List<Tb_Sağlık> list_sağlık = sut.Tb_Sağlık.ToList();
            lbsağlık.Text = list_sağlık.Count.ToString();
            List<Tb_ırkı> list_ırkı = sut.Tb_ırkı.ToList();
            lbırkı.Text = list_ırkı.Count.ToString();
            List<Tb_Satışı> list_satışı = sut.Tb_Satışı.ToList();
            lbsütsatışı.Text = list_satışı.Count.ToString();
            List<Tb_Harcamalar> list_harcamalar = sut.Tb_Harcamalar.ToList();
            lbharcamalar.Text = list_harcamalar.Count.ToString();
            List<Tb_Gelirler> list_gelir = sut.Tb_Gelirler.ToList();
            lbgelirler.Text = list_gelir.Count.ToString();
            List<Tb_Çalışanlar> list_çalışanlar = sut.Tb_Çalışanlar.ToList();
            lbçalışanlar.Text = list_çalışanlar.Count.ToString();
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            inekler B = new inekler();
            B.Show();
            this.Hide();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            Finans B = new Finans();
            B.Show();
            this.Hide();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            saglik_rapotu B = new saglik_rapotu();
            B.Show();
            this.Hide();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ırkı B = new ırkı();
            B.Show();
            this.Hide();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            sut_satisi B = new sut_satisi();
            B.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            sut_uretimi B = new sut_uretimi();
            B.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            inekler B = new inekler();
            B.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            sut_uretimi B = new sut_uretimi();
            B.Show();
            this.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            saglik_rapotu B = new saglik_rapotu();
            B.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ırkı B = new ırkı();
            B.Show();
            this.Hide();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            sut_satisi B = new sut_satisi();
            B.Show();
            this.Hide();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Finans B = new Finans();
            B.Show();
            this.Hide();
        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            çalışanlar B = new çalışanlar();
            B.Show();
            this.Hide();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbinekler_Click(object sender, EventArgs e)
        {

        }
    }
} 
