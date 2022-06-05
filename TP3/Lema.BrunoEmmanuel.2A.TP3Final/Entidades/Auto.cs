using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        private Cilindrada cilindrada;

        public enum Cilindrada
        {
            cc1400,
            cc1600,
            cc3000,
        }
        
        public Cilindrada Consumo
        {
            get
            {
                return this.cilindrada;

            }
            set
            {
                this.cilindrada = value;
            }
        }
      
        public Auto()
        {

        }
        
        public Auto(string color, string ruedas, string modelo, Cilindrada cilindrada)
            :base(color, ruedas, modelo)
        {
            this.cilindrada = cilindrada;
        }


        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"LOS DATOS DEL AUTO SON: {base.Mostrar()}");
            sb.AppendLine($"CILINDRADA DEL AUTO: {this.cilindrada}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is Auto && (Auto)obj == this;

        }
    }
}
