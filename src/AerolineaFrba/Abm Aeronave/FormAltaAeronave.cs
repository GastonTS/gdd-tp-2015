using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class FormAltaAeronave : Abm.Alta, IFormulariosAeronave
    {
        Boolean esModificacion = false;
        String idAeronaveModificada = "";
        DataGridViewRow filaAeronave = null;

        public FormAltaAeronave()
        {
            InitializeComponent();
            new gdDataBase().actualizarBindingSourceQuery(bindingSourceTipoServicio, "select * from [Ñuflo].TipoServicio");
            comboBoxTipoServicio.DisplayMember = "tipo_servicio";
            comboBoxTipoServicio.ValueMember = "id_tipo_servicio";
        }


        public void setFilaDeAeronaveSeleccionada(DataGridViewRow filaAeronave)
        {
            this.filaAeronave = filaAeronave;

            esModificacion = true;
            this.Text = "Modificación de Aeronave";

            idAeronaveModificada = filaAeronave.Cells[0].FormattedValue.ToString();
            textBoxModelo.Text = filaAeronave.Cells[1].FormattedValue.ToString();
            textBoxMatricula.Text = filaAeronave.Cells[2].FormattedValue.ToString();
            textBoxFabricante.Text = filaAeronave.Cells[3].FormattedValue.ToString();
            switch (filaAeronave.Cells[4].FormattedValue.ToString())
            {
                case "1":
                    comboBoxTipoServicio.Text = "Primera Clase";
                    break;
                case "2":
                    comboBoxTipoServicio.Text = "Ejecutivo";
                    break;
                case "3":
                    comboBoxTipoServicio.Text = "Turista";
                    break;
            }

            textBoxCapacidadEncomiendas.Text = filaAeronave.Cells[6].FormattedValue.ToString();

            //HACER
            //Con un Stored Procedure, traerse la cantidad de bucatas y la lista de butacas ventanilla o pasillo
            //para así meterla en la modificación de la aeronave. Esta info no la puedo traer del form de selección
            //ya que no la tengo
        }

        private void btnElegirTipoButaca_Click(object sender, EventArgs e)
        {
            checkedListBoxButacas.Enabled = true;
            checkedListBoxButacas.Items.Clear();

            if (textBoxCantidadButacas.Text != "")
            {
                for (int i = 0; i < Convert.ToInt32(textBoxCantidadButacas.Text); i++)
                {
                    checkedListBoxButacas.Items.Add("Butaca N°: " + (i + 1));
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCantidadButacas.Clear();
            btnElegirTipoButaca.Enabled = false;

            textBoxCapacidadEncomiendas.Clear();
            textBoxFabricante.Clear();
            textBoxMatricula.Clear();
            textBoxModelo.Clear();

            checkedListBoxButacas.Items.Clear();
            checkedListBoxButacas.Enabled = false;

            comboBoxTipoServicio.ResetText();
        }

        private void textBoxCantidadButacas_TextChanged(object sender, EventArgs e)
        {
            btnElegirTipoButaca.Enabled = (textBoxCantidadButacas.Text != "" &&  Convert.ToInt32(textBoxCantidadButacas.Text) > 0);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!esModificacion)
            {
                darDeAltaAeronave();
                agregarButacas();
            }
            else
                actualizarAeronave();
        }

        private void darDeAltaAeronave()
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("matricula", new gdDataBase.ValorTipo(textBoxMatricula.Text, SqlDbType.VarChar));
            camposValores.Add("modelo", new gdDataBase.ValorTipo(textBoxModelo.Text, SqlDbType.VarChar));
            camposValores.Add("fabricante", new gdDataBase.ValorTipo(textBoxFabricante.Text, SqlDbType.VarChar));
            camposValores.Add("tipo_de_servicio", new gdDataBase.ValorTipo((comboBoxTipoServicio.SelectedIndex + 1).ToString(), SqlDbType.Int));
            camposValores.Add("capacidad_de_encomiendas", new gdDataBase.ValorTipo(textBoxCapacidadEncomiendas.Text, SqlDbType.Decimal));
            camposValores.Add("fecha_hoy", new gdDataBase.ValorTipo(DateTime.Now.Date.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.VarChar));

            errorMensaje.Add(2627, "Ingresó una matrícula de aeronave ya registrada. Intente nuevamente...");

            new gdDataBase().Exec("ÑUFLO.AltaAeronave", camposValores, errorMensaje, "Aeronave registrada correctamente");
        }

        private void actualizarAeronave()
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(idAeronaveModificada, SqlDbType.Int));
            camposValores.Add("matricula", new gdDataBase.ValorTipo(textBoxMatricula.Text, SqlDbType.VarChar));
            camposValores.Add("modelo", new gdDataBase.ValorTipo(textBoxModelo.Text, SqlDbType.VarChar));
            camposValores.Add("fabricante", new gdDataBase.ValorTipo(textBoxFabricante.Text, SqlDbType.VarChar));
            camposValores.Add("tipo_de_servicio", new gdDataBase.ValorTipo((comboBoxTipoServicio.SelectedIndex + 1).ToString(), SqlDbType.Int));
            camposValores.Add("capacidad_de_encomiendas", new gdDataBase.ValorTipo(textBoxCapacidadEncomiendas.Text, SqlDbType.Decimal));
            camposValores.Add("fecha_hoy", new gdDataBase.ValorTipo(DateTime.Now.Date.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.VarChar));

            errorMensaje.Add(2627, "Ingresó una matrícula de aeronave ya registrada. Intente nuevamente...");

            new gdDataBase().Exec("ÑUFLO.ActualizarAeronave", camposValores, errorMensaje, "Aeronave modificada correctamente");
        }

        private void agregarButacas()
        {
            int ventanilla = 2; //pasillo

            for (int i = 0; i < checkedListBoxButacas.Items.Count; i++)
            {
                Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
                Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

                if (checkedListBoxButacas.GetItemChecked(i))
                    ventanilla = 1;
                else
                    ventanilla = 2;

                camposValores.Add("matricula", new gdDataBase.ValorTipo(textBoxMatricula.Text, SqlDbType.VarChar));
                camposValores.Add("numeroButaca", new gdDataBase.ValorTipo((i).ToString(), SqlDbType.Decimal));
                camposValores.Add("tipoButaca", new gdDataBase.ValorTipo(ventanilla.ToString(), SqlDbType.Int));

                new gdDataBase().Exec("ÑUFLO.AgregarButaca", camposValores, errorMensaje, null);
            }
        }

    }
}
