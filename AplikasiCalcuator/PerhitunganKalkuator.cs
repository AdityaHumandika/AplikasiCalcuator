using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiCalcuator
{
    public partial class PerhitunganKalkuator : Form
    {
        public PerhitunganKalkuator()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboOperasi.Items.Add("Penambahan");
            cboOperasi.Items.Add("Pengurangan");
            cboOperasi.Items.Add("Perkalian");
            cboOperasi.Items.Add("Pembagian");
        }
        private void cboOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboOperasi.Items.Add("Penambahan");
            cboOperasi.Items.Add("Pengurangan");
            cboOperasi.Items.Add("Perkalian");
            cboOperasi.Items.Add("Pembagian");
        }
        public void proses()
        {
            var a = int.Parse(txtNilaiA.Text); //casting
            var b = Convert.ToInt32(txtNilaiB.Text); //casting
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text); //casting
            var b = Convert.ToInt32(txtNilaiB.Text); //casting

            var hitung = new Hitung();

            lstHasil.Items.Clear(); //kosongkan isi list box
            lstHasil.Items.Add(string.Format("Hasil Penambahan      : {0} + {1}     =   {2} ", a, b, hitung.Penambahan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pengurangan     : {0} - {1}     =   {2} ", a, b, hitung.Pengurangan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Perkalian       : {0} x {1}     =   {2} ", a, b, hitung.Perkalian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pembagian       : {0} / {1}     =   {2} ", a, b, hitung.Pembagian(a, b)));
        }

    }
}
