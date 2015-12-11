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
        FormSeleccionAeronave miPadre;
        bool esVidaUtil;

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
            comboBoxTipoServicio.Text = filaAeronave.Cells[4].FormattedValue.ToString();
            textBoxCapacidadEncomiendas.Text = filaAeronave.Cells[7].FormattedValue.ToString();
            
            //HACER
            //Con un Stored Procedure, traerse la cantidad de bucatas y la lista de butacas ventanilla o pasillo
            //para así meterla en la modificación de la aeronave. Esta info no la puedo traer del form de selección
            //ya que no la tengo
        }

        private void limpiar() 
        {
            textBoxButacasVentanilla.Clear();
            textBoxButacasPasillo.Clear();

            textBoxCapacidadEncomiendas.Clear();
            textBoxFabricante.Clear();
            textBoxMatricula.Clear();
            textBoxModelo.Clear();

            comboBoxTipoServicio.ResetText();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private SPExecuter spAltaAeronave()
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("matricula", new gdDataBase.ValorTipo(textBoxMatricula.Text, SqlDbType.VarChar));
            camposValores.Add("modelo", new gdDataBase.ValorTipo(textBoxModelo.Text, SqlDbType.VarChar));
            camposValores.Add("fabricante", new gdDataBase.ValorTipo(textBoxFabricante.Text, SqlDbType.VarChar));
            camposValores.Add("tipo_de_servicio", new gdDataBase.ValorTipo((comboBoxTipoServicio.SelectedIndex + 1).ToString(), SqlDbType.Int));
            camposValores.Add("capacidad_de_encomiendas", new gdDataBase.ValorTipo(textBoxCapacidadEncomiendas.Text, SqlDbType.Decimal));
            camposValores.Add("fecha_hoy", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

            errorMensaje.Add(2627, "Ingresó una matrícula de aeronave ya registrada. Intente nuevamente...");

            return new SPPureExec("ÑUFLO.AltaAeronave", camposValores, errorMensaje);
        }

        private SPExecuter spActualizarAeronave()
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(idAeronaveModificada, SqlDbType.Int));
            camposValores.Add("matricula", new gdDataBase.ValorTipo(textBoxMatricula.Text, SqlDbType.VarChar));
            camposValores.Add("modelo", new gdDataBase.ValorTipo(textBoxModelo.Text, SqlDbType.VarChar));
            camposValores.Add("fabricante", new gdDataBase.ValorTipo(textBoxFabricante.Text, SqlDbType.VarChar));
            camposValores.Add("tipo_de_servicio", new gdDataBase.ValorTipo((comboBoxTipoServicio.SelectedIndex + 1).ToString(), SqlDbType.Int));
            camposValores.Add("capacidad_de_encomiendas", new gdDataBase.ValorTipo(textBoxCapacidadEncomiendas.Text, SqlDbType.Decimal));
            camposValores.Add("fecha_hoy", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

            errorMensaje.Add(2627, "Ingresó una matrícula de aeronave ya registrada. Intente nuevamente...");

            return new SPPureExec("ÑUFLO.ActualizarAeronave", camposValores, errorMensaje, "Aeronave modificada correctamente");
        }

        private void agregarButacas()
        {
            for (int i = 0; i < Convert.ToInt32(textBoxButacasVentanilla.Text); i++)
            {
                Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
                Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

                camposValores.Add("matricula", new gdDataBase.ValorTipo(textBoxMatricula.Text, SqlDbType.VarChar));
                camposValores.Add("numeroButaca", new gdDataBase.ValorTipo((i).ToString(), SqlDbType.Decimal));
                camposValores.Add("tipoButaca", new gdDataBase.ValorTipo(1.ToString(), SqlDbType.Int));

                new gdDataBase().Exec("ÑUFLO.AgregarButaca", camposValores, errorMensaje, null);
            }

            for (int i = Convert.ToInt32(textBoxButacasVentanilla.Text); i < Convert.ToInt32(textBoxButacasVentanilla.Text) + Convert.ToInt32(textBoxButacasPasillo.Text); i++)
            {
                Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
                Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

                camposValores.Add("matricula", new gdDataBase.ValorTipo(textBoxMatricula.Text, SqlDbType.VarChar));
                camposValores.Add("numeroButaca", new gdDataBase.ValorTipo((i).ToString(), SqlDbType.Decimal));
                camposValores.Add("tipoButaca", new gdDataBase.ValorTipo(2.ToString(), SqlDbType.Int));

                new gdDataBase().Exec("ÑUFLO.AgregarButaca", camposValores, errorMensaje, null);
            }
        }

        public void setPadre(FormSeleccionAeronave padre)
        {
            miPadre = padre;
        }

        public void setPadreEsVidaUtil(bool queEs)
        {
            esVidaUtil = queEs;
        }

        public void setButacasVentanilla(int cantidadVentanilla)
        {
            textBoxButacasVentanilla.Text = cantidadVentanilla.ToString();
        }

        public void setButacasPasillo(int cantidadPasillo)
        {
            textBoxButacasPasillo.Text = cantidadPasillo.ToString();
        }

        protected override void guardarPosta()
        {
            if (!esModificacion)
            {
                var alta = spAltaAeronave();
                alta.Exec();
                if (!alta.huboError())
                {
                    agregarButacas();
                    MessageBox.Show("Aeronave registrada correctamente");
                    limpiar();
                }

                if (miPadre != null)
                {
                    this.Close();
                    miPadre.podesDarDeBaja(esVidaUtil);
                }
            }
            else
            {
                var actualizar = spActualizarAeronave();
                actualizar.Exec();

                if (!(actualizar.huboError()))
                {
                    agregarButacas();
                    limpiar();
                }
                miPadre.consultarConFiltro();
                this.Close();
            }
        }
    }
}
