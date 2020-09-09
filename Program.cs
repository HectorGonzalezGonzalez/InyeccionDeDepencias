using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDepencias
{
    class Program
    {
        static void Main(string[] args)
        {
            //string msj ="";
            //Notificador notificador = new Notificador();
            //msj=notificador.EnviarCorreo();
            //Console.WriteLine(msj);
            //msj=notificador.EnviarSMS();
            //Console.WriteLine(msj);

            
            Notificador notificador = new Notificador(new Correo());
            Console.WriteLine(notificador.Ejecutar());
            notificador = new Notificador(new SMS());
            Console.WriteLine(notificador.Ejecutar());


            Console.ReadKey();
        }
    }
}
