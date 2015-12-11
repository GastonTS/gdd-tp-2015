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
        Boolean esReemplazo = false;
        DataRow datosAeronaveAReemplazar;
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

        public void esReemplazoDe(int id_nave) {
            esReemplazo = true;
            var camposValores = gdDataBase.newParameters();
            camposValores.Add("id_aeronave",new gdDataBase.ValorTipo(id_nave,SqlDbType.Int));
            datosAeronaveAReemplazar = new gdDataBase().ExecAndGetData("ÑUFLO.VistaAeronaveDadoId", camposValores).Rows[0];
            textBoxFabricante.Text = datosAeronaveAReemplazar["fabricante"].ToString();
            textBoxFabricante.Enabled = false;
            textBoxModelo.Text = datosAeronaveAReemplazar["modelo"].ToString();
            textBoxModelo.Enabled = false;
            comboBoxTipoServicio.SelectedIndex = (int)datosAeronaveAReemplazar["id_tipo_servicio"] - 1;
            comboBoxTipoServicio.Enabled = false;
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

            comboBoxTipoServicio.SelectedIndex = 0;
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

        private Boolean esReemplazoValido()
        {
            if (textBoxButacasVentanilla.Text.Trim() == "" ||
                textBoxButacasPasillo.Text.Trim() == "" ||
                textBoxCapacidadEncomiendas.Text.Trim() == "") return false;
            return
            Convert.ToInt32(textBoxCapacidadEncomiendas.Text) >= Convert.ToInt32(datosAeronaveAReemplazar["capacidad_encomienda"]) &&
            Convert.ToInt32(textBoxButacasPasillo.Text) + Convert.ToInt32(textBoxButacasVentanilla.Text) >= Convert.ToInt32(datosAeronaveAReemplazar["cant_butacas_pasillo"]) +
            Convert.ToInt32(datosAeronaveAReemplazar["cant_butacas_ventana"]);

        }

        protected override void guardarPosta()
        {
            if (!esModificacion)
            {
                if (miPadre != null)
                {
                    if (!esReemplazoValido()) {
                        MessageBox.Show("La aeronave no cumple con los requisitos para suplantar la aeronave anterior, la cantidad de butacas y capacidad de encomiendas debe ser mayor que aquellas de la aeronave a reemplazar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        MessageBox.Show("Los minimos requeridos son los siguientes:\nCapacidad Encomienda: "+datosAeronaveAReemplazar["capacidad_encomienda"]
                                          + "\nCantidad butacas: "+(Convert.ToInt32(datosAeronaveAReemplazar["cant_butacas_pasillo"])+Convert.ToInt32(datosAeronaveAReemplazar["cant_butacas_ventanilla"])).ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textBoxCapacidadEncomiendas.Text = datosAeronaveAReemplazar["capacidad_encomienda"].ToString();
                        textBoxButacasPasillo.Text = datosAeronaveAReemplazar["cant_butacas_pasillo"].ToString();
                        textBoxButacasVentanilla.Text = datosAeronaveAReemplazar["cant_butacas_ventanilla"].ToString();
                        return;
                    }
                }
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
                    miPadre.daDeBaja(esVidaUtil);
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

        private void FormAltaAeronave_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (esReemplazo)
            {
             
                var opcion = MessageBox.Show("¿Está seguro que desea cancelar toda la operación?","Baja de aeronave",MessageBoxButtons.YesNo);
                if (opcion == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
