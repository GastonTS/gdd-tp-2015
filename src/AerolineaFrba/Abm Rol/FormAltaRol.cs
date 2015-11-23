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
        public FormAltaRol()
        {
            InitializeComponent();
        }

        private void FormAltaRol_Load(object sender, EventArgs e)
        {
            var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.TodasLasFuncionalidades", null);
            comboBoxFuncionalidades.DataSource = dt;
            comboBoxFuncionalidades.DisplayMember = dt.Columns[0].ColumnName;
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
            textBoxNombre.Clear();
            comboBoxFuncionalidades.ResetText();
            listBoxFuncionalidades.Items.Clear();
            btnQuitar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.guardar();
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

    }
}
