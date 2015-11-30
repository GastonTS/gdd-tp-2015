using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class FormAltaRuta : Abm.Alta
    {

        Boolean modificacion = false;
        public FormAltaRuta()
        {
            InitializeComponent();
            var ds = new gdDataBase().GetDataSP("ÑUFLO.CiudadTipoServicio");

            origenBinding.DataSource = ds.Tables[0];
            destinoBinding.DataSource = ds.Tables[0];
            tipoServicioBinding.DataSource = ds.Tables[1];

            comboBoxOrigen.DisplayMember = "Nombre";
            comboBoxOrigen.ValueMember = "Id ciudad";
            comboBoxDestino.DisplayMember = "Nombre";
            comboBoxDestino.ValueMember = "Id ciudad";
            comboBoxTipoServicio.DisplayMember = "Tipo Servicio";
            comboBoxTipoServicio.ValueMember = "Id Tipo Servicio";
            
        }

        public FormAltaRuta(DataRowView datosAModificar) 
        {
            InitializeComponent();
            
            var ds = new gdDataBase().GetDataSP("ÑUFLO.CiudadTipoServicio");

            origenBinding.DataSource = ds.Tables[0];
            destinoBinding.DataSource = ds.Tables[0];
            tipoServicioBinding.DataSource = ds.Tables[1];

            comboBoxOrigen.DisplayMember = "Nombre";
            comboBoxOrigen.ValueMember = "Id ciudad";
            comboBoxDestino.DisplayMember = "Nombre";
            comboBoxDestino.ValueMember = "Id ciudad";
            comboBoxTipoServicio.DisplayMember = "Tipo Servicio";
            comboBoxTipoServicio.ValueMember = "Id Tipo Servicio";
            
            textBoxCodRuta.Text = datosAModificar["Código Ruta"].ToString();
            DataSet dss = new gdDataBase().GetDataQuery("Select id_ciudad FROM ÑUFLO.Ciudad where nombre= " + "'" + datosAModificar["Ciudad Origen"].ToString() + "'");
            comboBoxOrigen.SelectedIndex = dss.Tables[0].Rows[0].Field<int>(0)-1;
            dss = new gdDataBase().GetDataQuery("Select id_ciudad FROM ÑUFLO.Ciudad where nombre= " + "'" + datosAModificar["Ciudad Destino"].ToString() + "'");
            comboBoxDestino.SelectedIndex = dss.Tables[0].Rows[0].Field<int>(0) - 1;
        }

        public void setCodRuta(String codigo)
        {
            textBoxCodRuta.Text = codigo;
        }

        public void esModificacion()
        {
            modificacion = true;
        }

        public void setOrigen(int index) 
        {
            comboBoxOrigen.SelectedIndex = index;
        }
        public void setDestino(int index) 
        {
            comboBoxDestino.SelectedIndex = index;
        }
        public void setServicio(int index)
        {
            comboBoxTipoServicio.SelectedIndex = index;
        }
        public void setPrecioBasePeso(Double precio) 
        {
               textBoxPrecioPeso.Text = precio.ToString();
               textBoxPrecioPeso.formatear();
        }
        public void setPrecioBasePasaje(double precio) 
        {
            textBoxPrecioPasaje.Text = precio.ToString();
            textBoxPrecioPasaje.formatear();
        }
        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCodRuta.ResetText();
            comboBoxOrigen.ResetText();
            comboBoxDestino.ResetText();
            comboBoxTipoServicio.ResetText();
            textBoxPrecioPasaje.Clear();
            textBoxPrecioPeso.Clear();
        }

        private void groupBoxCamposAltaRuta_Enter(object sender, EventArgs e)
        {

        }

        private void FormAltaRuta_Load(object sender, EventArgs e)
        {

            
            
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Decimal porcentajeRecargo() { return Decimal.Parse(((DataRowView)this.tipoServicioBinding.Current).Row["Porcentaje de recargo"].ToString()); }

        private Decimal precioPesoFinal() { return textBoxPrecioPeso.DecimalValue() * porcentajeRecargo(); }

        private Decimal precioPasajeFinal() { return textBoxPrecioPasaje.DecimalValue() * porcentajeRecargo(); }

        public void actualizarLabels()
        {
            labelValorPrecioFinalPeso.Text = "$" + precioPesoFinal().ToString();
            labelValorPrecioFinalPasaje.Text = "$" + precioPasajeFinal().ToString();
        }

        private void asignarPreciosFinalesALabels(object sender, EventArgs e)
        {
            actualizarLabels();   
        }



    }
}
