﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class FormRegistrarLlegadas : Form
    {
        public FormRegistrarLlegadas()
        {
            InitializeComponent();
            var ds = new gdDataBase().ExecAndGetDataSet("ÑUFLO.CiudadTipoServicio").Tables[0];
            origenBindingSource.DataSource = ds;
            destinoBindingSource.DataSource = ds;
            comboBoxOrigen.DisplayMember = "Nombre";
            comboBoxDestino.DisplayMember = "Nombre";
            comboBoxOrigen.ValueMember = "Nombre";//cambiar a id ciudad despues
            comboBoxDestino.ValueMember = "Nombre";
            fechaCoso.Format = DateTimePickerFormat.Custom;
            fechaCoso.CustomFormat = "dd/MM/yyyy    hh:mm:ss";
        }

        private void FormRegistrarLlegadas_Load(object sender, EventArgs e)
        {


            
        }

        private void btnConfirmarLlegada_Click(object sender, EventArgs e)
        {
                       if (ValidateChildren())
            {
                var camposValores = gdDataBase.newParameters();
                camposValores.Add("matricula", new gdDataBase.ValorTipo(textBoxMatricula, SqlDbType.NVarChar));
                camposValores.Add("origen", new gdDataBase.ValorTipo(comboBoxOrigen.SelectedValue, SqlDbType.NVarChar));
                camposValores.Add("destino", new gdDataBase.ValorTipo(comboBoxDestino.SelectedValue, SqlDbType.NVarChar));
                camposValores.Add("fecha_llegada", new gdDataBase.ValorTipo(fechaCoso.Value, SqlDbType.DateTime));
                if (!(new gdDataBase().Exec("ÑUFLO.ValidarRegistroLlegada", camposValores, new Dictionary<int, string>()).huboError()))
                {
                    var informeYValidacion = new FormInformeYValidacion();
                    informeYValidacion.setAeronave(textBoxMatricula.Text);
                    informeYValidacion.setFecha(fechaCoso.Value);
                    informeYValidacion.setOrigen(comboBoxOrigen.SelectedValue.ToString());
                    informeYValidacion.setDestino(comboBoxDestino.SelectedValue.ToString());
                    informeYValidacion.Show();                    
                }
            }
        }
    }
}
