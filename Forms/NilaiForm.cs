using sekolahku_jude.DataAkses;
using sekolahku_jude.Model;
using sekolahku_jude.Models;
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
    public partial class NilaiForm : Form
    {
        private readonly KelasDal _kelasDal;
        private readonly SiswaDal _siswaDal;
        private readonly MapelDal _mapelDal;
        private readonly NilaiDal _nilaisiswaDal;

        private BindingList<NilaiDto> _listMapel;

        public NilaiForm()
        {
            _kelasDal = new KelasDal();
            _siswaDal = new SiswaDal();
            _mapelDal = new MapelDal();
            _nilaisiswaDal = new NilaiDal();
            InitializeComponent();

            InitKelasGrid();
            IniNilaiSiswaGrid();
            InitSiswaCombo();
            RegisterEventHandler();
        }

        private void RegisterEventHandler()
        {
            KelasGrid.CellDoubleClick += KelasGrid_CellDoubleClick;
            SiswaCombo.SelectedIndexChanged += SiswaCombo_SelectedIndexChanged;

            NilaiGrid.CellValidated += NilaiGrid_CellValidated;
            KelasIdText.Validated += KelasIdText_Validated;

            SaveButton.Click += SaveButton_Click;
            NewButton.Click += NewButton_Click;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            KelasIdText.Text = string.Empty;
            KelasNameText.Text = string.Empty;
            SiswaCombo.SelectedIndex = 0;
            _listMapel.Clear();
            LoadNilai();

        }


    }
}
