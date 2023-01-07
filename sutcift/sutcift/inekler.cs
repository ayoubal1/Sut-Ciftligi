using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace sutcift
{
    public partial class inekler : Form
    {
        int mov;
        int movx;
        int movy;
        DB_SUTEntities2 sut = new DB_SUTEntities2();
        public inekler()
        {

            InitializeComponent();
            
        }

        void list()
        {
            var ine = (from x in sut.Tb_inek
                             select new
                             {
                                 x.İnİD,
                                 x.İnekAdı,
                                 x.Kulak_etiketi,
                                 x.Renk,
                                 x.Irkı,
                                 x.Doğum_tarihi,
                                 x.Yaş,
                                 x.Doğum_ağırlığı,
                                 x.Otlak
                             }).ToList();
            gridControl1.DataSource = ine;

        }
        private void inekler_Load(object sender, EventArgs e)
        {
            list();
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

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

        private void simpleButton5_Click(object sender, EventArgs e)
        {
             if (txtadı.Text == "" && txtkulak.Text == "" && txtrenk.Text == "" && txtırkı.Text == "" && datedoğum.Text == "" && txtyaş.Text == "" && txtdoğumağırlığı.Text == "" && txtotlak.Text == "")
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (txtadı.Text == "")
            {
                MessageBox.Show(" inek Adı alanı boş..!!");
            }
            else if (txtkulak.Text == "")
            {
                MessageBox.Show("Kulak Etiketi alanı boş..!!");
            }
            else if (txtrenk.Text == "")
            {
                MessageBox.Show("Renk alanı boş..!!");
            }
            else if (txtırkı.Text == "")
            {
                MessageBox.Show("Irkı  alanı boş..!!");
            }
            else if (datedoğum.Text == "")
            {
                MessageBox.Show("Doğum Tarihi alanı boş..!!");
            }
            else if (txtyaş.Text == "")
            {
                MessageBox.Show("Yaş alanı boş..!!");
            }
            else if (txtdoğumağırlığı.Text == "")
            {
                MessageBox.Show("Doğum Ağırlığı alanı boş..!!");
            }
            else if (txtotlak.Text == "")
            {
                MessageBox.Show("Otlak alanı boş..!!");
            }
            else
            {
                Tb_inek ine = new Tb_inek();
                ine.İnekAdı = txtadı.Text;
                ine.Kulak_etiketi = txtkulak.Text;
                ine.Renk = txtrenk.Text;
                ine.Irkı = txtırkı.Text;
                ine.Doğum_tarihi = datedoğum.Text;
                ine.Yaş = int.Parse(txtyaş.Text);
                ine.Doğum_ağırlığı = int.Parse(txtdoğumağırlığı.Text);
                ine.Otlak = txtotlak.Text;
                sut.Tb_inek.Add(ine);
                sut.SaveChanges();
                MessageBox.Show("Ineğin  Bilgileri Eklendi !");
                list();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if (txtadı.Text == "" && txtkulak.Text == "" && txtrenk.Text == "" && txtırkı.Text == "" && datedoğum.Text == "" && txtyaş.Text == "" && txtdoğumağırlığı.Text == "" && txtotlak.Text == "")
            {
                MessageBox.Show("Lütfen tüm verileri giriniz..");
            }
            else if (txtadı.Text == "")
            {
                MessageBox.Show(" inek Adı alanı boş..!!");
            }
            else if (txtkulak.Text == "")
            {
                MessageBox.Show("Kulak Etiketi alanı boş..!!");
            }
            else if (txtrenk.Text == "")
            {
                MessageBox.Show("Renk alanı boş..!!");
            }
            else if (txtırkı.Text == "")
            {
                MessageBox.Show("Irkı  alanı boş..!!");
            }
            else if (datedoğum.Text == "")
            {
                MessageBox.Show("Doğum Tarihi alanı boş..!!");
            }
            else if (txtyaş.Text == "")
            {
                MessageBox.Show("Yaş alanı boş..!!");
            }
            else if (txtdoğumağırlığı.Text == "")
            {
                MessageBox.Show("Doğum Ağırlığı alanı boş..!!");
            }
            else if (txtotlak.Text == "")
            {
                MessageBox.Show("Otlak alanı boş..!!");
            }
            else
            {
                int inid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("İnİD").ToString());
                var ine = sut.Tb_inek.Find(inid);

                ine.İnekAdı = txtadı.Text;
                ine.Kulak_etiketi = txtkulak.Text;
                ine.Renk = txtrenk.Text;
                ine.Irkı = txtırkı.Text;
                ine.Doğum_tarihi = datedoğum.Text;
                ine.Yaş = int.Parse(txtyaş.Text);
                ine.Doğum_ağırlığı = int.Parse(txtdoğumağırlığı.Text);
                ine.Otlak = txtotlak.Text;
                sut.SaveChanges();
                MessageBox.Show("Ineğin Bilgileri Güncellendi !");
                list();
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int inid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("İnİD").ToString());
                var ine = sut.Tb_inek.Find(inid);
                sut.Tb_inek.Remove(ine);
                sut.SaveChanges();
                MessageBox.Show("Ineğin Bilgileri Silindi !");
                list();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            txtadı.Text = gridView1.GetFocusedRowCellValue("İnekAdı").ToString();
            txtkulak.Text = gridView1.GetFocusedRowCellValue("Kulak_etiketi").ToString();
            txtrenk.Text = gridView1.GetFocusedRowCellValue("Renk").ToString();
            txtırkı.Text = gridView1.GetFocusedRowCellValue("Irkı").ToString();
            datedoğum.Text = gridView1.GetFocusedRowCellValue("Doğum_tarihi").ToString();
            txtyaş.Text = gridView1.GetFocusedRowCellValue("Yaş").ToString();
            txtdoğumağırlığı.Text = gridView1.GetFocusedRowCellValue("Doğum_ağırlığı").ToString();
            txtotlak.Text = gridView1.GetFocusedRowCellValue("Otlak").ToString();
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

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelControl2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panelControl2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void panelControl2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
