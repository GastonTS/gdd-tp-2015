using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class FormSeleccionViaje : Form, IDatosCompra
    {
        List<Pasaje> pasajes = new List<Pasaje>();
        List<Encomienda> encomiendas = new List<Encomienda>();
        decimal pesoDisponible = 0;

        public struct Compra
        {
            public int idViaje, dni, codigoDeCompra;

            public Compra(int idViaje, int dni, int codigoDeCompra)
            {
                this.idViaje = idViaje;
                this.dni = dni;
                this.codigoDeCompra = codigoDeCompra;
            }
        }

        public struct Pasaje
        {
            public int codigoDeCompra, dni, numeroDeButaca;

            public Pasaje(int codigoDeCompra, int dni, int numeroDeButaca)
            {
                this.codigoDeCompra = codigoDeCompra;
                this.dni = dni;
                this.numeroDeButaca = numeroDeButaca;
            }
        }

        public struct Encomienda
        {
            public int codigoDeCompra, dni;
            public decimal pesoEncomienda;

            public Encomienda(int codigoDeCompra, int dni, decimal pesoEncomienda)
            {
                this.codigoDeCompra = codigoDeCompra;
                this.dni = dni;
                this.pesoEncomienda = pesoEncomienda;
            }
        }

        public FormSeleccionViaje()
        {
            InitializeComponent();
        }

        public void setPasaje(int dni, int numeroDeButaca) 
        {
            if (pasajes.Any(unPasaje => unPasaje.dni == dni))
                MessageBox.Show("Esta persona ya tiene asignado un pasaje en este viaje");
            else
            {
                pasajes.Add(new Pasaje(-1, dni, numeroDeButaca));
                listBoxPasajesYEncomiendasComprados.Items.Add("Pasaje -> DNI:" + dni + ". Butaca n°: " + numeroDeButaca);
            }
        }

        public void setEncomienda(int dni, decimal pesoEncomienda)
        {
            if (pesoDisponible - pesoEncomienda < 0)
                MessageBox.Show("El peso encomendado es mayor al disponible en la aeronave");
            else
            {
                pesoDisponible = pesoDisponible - pesoEncomienda;
                encomiendas.Add(new Encomienda(-1, dni, pesoEncomienda));
                listBoxPasajesYEncomiendasComprados.Items.Add("Encomienda -> DNI:" + dni + ". Peso: " + pesoEncomienda);
            }
        }

        private void btnVerDisponibles_Click(object sender, EventArgs e)
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            camposValores.Add("ciudad_origen", new gdDataBase.ValorTipo(comboBoxOrigen.Text, SqlDbType.VarChar));
            camposValores.Add("ciudad_destino", new gdDataBase.ValorTipo(comboBoxDestino.Text, SqlDbType.VarChar));
            camposValores.Add("fecha", new gdDataBase.ValorTipo(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.VarChar));

            var ds = new gdDataBase().GetDataWithParameters("ÑUFLO.ViajesDisponiblesPara", camposValores);

            dataGridView1.DataSource = ds;
        }

        private void btnAgregarPasaje_Click(object sender, EventArgs e)
        {
            irAComprar(true);
        }

        private void FormSeleccionViaje_Load(object sender, EventArgs e)
        {
            var dtOrigenDestino = new gdDataBase().GetDataWithParameters("ÑUFLO.TodasLasCiudades", null);

            origenBindingSource.DataSource = dtOrigenDestino;
            destinoBindingSource.DataSource = dtOrigenDestino;

            comboBoxOrigen.DataSource = origenBindingSource;
            comboBoxOrigen.DisplayMember = dtOrigenDestino.Columns[0].ColumnName;

            comboBoxDestino.DataSource = destinoBindingSource;
            comboBoxDestino.DisplayMember = dtOrigenDestino.Columns[0].ColumnName;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
                pesoDisponible = Convert.ToInt32(filaSeleccionada.Cells[5].FormattedValue.ToString());

                HabilitacionDeCompra(true);
            }
            else if (dataGridView1.Rows.Count == 1)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[dataGridView1.Rows[0].Index];
                pesoDisponible = Convert.ToInt32(filaSeleccionada.Cells[5].FormattedValue.ToString());

                HabilitacionDeCompra(true);
            }
            else
                HabilitacionDeCompra(false);
        }

        private void HabilitacionDeCompra(bool estado)
        {
            groupBoxPasajesEncomiendas.Enabled = estado;
        }

        private void btnAgregarEncomienda_Click(object sender, EventArgs e)
        {
            irAComprar(false);
        }

        private void irAComprar(bool esSoloPasaje)
        {
            FormDatosPasajeroEncomienda fdpe = new FormDatosPasajeroEncomienda();
            DataGridViewRow filaSeleccionada;

            if (dataGridView1.Rows.Count > 1)
                filaSeleccionada = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
            else
                filaSeleccionada = dataGridView1.Rows[dataGridView1.Rows[0].Index];

            fdpe.indicarPasajeOEncomienda(esSoloPasaje);

            if (esSoloPasaje)
            {
                List<int> butacasEnCompra = new List<int>();

                for (int i = 0; i < pasajes.Count; i++)
                    butacasEnCompra.Add(pasajes[i].numeroDeButaca);

                fdpe.setButacasEnCompra(butacasEnCompra);
            }

            fdpe.setIDViaje(Convert.ToInt32(filaSeleccionada.Cells[0].FormattedValue.ToString()));

            fdpe.Show(this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FormCompraEfectiva fce = new FormCompraEfectiva();

            DataGridViewRow filaSeleccionada;

            if (dataGridView1.Rows.Count > 1)
                filaSeleccionada = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
            else
                filaSeleccionada = dataGridView1.Rows[dataGridView1.Rows[0].Index];

            fce.setCompras(new Compra(Convert.ToInt32(filaSeleccionada.Cells[0].FormattedValue.ToString()),
                -1, -1), pasajes, encomiendas);

            fce.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (pasajes.Count > 0 || encomiendas.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Está seguro que desea cancelar las compras registradas hasta el momento",
                    "ASD", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    dateTimePicker1.ResetText();
                    comboBoxDestino.SelectedIndex = 0;
                    comboBoxOrigen.SelectedIndex = 0;

                    pasajes.Clear();
                    encomiendas.Clear();
                    pesoDisponible = 0;
                    listBoxPasajesYEncomiendasComprados.Items.Clear();
                    dataGridView1.ClearSelection();
                }
            }
        }
    }
}
