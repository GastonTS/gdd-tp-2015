using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm
{
    public partial class FormReloaded : Form
    {
        public FormReloaded()
        {
            InitializeComponent();
        }

        protected void agregarValorCBADiccionario(ComboBox cb, Dictionary<String, gdDataBase.ValorTipo> camposValores,String nombreParam, SqlDbType tipoParam) 
        {
            if (cb.SelectedValue.ToString() != "")
                camposValores.Add(nombreParam, new gdDataBase.ValorTipo(cb.SelectedValue, tipoParam));
        }
    }
}
