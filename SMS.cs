using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDepencias
{
    public class SMS: Inotificador
    {
        public string Enviar()
        {
            return "Enviar SMS";
        }
    }
}
