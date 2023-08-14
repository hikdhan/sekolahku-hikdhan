using sekolahku_jude.DataAkses;
using sekolahku_jude.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sekolahku_jude.Forms
{
    public partial class MapelForm : Form
    {
        private readonly MapelDal _MapelDal;
        public MapelForm()
        {
            InitializeComponent();
            _MapelDal = new MapelDal();

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var list = _MapelDal.ListData()?.ToList() ?? new List<MapelModel>();
            var binding = new BindingSource();
            binding.DataSource = list;
            dataGridView1.DataSource = binding;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            ClearForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("Kode Mapel kosong");
                return;
            }

            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Nama Mapel kosong");
                return;
            }
            var newMapel = new MapelModel
            {
                MapelId = textBox1.Text,
                MapelName = textBox2.Text,
            };

            var mapelDb = _MapelDal.GetData(textBox1.Text);
            if (mapelDb == null)
                _MapelDal.Insert(newMapel);
            else
                _MapelDal.Update(newMapel);

            ClearForm();
            RefreshGrid();
        }

        private void ClearForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hapus data?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var mapelId = textBox1.Text;
            _MapelDal.Delete(mapelId);
            ClearForm();
            RefreshGrid();
        }
    }
}
