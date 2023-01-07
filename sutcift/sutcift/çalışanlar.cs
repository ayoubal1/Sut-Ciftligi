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
    public partial class çalışanlar : Form
    {
        DB_SUTEntities2 sut = new DB_SUTEntities2();
        public çalışanlar()
        {
            InitializeComponent();
        }
        void list()
        {
            var çal = (from x in sut.Tb_Çalışanlar
                       select new
                       {
                           x.ÇaİD,
                           x.Adı,
                           x.Doğumtarihi,
                           x.Cinsiyet,
                           x.Telefon,
                           x.Adres,
                           x.Şifre
                           
                       }).ToList();
            gridControl1.DataSource = çal;

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (txtadıçal.Text == "" && datedoğumça.Text == "" && txtcinsiyetiça.Text == "" && txttefefonça.Text == "" && txtadresça.Text == "" && txtşifraça.Text == "" )
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (txtadıçal.Text == "")
            {
                MessageBox.Show("  Adı alanı boş..!!");
            }
            else if (datedoğumça.Text == "")
            {
                MessageBox.Show("Doğum Tarihi alanı boş..!!");
            }
            else if (txtcinsiyetiça.Text == "")
            {
                MessageBox.Show("Cinsiyeti alanı boş..!!");
            }
            else if (txttefefonça.Text == "")
            {
                MessageBox.Show("Telefon  alanı boş..!!");
            }
            else if (txtadresça.Text == "")
            {
                MessageBox.Show("Adres alanı boş..!!");
            }
            else if (txtşifraça.Text == "")
            {
                MessageBox.Show("Şifra alanı boş..!!");
            }
            else
            {
                Tb_Çalışanlar çal = new Tb_Çalışanlar();
                çal.Adı = txtadıçal.Text;
                çal.Doğumtarihi = datedoğumça.Text;
                çal.Cinsiyet = txtcinsiyetiça.Text;
                çal.Telefon = txttefefonça.Text;
                çal.Adres = txtadresça.Text;
                çal.Şifre = txtşifraça.Text;
                sut.Tb_Çalışanlar.Add(çal);
                sut.SaveChanges();
                MessageBox.Show("Çalışanlr  Bilgileri Eklendi !");
                list();
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if (txtadıçal.Text == "" && datedoğumça.Text == "" && txtcinsiyetiça.Text == "" && txttefefonça.Text == "" && txtadresça.Text == "" && txtşifraça.Text == "")
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (txtadıçal.Text == "")
            {
                MessageBox.Show("  Adı alanı boş..!!");
            }
            else if (datedoğumça.Text == "")
            {
                MessageBox.Show("Doğum Tarihi alanı boş..!!");
            }
            else if (txtcinsiyetiça.Text == "")
            {
                MessageBox.Show("Cinsiyeti alanı boş..!!");
            }
            else if (txttefefonça.Text == "")
            {
                MessageBox.Show("Telefon  alanı boş..!!");
            }
            else if (txtadresça.Text == "")
            {
                MessageBox.Show("Adres alanı boş..!!");
            }
            else if (txtşifraça.Text == "")
            {
                MessageBox.Show("Şifra alanı boş..!!");
            }
            else
            {
                int çaid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ÇaİD").ToString());
                var çal = sut.Tb_Çalışanlar.Find(çaid);
                çal.Adı = txtadıçal.Text;
                çal.Doğumtarihi = datedoğumça.Text;
                çal.Cinsiyet = txtcinsiyetiça.Text;
                çal.Telefon = txttefefonça.Text;
                çal.Adres = txtadresça.Text;
                çal.Şifre = txtşifraça.Text;
                sut.SaveChanges();
                MessageBox.Show("Çalışanlr  Bilgileri Eklendi !");
                list();
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int çaid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ÇaİD").ToString());
                var çal = sut.Tb_Çalışanlar.Find(çaid);
                sut.Tb_Çalışanlar.Remove(çal);
                sut.SaveChanges();
                MessageBox.Show("Ineğin Bilgileri Silindi !");
                list();
            }
        }

        private void çalışanlar_Load(object sender, EventArgs e)
        {
            list();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtadıçal.Text = gridView1.GetFocusedRowCellValue("Adı").ToString();
            datedoğumça.Text = gridView1.GetFocusedRowCellValue("Doğumtarihi").ToString();
            txtcinsiyetiça.Text = gridView1.GetFocusedRowCellValue("Cinsiyet").ToString();
            txttefefonça.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            txtadresça.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
            txtşifraça.Text = gridView1.GetFocusedRowCellValue("Şifre").ToString();
           
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

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Dashboard B = new Dashboard();
            B.Show();
            this.Hide();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
