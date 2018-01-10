using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursividad
{
    class Program
    {

        private float ambito = 1;
        public float recursividad(float x, float y) {
            float resultado = 0;
            ambito++;
            if (ambito != y)
                resultado = recursividad(x, y);
            else
                resultado = x;
            ambito--;
            return resultado * x;
        }
        static void Main(string[] args)
        {
            Program programa = new Program();
            float resultado = programa.recursividad(9,7);
        }
    }
}
