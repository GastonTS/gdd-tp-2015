using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Consulta_Millas
{
    public partial class FormConsultaMillas : Form
    {
        public FormConsultaMillas()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var camposValores = gdDataBase.newParameters();
                if (textBoxDni.Text.Trim() != "")
                    camposValores.Add("dni", new gdDataBase.ValorTipo(textBoxDni.Text, SqlDbType.Int));
                var historialMillas = new gdDataBase().ExecAndGetData("ÑUFLO.DetalleMillasDe", camposValores, new Dictionary<int, String>());
                if (historialMillas.Rows.Count == 0)
                    MessageBox.Show("No hay resultados que satisfagan la búsqueda");
                else{
                    dataGridViewDetalleAcumulacion.DataSource = historialMillas;
                    textBoxMillasAcumuladas.Text = new gdDataBase().ExecAndGetData("ÑUFLO.MillasTotalesDe", camposValores, new Dictionary<int, String>()).Rows[0].ItemArray[0].ToString();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridViewDetalleAcumulacion.DataSource = null;
            textBoxMillasAcumuladas.Clear();
            textBoxDni.Clear();
        }
    }
}
