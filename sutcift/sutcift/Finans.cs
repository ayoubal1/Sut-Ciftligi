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
    public partial class Finans : Form
    {
        DB_SUTEntities2 sut = new DB_SUTEntities2();
        public Finans()
        {
            InitializeComponent();
        }

        void list()
        {
            var har = (from x in sut.Tb_Harcamalar
                       select new
                       {
                           x.HarİD,
                           x.Tarihi,
                           x.Maksat,
                           x.Tutar
                          
                           
                       }).ToList();
            gridControl1.DataSource = har;

        }
        void list2()
        {
            var gel = (from x in sut.Tb_Gelirler
                       select new
                       {
                           x.GelİD,
                           x.Tarihi,
                           x.Tür,
                           x.Tutar


                       }).ToList();
            gridControl2.DataSource = gel;

        }


        private void Finans_Load(object sender, EventArgs e)
        {
            list();
            list2();
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

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            sut_satisi B = new sut_satisi();
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

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            sut_satisi B = new sut_satisi();
            B.Show();
            this.Hide();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Dashboard B = new Dashboard();
            B.Show();
            this.Hide();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (datetarihihar.Text == "" && txtmaksathar.Text == "" && txttutarhar.Text == "")
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (datetarihihar.Text == "")
            {
                MessageBox.Show("  Tarihi alanı boş..!!");
            }
            else if (txtmaksathar.Text == "")
            {
                MessageBox.Show("Maksat alanı boş..!!");
            }
            else if (txttutarhar.Text == "")
            {
                MessageBox.Show("Tutar alanı boş..!!");
            }
            else
            {
                Tb_Harcamalar har = new Tb_Harcamalar();
                har.Tarihi = datetarihihar.Text;
                har.Maksat = txtmaksathar.Text;
                har.Tutar = int.Parse(txttutarhar.Text);
                sut.Tb_Harcamalar.Add(har);
                sut.SaveChanges();
                MessageBox.Show("Harcamalar  Bilgileri Eklendi !");
                list();
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int harid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("HarİD").ToString());
                var har = sut.Tb_Harcamalar.Find(harid);
                sut.Tb_Harcamalar.Remove(har);
                sut.SaveChanges();
                MessageBox.Show("Harcamalar Bilgileri Silindi !");
                list();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            datetarihihar.Text = gridView1.GetFocusedRowCellValue("Tarihi").ToString();
            txtmaksathar.Text = gridView1.GetFocusedRowCellValue("Maksat").ToString();
            txttutarhar.Text = gridView1.GetFocusedRowCellValue("Tutar").ToString();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            if (datetarihigel.Text == "" && txttürgel.Text == "" && txttutargel.Text == "")
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (datetarihigel.Text == "")
            {
                MessageBox.Show("  Tarihi alanı boş..!!");
            }
            else if (txttürgel.Text == "")
            {
                MessageBox.Show("Tür alanı boş..!!");
            }
            else if (txttutarhar.Text == "")
            {
                MessageBox.Show("Tutar alanı boş..!!");
            }
            else
            {
                Tb_Gelirler gel = new Tb_Gelirler();
                gel.Tarihi = datetarihigel.Text;
                gel.Tür = txttürgel.Text;
                gel.Tutar = int.Parse(txttutargel.Text);
                sut.Tb_Gelirler.Add(gel);
                sut.SaveChanges();
                MessageBox.Show("Gelirler  Bilgileri Eklendi !");
                list2();
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int gelid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("GelİD").ToString());
                var gel = sut.Tb_Gelirler.Find(gelid);
                sut.Tb_Gelirler.Remove(gel);
                sut.SaveChanges();
                MessageBox.Show("Gelirler Bilgileri Silindi !");
                list2();
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            datetarihigel.Text = gridView2.GetFocusedRowCellValue("Tarihi").ToString();
            txttürgel.Text = gridView2.GetFocusedRowCellValue("Tür").ToString();
            txttutargel.Text = gridView2.GetFocusedRowCellValue("Tutar").ToString();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            çalışanlar B = new çalışanlar();
            B.Show();
            this.Hide();
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
