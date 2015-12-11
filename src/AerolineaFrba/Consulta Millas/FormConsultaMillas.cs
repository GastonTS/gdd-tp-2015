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
                camposValores.Add("hoy", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

                Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

                errorMensaje.Add(69018, "El cliente no tiene ninguna milla acumulada. Seleccione un cliente con millas por favor.");

                var historialMillas = new SPExecGetData("ÑUFLO.DetalleMillasDe", camposValores, errorMensaje);
                DataTable dt = (DataTable)historialMillas.Exec();
                if (dt.Rows.Count == 0 && !historialMillas.huboError())
                    MessageBox.Show("No hay resultados que satisfagan la búsqueda", "Cliente inexistente", 
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    camposValores.Remove("hoy");
                    dataGridViewDetalleAcumulacion.DataSource = dt;
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
