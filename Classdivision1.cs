using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Espacio de nombre
namespace division
{
    //Clase
    internal class Classdivision
    {
        //Atributos, caractersiticas, campos
        private double n1;
        private double n2;

        public Classdivision(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        //Constructor
        public Classdivision(double n1)
        {
            this.n1 = n1;
        }

        //Método
        public double division()
        {
            return (n1 / n2);
        }
    }
}