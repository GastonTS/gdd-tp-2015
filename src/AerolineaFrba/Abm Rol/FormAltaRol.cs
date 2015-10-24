﻿using System;
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

        override public String MsgExito { get{return "Crea Rol correctamente";}}

        override public String MsgError { get{return"Error al crear Rol. Ingresar los campos correctamente";}}

        private void textBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNombre.Text.Trim() == "")
            {
                errorProvider.SetError(textBoxNombre, "Debe ingresar un nombre de Rol");
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
                e.Cancel = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            comboBoxFuncionalidades.ResetText();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.guardar();
        }

        private void FormAltaRol_Load(object sender, EventArgs e)
        {

        }
    }
}