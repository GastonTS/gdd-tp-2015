using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Compra
{
    interface IDatosCompra
    {
        void setPasaje(int dni, int numeroDeButaca);
        void setEncomienda(int dni, decimal pesoEncomienda);
    }
}
