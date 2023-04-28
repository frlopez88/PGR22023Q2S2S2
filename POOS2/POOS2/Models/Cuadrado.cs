using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOS2.Models
{
   public class Cuadrado
    {

        private double area;
        private double perimetro;
        private double lado1;
        private double lado2;

        // Metodo Constructor 
        // Sirve para inicializar una clase 
        // retorna un objeto nuevo
        // como se llama lo que va dentro los parentesis de un metodo? R// = Parametros (Es información que recibe un metodo)
        public Cuadrado( double l , double l2 )
        {
            lado1 = l;
            lado2= l2;
            calculoArea();
            calculoPerimetro();
        }

        // Los metodos void no retorna informacion 
        // Los metodos void se utilizan para actulizar caracteristicas de la clase acorde a reglas
        private void calculoArea() {

            area = lado2 * lado1;
            
        }

        private void calculoPerimetro() {

            perimetro = (lado1 + lado2) * 2;

        }


        public override string ToString()
        {
            return $" El cuadrado tiene perimetro {perimetro} y area {area} ";
        }



    }
}
