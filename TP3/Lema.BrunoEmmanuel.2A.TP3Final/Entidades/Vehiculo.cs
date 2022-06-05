using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        private string color;
        private string ruedas;
        private string modelo;

        public enum ETipo
        {
            AutoDeportivo,
            AutoFamiliar,
        }

        public string Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
            }
        }

        public string Ruedas
        {
            get
            {
                return this.ruedas;
            }

            set
            {
                this.ruedas = value;
            }

        }

        public string Modelo
        {
            get
            {
                return this.modelo;
            }

            set
            {
                this.modelo = value;
            }
        }

        public Vehiculo()
        {
        }

        public Vehiculo(string color, string ruedas, string modelo)
        {
            this.color = color;
            this.ruedas = ruedas;
            this.modelo = modelo;
        }

        public static bool operator ==(Vehiculo a, Vehiculo b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }

        protected virtual string Mostrar()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"COLOR :{this.color}");
            sb.AppendLine($"RUEDAS :{this.ruedas}");
            sb.AppendLine($"MODELO: {this.modelo}");

            return sb.ToString();
        }
    }
}
