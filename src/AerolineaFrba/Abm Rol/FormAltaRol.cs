using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class FormAltaRol : Abm.Alta
    {
        bool modificacion = false;
        String nombreViejo;
        FormSeleccionRol padre;
        private Control primerControlInvalido;

        public FormAltaRol()
        {
            InitializeComponent();
        }

        private void FormAltaRol_Load(object sender, EventArgs e)
        {
            var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.TodasLasFuncionalidades", null);
            comboBoxFuncionalidades.DataSource = dt;
            comboBoxFuncionalidades.DisplayMember = dt.Columns[0].ColumnName;

            textBoxNombre.Enabled = !modificacion;
            checkBox1.Visible = modificacion;

        }

        private void textBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNombre.Text.Trim() == "")
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            if (!modificacion)
                textBoxNombre.Clear();

            comboBoxFuncionalidades.ResetText();
            listBoxFuncionalidades.Items.Clear();
            btnQuitar.Enabled = false;
        }

        protected override void guardarPosta()
        {
            try
            {
                if (!modificacion)
                {
                    darDeAltaRol();
                    agregarFuncionalidades();
                    limpiar();
                }
                else
                {
                    cambiarNombre();
                    actualizarRol();
                    padre.actualizate();
                    this.Close();
                }
            }
            catch (RolException e)
            {
            }

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (!listBoxFuncionalidades.Items.Contains(comboBoxFuncionalidades.Text))
                listBoxFuncionalidades.Items.Add(comboBoxFuncionalidades.Text);
        }

        private void listBoxFuncionalidades_SelectedValueChanged(object sender, EventArgs e)
        {
            btnQuitar.Enabled = true;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            listBoxFuncionalidades.Items.Remove(listBoxFuncionalidades.SelectedItem);

            if (listBoxFuncionalidades.Items.Count == 0)
                btnQuitar.Enabled = false;
        }

        public void setNombreRol(String nombreRol)
        {            
            this.Text = "Modificación de Rol";
            modificacion = true;
            nombreViejo = nombreRol;
            textBoxNombre.Text = nombreViejo;

            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            camposValores.Add("nombre_rol", new gdDataBase.ValorTipo(textBoxNombre.Text, SqlDbType.VarChar));

            var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.FuncionalidadesDe", camposValores);
            
            for(int i=0;i< dt.Rows.Count;i++)
            {
                listBoxFuncionalidades.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }

        private void darDeAltaRol()
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("nombre_rol", new gdDataBase.ValorTipo(textBoxNombre.Text, SqlDbType.VarChar));
            
            errorMensaje.Add(60005, "Ese rol ya existe en el sistema. Ingrese uno distinto...");

            var executer = new SPPureExec("ÑUFLO.CrearRol", camposValores, errorMensaje, "Rol registrada correctamente");

            executer.Exec();

            if (executer.huboError()) throw new RolException();
        }

        private void agregarFuncionalidades()
        {
            for (int i = 0; i < listBoxFuncionalidades.Items.Count; i++)
            {
                Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
                Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

                camposValores.Add("nombre_rol", new gdDataBase.ValorTipo(textBoxNombre.Text, SqlDbType.VarChar));
                camposValores.Add("descripcion", new gdDataBase.ValorTipo(listBoxFuncionalidades.Items[i].ToString()
                    , SqlDbType.VarChar));

                new gdDataBase().Exec("ÑUFLO.AsignarFuncionalidadARol", camposValores, errorMensaje, null);
            }
        }

        private void actualizarRol()
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            camposValores.Add("nombre_rol", new gdDataBase.ValorTipo(textBoxNombre.Text, SqlDbType.VarChar));

            new gdDataBase().GetDataWithParameters("ÑUFLO.BorrarFuncionalidadesDe", camposValores);

            agregarFuncionalidades();

            MessageBox.Show("Rol modificado correctamente"); //no valido nada, porque no hay posibilidad de error...
        }

        private void cambiarNombre()
        {
            if (textBoxNombre.Text != nombreViejo)
            {
                Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
                camposValores.Add("nombre_old", new gdDataBase.ValorTipo(nombreViejo, SqlDbType.VarChar));
                camposValores.Add("nombre", new gdDataBase.ValorTipo(textBoxNombre.Text, SqlDbType.VarChar));

                Dictionary<int, String> errorMensaje = new Dictionary<int, string>();
                errorMensaje.Add(60011, "No puede cambiar el nombre a un nombre de rol ya existente");

                var executer = new SPPureExec("ÑUFLO.CambiarNombreDeRol", camposValores, errorMensaje);

                executer.Exec();

                if (executer.huboError()) throw new RolException();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                textBoxNombre.Text = nombreViejo;
            textBoxNombre.Enabled = checkBox1.Checked;
        }

        public void setPadre(FormSeleccionRol padre)
        {
            this.padre = padre;
        }

        private void listBoxFuncionalidades_Validating(object sender, CancelEventArgs e)
        {
            if (listBoxFuncionalidades.Items.Count != 0)
            {
                errorProvider1.Clear();
                e.Cancel = false;
            }
            else 
            {
                errorProvider1.SetError(listBoxFuncionalidades, "Es obligatorio al menos una funcionalidad para crear un rol");
                e.Cancel = true;
            }
        }
    }
}
