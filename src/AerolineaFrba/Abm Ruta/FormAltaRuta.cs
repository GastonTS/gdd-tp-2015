﻿using System;
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
    public partial class FormAltaRuta : Form
    {
        public FormAltaRuta()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxOrigen.ResetText();
            comboBoxDestino.ResetText();
            comboBoxTipoServicio.ResetText();
            textBoxPrecioPasaje.Clear();
            textBoxPrecioPeso.Clear();
        }

        private void groupBoxCamposAltaRuta_Enter(object sender, EventArgs e)
        {

        }
    }
}