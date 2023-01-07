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
    public partial class sut_uretimi : Form
        
    {
        DB_SUTEntities2 sut = new DB_SUTEntities2();
        public sut_uretimi()
        {
            InitializeComponent();
        }
        void list()
        {
            var uret = (from x in sut.Tb_Sut
                       select new
                       {
                           x.SütİD,
                           x.İnekİD,
                           x.İnekAdı,
                           x.SabahSütü,
                           x.ÖğlenSütü,
                           x.AkşamSütü,
                           x.Toplam,
                           x.Tarihi
                       }).ToList();
            gridControl1.DataSource = uret;

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            inekler B = new inekler();
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

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            Finans B = new Finans();
            B.Show();
            this.Hide();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Dashboard B = new Dashboard();
            B.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            inekler B = new inekler();
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

        private void sut_uretimi_Load(object sender, EventArgs e)
        {
            var ine = (from x in sut.Tb_inek
                       select new
                       {
                           x.İnİD,
                           x.İnekAdı,
                           

                       }).ToList();
            guna2ComboBox1.DisplayMember = "İnİD";
            guna2ComboBox1.ValueMember = "İnekAdı";
            guna2ComboBox1.DataSource = ine;

            list();
        }

        private void txtadısut_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtadısut.Text = guna2ComboBox1.SelectedValue.ToString();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox1.Text == "" && txtadısut.Text == "" && txtsabah.Text == "" && txtöğlen.Text == "" && txtakşam.Text == "" && txttoplam.Text == "" && datetarihi.Text == "" )
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (guna2ComboBox1.Text == "")
            {
                MessageBox.Show(" İnek İd alanı boş..!!");
            }
            else if (txtadısut.Text == "")
            {
                MessageBox.Show("İnek Adı alanı boş..!!");
            }
            else if (txtsabah.Text == "")
            {
                MessageBox.Show("Sabah sütü alanı boş..!!");
            }
            else if (txtöğlen.Text == "")
            {
                MessageBox.Show("Öğlen sütü  alanı boş..!!");
            }
            else if (txtakşam.Text == "")
            {
                MessageBox.Show("Akşam sütü alanı boş..!!");
            }
            else if (txttoplam.Text == "")
            {
                MessageBox.Show("Toplam alanı boş..!!");
            }
            else if (datetarihi.Text == "")
            {
                MessageBox.Show(" Tarihi alanı boş..!!");
            }
            
            
            else
            {
                Tb_Sut su = new Tb_Sut();
                su.İnekİD = int.Parse(guna2ComboBox1.Text);
                su.İnekAdı = txtadısut.Text;
                su.SabahSütü = int.Parse(txtsabah.Text);
                su.ÖğlenSütü = int.Parse(txtöğlen.Text);
                su.AkşamSütü = int.Parse(txtakşam.Text);
                su.Toplam = int.Parse(txttoplam.Text);
                su.Tarihi = datetarihi.Text;
                sut.Tb_Sut.Add(su);
                sut.SaveChanges();
                MessageBox.Show("Günlük Süt Üretimi Bilgileri Eklendi !");
                list();
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox1.Text == "" && txtadısut.Text == "" && txtsabah.Text == "" && txtöğlen.Text == "" && txtakşam.Text == "" && txttoplam.Text == "" && datetarihi.Text == "")
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (guna2ComboBox1.Text == "")
            {
                MessageBox.Show(" İnek İd alanı boş..!!");
            }
            else if (txtadısut.Text == "")
            {
                MessageBox.Show("İnek Adı alanı boş..!!");
            }
            else if (txtsabah.Text == "")
            {
                MessageBox.Show("Sabah sütü alanı boş..!!");
            }
            else if (txtöğlen.Text == "")
            {
                MessageBox.Show("Öğlen sütü  alanı boş..!!");
            }
            else if (txtakşam.Text == "")
            {
                MessageBox.Show("Akşam sütü alanı boş..!!");
            }
            else if (txttoplam.Text == "")
            {
                MessageBox.Show("Toplam alanı boş..!!");
            }
            else if (datetarihi.Text == "")
            {
                MessageBox.Show(" Tarihi alanı boş..!!");
            }
            else
            {
                int sütid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("SütİD").ToString());
                var su = sut.Tb_Sut.Find(sütid);
                su.İnekİD = int.Parse(guna2ComboBox1.Text);
                su.İnekAdı = txtadısut.Text;
                su.SabahSütü = int.Parse(txtsabah.Text);
                su.ÖğlenSütü = int.Parse(txtöğlen.Text);
                su.AkşamSütü = int.Parse(txtakşam.Text);
                su.Toplam = int.Parse(txttoplam.Text);
                su.Tarihi = datetarihi.Text;
                sut.SaveChanges();
                MessageBox.Show("Günlük Süt Üretimi Bilgileri Güncellendi !");
                list();
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                int sütid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("SütİD").ToString());
                var su = sut.Tb_Sut.Find(sütid);
                sut.Tb_Sut.Remove(su);
                sut.SaveChanges();
                MessageBox.Show("Ineğin Bilgileri Silindi !");
                list();
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            guna2ComboBox1.Text = gridView1.GetFocusedRowCellValue("İnekİD").ToString();
            txtadısut.Text = gridView1.GetFocusedRowCellValue("İnekAdı").ToString();
            txtsabah.Text = gridView1.GetFocusedRowCellValue("SabahSütü").ToString();
            txtöğlen.Text = gridView1.GetFocusedRowCellValue("ÖğlenSütü").ToString();
            txtakşam.Text = gridView1.GetFocusedRowCellValue("AkşamSütü").ToString();
            txttoplam.Text = gridView1.GetFocusedRowCellValue("Toplam").ToString();
            datetarihi.Text = gridView1.GetFocusedRowCellValue("Tarihi").ToString();
            
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
    }
}
