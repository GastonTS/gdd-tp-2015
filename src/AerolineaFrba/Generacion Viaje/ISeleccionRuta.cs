using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Generacion_Viaje
{
    interface ISeleccionRuta
    {
        void setCiudadOrigen(String origen);
        void setCiudadDestino(String destino);
        void setTipoServicio(String tipoServicio);
    }
}
