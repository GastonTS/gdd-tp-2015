using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Compra
{
    interface IDatosCompra
    {
        void setPasaje(int dni, int numeroDeButaca, FormDatosPasajeroEncomienda hijo);
        void setEncomienda(int dni, decimal pesoEncomienda, FormDatosPasajeroEncomienda hijo);
    }
}
