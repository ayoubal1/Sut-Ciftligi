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
    public partial class saglik_rapotu : Form
    {
        DB_SUTEntities2 sut = new DB_SUTEntities2();
        public saglik_rapotu()
        {
            InitializeComponent();
        }
        void list()
        {
            var ine = (from x in sut.Tb_Sağlık
                       select new
                       {
                           x.RapİD,
                           x.İnekİD,
                           x.İnekAdı,
                           x.Durum,
                           x.Teşhis,
                           x.Tedavi,
                           x.Maliyeti,
                           x.VeterinAdı
                       }).ToList();
            gridControl1.DataSource = ine;

        }
        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

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

        private void saglik_rapotu_Load(object sender, EventArgs e)
        {
            var ine = (from x in sut.Tb_inek
                       select new
                       {
                           x.İnİD,
                           x.İnekAdı,


                       }).ToList();
            txtıdrap.DisplayMember = "İnİD";
            txtıdrap.ValueMember = "İnekAdı";
            txtıdrap.DataSource = ine;

            list();
        }

        private void txtıdrap_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtadırap.Text = txtıdrap.SelectedValue.ToString();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (txtıdrap.Text == "" && txtadırap.Text == "" && txtdurumrap.Text == "" && txtteşhisrap.Text == "" && txttedavirap.Text == "" && txtmaliyetirap.Text == "" && txtveterinrap.Text == "" )
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (txtıdrap.Text == "")
            {
                MessageBox.Show(" İnek İd alanı boş..!!");
            }
            else if (txtadırap.Text == "")
            {
                MessageBox.Show("İnek Adı alanı boş..!!");
            }
            else if (txtdurumrap.Text == "")
            {
                MessageBox.Show("Durum alanı boş..!!");
            }
            else if (txtteşhisrap.Text == "")
            {
                MessageBox.Show("Teşhis  alanı boş..!!");
            }
            else if (txttedavirap.Text == "")
            {
                MessageBox.Show("Tedavi alanı boş..!!");
            }
            else if (txtmaliyetirap.Text == "")
            {
                MessageBox.Show("Tedavi Maliyeti alanı boş..!!");
            }
            else if (txtveterinrap.Text == "")
            {
                MessageBox.Show("Veteriner Adı alanı boş..!!");
            }
            else
            {
                Tb_Sağlık sa = new Tb_Sağlık();
                sa.İnekİD = int.Parse(txtıdrap.Text);
                sa.İnekAdı = txtadırap.Text;
                sa.Durum = txtdurumrap.Text;
                sa.Teşhis = txtteşhisrap.Text;
                sa.Tedavi = txttedavirap.Text;
                sa.Maliyeti = int.Parse(txtmaliyetirap.Text);
                sa.VeterinAdı = txtveterinrap.Text;
                sut.Tb_Sağlık.Add(sa);
                sut.SaveChanges();
                MessageBox.Show("Sağlık Raporu Bilgileri Eklendi !");
                list();
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if (txtıdrap.Text == "" && txtadırap.Text == "" && txtdurumrap.Text == "" && txtteşhisrap.Text == "" && txttedavirap.Text == "" && txtmaliyetirap.Text == "" && txtveterinrap.Text == "")
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (txtıdrap.Text == "")
            {
                MessageBox.Show(" İnek İd alanı boş..!!");
            }
            else if (txtadırap.Text == "")
            {
                MessageBox.Show("İnek Adı alanı boş..!!");
            }
            else if (txtdurumrap.Text == "")
            {
                MessageBox.Show("Durum alanı boş..!!");
            }
            else if (txtteşhisrap.Text == "")
            {
                MessageBox.Show("Teşhis  alanı boş..!!");
            }
            else if (txttedavirap.Text == "")
            {
                MessageBox.Show("Tedavi alanı boş..!!");
            }
            else if (txtmaliyetirap.Text == "")
            {
                MessageBox.Show("Tedavi Maliyeti alanı boş..!!");
            }
            else if (txtveterinrap.Text == "")
            {
                MessageBox.Show("Veteriner Adı alanı boş..!!");
            }
            else
            {
                int rapid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("RapİD").ToString());
                var sa = sut.Tb_Sağlık.Find(rapid);
                sa.İnekİD = int.Parse(txtıdrap.Text);
                sa.İnekAdı = txtadırap.Text;
                sa.Durum = txtdurumrap.Text;
                sa.Teşhis = txtteşhisrap.Text;
                sa.Tedavi = txttedavirap.Text;
                sa.Maliyeti = int.Parse(txtmaliyetirap.Text);
                sa.VeterinAdı = txtveterinrap.Text;
                sut.SaveChanges();
                MessageBox.Show("Sağlık Raporu Bilgileri Güncellendi !");
                list();
            }
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rapid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("RapİD").ToString());
                var sa = sut.Tb_Sağlık.Find(rapid);
                sut.Tb_Sağlık.Remove(sa);
                sut.SaveChanges();
                MessageBox.Show("Sağlık Raporu Bilgileri Silindi !");
                list();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtıdrap.Text = gridView1.GetFocusedRowCellValue("İnekİD").ToString();
            txtadırap.Text = gridView1.GetFocusedRowCellValue("İnekAdı").ToString();
            txtdurumrap.Text = gridView1.GetFocusedRowCellValue("Durum").ToString();
            txtteşhisrap.Text = gridView1.GetFocusedRowCellValue("Teşhis").ToString();
            txttedavirap.Text = gridView1.GetFocusedRowCellValue("Tedavi").ToString();
            txtmaliyetirap.Text = gridView1.GetFocusedRowCellValue("Maliyeti").ToString();
            txtveterinrap.Text = gridView1.GetFocusedRowCellValue("VeterinAdı").ToString();
            
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
    }
}
