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
    public partial class ırkı : Form
    {
        DB_SUTEntities2 sut = new DB_SUTEntities2();
        public ırkı()
        {
            InitializeComponent();
        }

        void list()
        {
            var ırk = (from x in sut.Tb_ırkı
                       select new
                       {
                           x.ırİD,
                           x.inekİD,
                           x.kızgınlıktar,
                           x.cinstar,
                           x.gebeliktar,
                           x.beklenentar,
                           x.doğumtar,
                           x.uyaılar

                       }).ToList();
            gridControl1.DataSource = ırk;

        }
        private void ırkı_Load(object sender, EventArgs e)
        {
            {
                var ine = (from x in sut.Tb_inek
                           select new
                           {
                               x.İnİD,
                               x.İnekAdı,
                               x.Yaş


                           }).ToList();
                txtidırk.DisplayMember = "İnİD";
                txtidırk.ValueMember = "İnekAdı";
                txtidırk.DataSource = ine;


                list();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            inekler B = new inekler();
            B.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            sut_uretimi B = new sut_uretimi();
            B.Show();
            this.Hide();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            saglik_rapotu B = new saglik_rapotu();
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

        private void txtidırk_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtadıırk.Text = txtidırk.SelectedValue.ToString();
            

        }

        private void txtadıırk_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if ( txtidırk.Text=="" && txtadıırk.Text == "" && datekızgınlıkırk.Text == "" && datecinsırk.Text == "" && dategebelikırk.Text == "" && datebeklenenırk.Text == "" && datedoğumırk.Text == "" && txtuyaılarırk.Text == "")
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (txtidırk.Text == "")
            {
                MessageBox.Show(" İnek İd alanı boş..!!");
            }
            else if (txtadıırk.Text == "")
            {
                MessageBox.Show("inek Adı alanı boş..!!");
            }
           
            else if (datekızgınlıkırk.Text == "")
            {
                MessageBox.Show("Kızgınlık Tarihi  alanı boş..!!");
            }
            else if (datecinsırk.Text == "")
            {
                MessageBox.Show("Cins Tarihi alanı boş..!!");
            }
            else if (dategebelikırk.Text == "")
            {
                MessageBox.Show("Gebelik Tarihi alanı boş..!!");
            }
            else if (datebeklenenırk.Text == "")
            {
                MessageBox.Show(" Beklenen Tarih alanı boş..!!");
            }
            else if (datedoğumırk.Text == "")
            {
                MessageBox.Show("Doğum Tarihi alanı boş..!!");
            }
            else if (txtuyaılarırk.Text == "")
            {
                MessageBox.Show("Uyarılar alanı boş..!!");
            }
            else
            {
                Tb_ırkı ırk = new Tb_ırkı();
                ırk.inekİD =int.Parse (txtidırk.Text);
                ırk.inekAdı = txtadıırk.Text;
                ırk.kızgınlıktar = datekızgınlıkırk.Text;
                ırk.cinstar = datecinsırk.Text;
                ırk.gebeliktar = dategebelikırk.Text;
                ırk.beklenentar = datebeklenenırk.Text;
                ırk.doğumtar = datedoğumırk.Text;
                ırk.uyaılar = txtuyaılarırk.Text;
                sut.Tb_ırkı.Add(ırk);
                sut.SaveChanges();
                MessageBox.Show("Ineğin Irkı Bilgileri Eklendi !");
                list();
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if (txtidırk.Text == "" && txtadıırk.Text ==  "" && datekızgınlıkırk.Text == "" && datecinsırk.Text == "" && dategebelikırk.Text == "" && datebeklenenırk.Text == "" && datedoğumırk.Text == "" && txtuyaılarırk.Text == "")
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (txtidırk.Text == "")
            {
                MessageBox.Show(" İnek İd alanı boş..!!");
            }
            else if (txtadıırk.Text == "")
            {
                MessageBox.Show("inek Adı alanı boş..!!");
            }

            else if (datekızgınlıkırk.Text == "")
            {
                MessageBox.Show("Kızgınlık Tarihi  alanı boş..!!");
            }
            else if (datecinsırk.Text == "")
            {
                MessageBox.Show("Cins Tarihi alanı boş..!!");
            }
            else if (dategebelikırk.Text == "")
            {
                MessageBox.Show("Gebelik Tarihi alanı boş..!!");
            }
            else if (datebeklenenırk.Text == "")
            {
                MessageBox.Show(" Beklenen Tarih alanı boş..!!");
            }
            else if (datedoğumırk.Text == "")
            {
                MessageBox.Show("Doğum Tarihi alanı boş..!!");
            }
            else if (txtuyaılarırk.Text == "")
            {
                MessageBox.Show("Uyarılar alanı boş..!!");
            }
            else
            {
                int ırid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ırİD").ToString());
                var ırk = sut.Tb_ırkı.Find(ırid);
                ırk.inekİD = int.Parse(txtidırk.Text);
                ırk.inekAdı = txtadıırk.Text;
                ırk.kızgınlıktar = datekızgınlıkırk.Text;
                ırk.cinstar = datecinsırk.Text;
                ırk.gebeliktar = dategebelikırk.Text;
                ırk.beklenentar = datebeklenenırk.Text;
                ırk.doğumtar = datedoğumırk.Text;
                ırk.uyaılar = txtuyaılarırk.Text;
                sut.SaveChanges();
                MessageBox.Show("Ineğin Irkı Bilgileri Güncellendi !");
                list();
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ırid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ırİD").ToString());
                var ırk = sut.Tb_ırkı.Find(ırid);
                sut.Tb_ırkı.Remove(ırk);
                sut.SaveChanges();
                MessageBox.Show("Ineğin Irkı Bilgileri Silindi !");
                list();
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            çalışanlar B = new çalışanlar();
            B.Show();
            this.Hide();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtidırk.Text = gridView1.GetFocusedRowCellValue("inekİD").ToString();
           // txtadıırk.Text = gridView1.GetFocusedRowCellValue("inekAdı").ToString();
            datekızgınlıkırk.Text = gridView1.GetFocusedRowCellValue("kızgınlıktar").ToString();
            datecinsırk.Text = gridView1.GetFocusedRowCellValue("cinstar").ToString();
            dategebelikırk.Text = gridView1.GetFocusedRowCellValue("gebeliktar").ToString();
            datebeklenenırk.Text = gridView1.GetFocusedRowCellValue("beklenentar").ToString();
            datedoğumırk.Text = gridView1.GetFocusedRowCellValue("doğumtar").ToString();
            txtuyaılarırk.Text = gridView1.GetFocusedRowCellValue("uyaılar").ToString();
        }
    }
}
