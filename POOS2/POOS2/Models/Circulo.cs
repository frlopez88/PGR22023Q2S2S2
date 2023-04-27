using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOS2.Models
{
    public class Circulo
    {
        private double radio;
        private double area;
        private double perimetro;

        public Circulo(double r) {
        
            radio = r;
            calcularArea();
            calcularPerimetro();
        }

        // un metodo de tipo void no retorna información, los metodos de tipo void en las clases 
        // por lo general son metodos (setter) que se les asocia para modificar propiedades dentro de una clase.
        public void calcularArea() {

            area = Math.PI * (Math.Pow(radio, 2));
        }

        public void calcularPerimetro()
        {
            perimetro = 2 * Math.PI * radio;

        }

        public double getRadio()
        {
            return radio;
        }

        public double getArea()
        {
            return area;
        }

        public double getPerimetro()
        {
            return perimetro;
        }

        // El metodo to string se utiliza para generar un reporte del objeto
        public override string ToString() {

            return $"El circulo ingresado tiene un radio: {radio}, perimetro: {perimetro}, area {area}";

        }

    }
}
