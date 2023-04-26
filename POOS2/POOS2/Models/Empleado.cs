using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOS2.Models
{
    public class Empleado
    {
        // Encapsular: Es el proceso de definicion de caracteristicas y asegurar 
        // que estas no puedan ser modificadas sin permiso.
        private string nombre;
        private double salario;

        // Metodo Contructor (Este metodo nos sirve para inicializar o instanciar los objetos en un programa)

        public Empleado( string nm, double sl ) {

            nombre = nm;
            salario = sl;

        }

        public string getNombre() {
            return nombre;
        }

        public double getSalario()
        {
            return salario;
        }

        public double getISR() {

            return salario*0.15;
        
        }

    }
}
