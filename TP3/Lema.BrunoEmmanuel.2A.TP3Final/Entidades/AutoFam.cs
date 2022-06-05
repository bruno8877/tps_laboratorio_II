using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoFam : Vehiculo
    {

        public AutoFam()
        {

        }
        
        public AutoFam(string color, string ruedas, string modelo)
            :base(color, ruedas, modelo)
        {

        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"LOS DATOS DEL AUTO SON: {base.Mostrar()}");

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
