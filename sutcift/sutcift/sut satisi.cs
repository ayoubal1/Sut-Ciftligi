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
    public partial class sut_satisi : Form
    {
        DB_SUTEntities2 sut = new DB_SUTEntities2();
        public sut_satisi()
        {
            InitializeComponent();
        }
        void list()
        {
            var sat = (from x in sut.Tb_Satışı
                       select new
                       {
                           x.SatİD,
                           x.Tarihi,
                           x.Fiyat,
                           x.MüşteriAdı,
                           x.MüşteriNo,
                           x.Miktar,
                           x.Toplam
                           
                       }).ToList();
            gridControl1.DataSource = sat;

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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ırkı B = new ırkı();
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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ırkı B = new ırkı();
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

        private void sut_satisi_Load(object sender, EventArgs e)
        {
            var uret = (from x in sut.Tb_Sut
                        select new
                        {

                            x.Tarihi
                        }).ToList();
            txttarihisat.DisplayMember = "Tarihi";
            txttarihisat.DataSource = uret;
            list();
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

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (txttarihisat.Text == "" && txtfiyatsat.Text == "" && txtmüsteriadısat.Text == "" && txtmüşterinosat.Text == "" && txtmiktarsat.Text == "" && txttoplamsat.Text == "" )
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (txttarihisat.Text == "")
            {
                MessageBox.Show("  Tarihi alanı boş..!!");
            }
            else if (txtfiyatsat.Text == "")
            {
                MessageBox.Show("Fiyat alanı boş..!!");
            }
            else if (txtmüsteriadısat.Text == "")
            {
                MessageBox.Show("Müşteri Adı alanı boş..!!");
            }
            else if (txtmüşterinosat.Text == "")
            {
                MessageBox.Show("Müşteri No  alanı boş..!!");
            }
            else if (txtmiktarsat.Text == "")
            {
                MessageBox.Show("Miktar alanı boş..!!");
            }
            else if (txttoplamsat.Text == "")
            {
                MessageBox.Show("Toplam alanı boş..!!");
            }
            else
            {
                Tb_Satışı sat = new Tb_Satışı();
                sat.Tarihi = txttarihisat.Text;
                sat.Fiyat = int.Parse(txtfiyatsat.Text);
                sat.MüşteriAdı = txtmüsteriadısat.Text;
                sat.MüşteriNo = txtmüşterinosat.Text;
                sat.Miktar = int.Parse(txtmiktarsat.Text);
                sat.Toplam = txttoplamsat.Text;
                
                sut.Tb_Satışı.Add(sat);
                sut.SaveChanges();
                MessageBox.Show("Süt Satışı  Bilgileri Eklendi !");
                list();
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if (txttarihisat.Text == "" && txtfiyatsat.Text == "" && txtmüsteriadısat.Text == "" && txtmüşterinosat.Text == "" && txtmiktarsat.Text == "" && txttoplamsat.Text == "")
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (txttarihisat.Text == "")
            {
                MessageBox.Show("  Tarihi alanı boş..!!");
            }
            else if (txtfiyatsat.Text == "")
            {
                MessageBox.Show("Fiyat alanı boş..!!");
            }
            else if (txtmüsteriadısat.Text == "")
            {
                MessageBox.Show("Müşteri Adı alanı boş..!!");
            }
            else if (txtmüşterinosat.Text == "")
            {
                MessageBox.Show("Müşteri No  alanı boş..!!");
            }
            else if (txtmiktarsat.Text == "")
            {
                MessageBox.Show("Miktar alanı boş..!!");
            }
            else if (txttoplamsat.Text == "")
            {
                MessageBox.Show("Toplam alanı boş..!!");
            }
            else
            {
                int satid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("SatİD").ToString());
                var sat = sut.Tb_Satışı.Find(satid);
                sat.Tarihi = txttarihisat.Text;
                sat.Fiyat = int.Parse(txtfiyatsat.Text);
                sat.MüşteriAdı = txtmüsteriadısat.Text;
                sat.MüşteriNo = txtmüşterinosat.Text;
                sat.Miktar = int.Parse(txtmiktarsat.Text);
                sat.Toplam = txttoplamsat.Text;
                sut.SaveChanges();
                MessageBox.Show("Süt Satışı  Bilgileri Güncellendi !");
                list();
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int satid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("SatİD").ToString());
                var sat = sut.Tb_Satışı.Find(satid);
                sut.Tb_Satışı.Remove(sat);
                sut.SaveChanges();
                MessageBox.Show("Ineğin Bilgileri Silindi !");
                list();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txttarihisat.Text = gridView1.GetFocusedRowCellValue("Tarihi").ToString();
            txtfiyatsat.Text = gridView1.GetFocusedRowCellValue("Fiyat").ToString();
            txtmüsteriadısat.Text = gridView1.GetFocusedRowCellValue("MüşteriAdı").ToString();
            txtmüşterinosat.Text = gridView1.GetFocusedRowCellValue("MüşteriNo").ToString();
            txtmiktarsat.Text = gridView1.GetFocusedRowCellValue("Miktar").ToString();
            txttoplamsat.Text = gridView1.GetFocusedRowCellValue("Toplam").ToString();
        }
    }
}
