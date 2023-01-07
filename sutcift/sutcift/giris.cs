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
    public partial class giris : Form
    {
        DB_SUTEntities2 sut = new DB_SUTEntities2();
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {
            txtkullanıcıadı.Text="";
            txtşifra.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            Tb_Çalışanlar çal = sut.Tb_Çalışanlar.Where(x => x.Adı == txtkullanıcıadı.Text && x.Şifre == txtşifra.Text).FirstOrDefault();
                   
            if (txtkullanıcıadı.Text != null && txtşifra.Text != null)
            {
               inekler ine = new inekler();
               ine.Show();
               this.Hide();
            }
            else
            {
               MessageBox.Show("yanlış kullanıcı adı ve şifre");
            }
     
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
}
