using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDepencias
{
    public class Notificador
    {
        private Inotificador _inotificador { get; set; }
        public Notificador(Inotificador inotificador)
        {
            _inotificador = inotificador;
        }

        //Correo correo = new Correo();
        //SMS sms = new SMS();
        //public string EnviarCorreo()
        //{
        //    return correo.Enviar();
        //}
        //public string EnviarSMS()
        //{
        //    return sms.Enviar();
        //}
        public string Ejecutar()
        {
            return _inotificador.Enviar();
        }
    }
}
