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
        String fechaSalida, fechaLlegadaEstimada;

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

        public void setPasaje(int dni, int numeroDeButaca, FormDatosPasajeroEncomienda hijo)
        {
            if (!validarQueNoEsteEnElVuelo(dni))
            {
                if (pasajes.Any(unPasaje => unPasaje.dni == dni))
                    MessageBox.Show("Esta persona ya tiene asignado un pasaje en este viaje");
                else
                {
                    pasajes.Add(new Pasaje(-1, dni, numeroDeButaca));
                    listBoxPasajesYEncomiendasComprados.Items.Add("Pasaje -> DNI:" + dni + ". Butaca n°: " + numeroDeButaca);
                    btnAceptar.Enabled = true;
                    hijo.Close();
                }
            }
        }

        public void setEncomienda(int dni, decimal pesoEncomienda, FormDatosPasajeroEncomienda hijo)
        {
            if (pesoDisponible - pesoEncomienda < 0)
                MessageBox.Show("El peso encomendado es mayor al disponible en la aeronave");
            else
            {
                pesoDisponible = pesoDisponible - pesoEncomienda;
                encomiendas.Add(new Encomienda(-1, dni, pesoEncomienda));
                listBoxPasajesYEncomiendasComprados.Items.Add("Encomienda -> DNI:" + dni + ". Peso: " + pesoEncomienda);
                hijo.Close();
            }
        }

        private void btnVerDisponibles_Click(object sender, EventArgs e)
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            camposValores.Add("ciudad_origen", new gdDataBase.ValorTipo(comboBoxOrigen.Text, SqlDbType.VarChar));
            camposValores.Add("ciudad_destino", new gdDataBase.ValorTipo(comboBoxDestino.Text, SqlDbType.VarChar));
            camposValores.Add("fecha", new gdDataBase.ValorTipo(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.DateTime));

            var ds = new gdDataBase().GetDataWithParameters("ÑUFLO.ViajesDisponiblesPara", camposValores);

            dataGridView1.DataSource = ds;
            groupBoxPasajesEncomiendas.Enabled = false;
        }

        private void btnAgregarPasaje_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada;

            if (dataGridView1.Rows.Count > 1)
                filaSeleccionada = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
            else
                filaSeleccionada = dataGridView1.Rows[dataGridView1.Rows[0].Index];

            fechaSalida = filaSeleccionada.Cells[2].FormattedValue.ToString();
            fechaLlegadaEstimada = filaSeleccionada.Cells[3].FormattedValue.ToString();
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
            fdpe.setPadre(this);
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

            fce.setPadre(this);
            fce.Show(this);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cancelarTodo(false);
        }

        public void cancelarTodo(bool vieneDeCompraEfectiva)
        {

            if (pasajes.Count > 0 || encomiendas.Count > 0)
            {
                if (!vieneDeCompraEfectiva)
                {
                    DialogResult dialogResult = MessageBox.Show("Está seguro que desea cancelar las compras registradas hasta el momento",
                        "Cancelar Compras", MessageBoxButtons.YesNo);

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
                        btnAceptar.Enabled = false;
                    }
                }
                else
                {
                    dateTimePicker1.ResetText();
                    comboBoxDestino.SelectedIndex = 0;
                    comboBoxOrigen.SelectedIndex = 0;

                    pasajes.Clear();
                    encomiendas.Clear();
                    pesoDisponible = 0;
                    listBoxPasajesYEncomiendasComprados.Items.Clear();
                    dataGridView1.ClearSelection();
                    btnAceptar.Enabled = false;
                }
            }
            groupBoxFechaYRuta.Enabled = true;
            dataGridView1.Enabled = true;
        }

        private bool validarQueNoEsteEnElVuelo(int dni)
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("dni", new gdDataBase.ValorTipo(dni.ToString(), SqlDbType.Int));
            camposValores.Add("fecha_vuelo", new gdDataBase.ValorTipo(fechaSalida, SqlDbType.DateTime));
            camposValores.Add("fecha_estimada", new gdDataBase.ValorTipo(fechaLlegadaEstimada, SqlDbType.DateTime));

            errorMensaje.Add(60034, "EL pasajero se encuentra volando en esas fechas");

            var ejecucion = new SPPureExec("ÑUFLO.ClienteNoEstaEnVuelo", camposValores, errorMensaje);

            ejecucion.Exec();

            return ejecucion.huboError();
        }

        public void setConViaje()
        {
            groupBoxFechaYRuta.Enabled = false;
            dataGridView1.Enabled = false;
        }
    }
}
