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
    public partial class GuruForm : Form
    {
        private GuruDal _guruDal;
        public GuruForm()
        {
            InitializeComponent();
            _guruDal = new GuruDal();
            ListDataGuru();
        }

        private void ListDataGuru()
        {
            var listGuru = _guruDal.ListData().ToList();
            var binding = new BindingSource();
            binding.DataSource = listGuru;
            dataGridView1.DataSource = binding;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //var grid = (DataGridView)sender;
            //if (grid.CurrentRow is null)
            //    return;
            //var guruId = grid.CurrentRow.Cells["GuruId"].Value.ToString();
            //var guru = _guruDal.GetData(guruId);
            //if (guru is null)
            //    return;
            //textBox1.Text = guru.GuruId;
            //textBox2.Text = guru.GuruName;

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.CurrentRow is null)
                return;
            var guruId = grid.CurrentRow.Cells["GuruId"].Value.ToString();
            var guru = _guruDal.GetData(guruId);
            if (guru is null)
                return;
            textBox1.Text = guru.GuruId;
            textBox2.Text = guru.GuruName;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
