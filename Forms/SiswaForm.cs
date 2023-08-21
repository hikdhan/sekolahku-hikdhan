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
    public partial class SiswaForm : Form
    {
        private readonly SiswaDal _siswaDal; 
        public SiswaForm()
        {
            InitializeComponent();
            _siswaDal = new SiswaDal();

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var list = _siswaDal.ListData()?.ToList() ?? new List<SiswaModel>();
            var binding = new BindingSource();
            binding.DataSource = list;
            dataGridView1.DataSource = binding;
        }
    }
}
