using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sekolahku_jude.Model;
using sekolahku_jude.DataAkses;

namespace sekolahku_jude.Forms
{
    public partial class GuruForm : Form
    {
        private GuruDal dal;
        public GuruForm()
        {
            dal = new GuruDal();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_guruId.Text==""||tb_guru_name.Text=="")
            {
                MessageBox.Show("Form belum lengkap");
                return;
            }

            var guru = new GuruModel() {
                guru_id = tb_guruId.Text,
                guru_name=tb_guru_name.Text                
            };

          
                dal.Insert(guru);
                MessageBox.Show("Berhasil Input data");

        }
    }
}
