using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    public class Retangulo
    {
        //Construtor escreva ctor + tab
        public Retangulo()
        {
            this.Altura = 0;
            this.Base = 0;
        }
        //Propriedade escreva propfull + tab

        //base do retangulo
        private Double baseret;

        public Double Base
        {
            get { return baseret; }
            set { 
                if (value >= 0) baseret = value;
                else baseret = 0;
            }
        }
        //altura do retangulo
        private Double altret;

        public Double Altura
        {
            get { return altret; }
            set {
                if (value > -0) altret = value;
                else altret = 0;
            }
        }
    
        public Double Area
        {
            get { return altret*baseret; }
        }
        //Método
        public void ExibeDados()
        {
            Console.WriteLine("Base: " + this.Base);
            Console.WriteLine("Altura: " + this.Altura);
            Console.WriteLine("Area: " + this.Area);
        }

    }
}
