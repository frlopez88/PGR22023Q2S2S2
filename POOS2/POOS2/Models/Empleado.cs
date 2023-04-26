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
        private string puesto;
        private DateTime fechaIngreso;

        // Metodo Contructor (Este metodo nos sirve para inicializar o instanciar los objetos en un programa)

        public Empleado( string nm, double sl, string p, DateTime fi ) {

            nombre = nm;
            salario = sl;
            puesto = p;
            fechaIngreso = fi;

        }

        public string getNombre() {
            return nombre;
        }

        public double getSalario()
        {
            return salario;
        }

        public string getPuesto()
        {
            return puesto;
        }

        public DateTime getFechaIngreso()
        {
            return fechaIngreso;
        }

        public double getISR() {

            return salario*0.15;
        
        }

        public double aportacionIHHS() {

            double ihss=0;

            if (salario < 1500)
            {
                ihss = salario * 0.02;
            }
            else {
                ihss = salario * 0.05;
            }

            return ihss;
        }

    }
}
