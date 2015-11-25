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
        bool modificacion = false;

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
            if (!modificacion)
                textBoxNombre.Clear();

            comboBoxFuncionalidades.ResetText();
            listBoxFuncionalidades.Items.Clear();
            btnQuitar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!modificacion)
            {
                darDeAltaRol();
                agregarFuncionalidades();
            }
            else
                actualizarRol();

            //this.guardar(); No estaría funcionando esto como uno espera. Pero es una buena idea
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
            textBoxNombre.Enabled = false;
            textBoxNombre.Text = nombreRol;

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

            new gdDataBase().Exec("ÑUFLO.CrearRol", camposValores, errorMensaje, "Rol registrada correctamente");
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
    }
}
