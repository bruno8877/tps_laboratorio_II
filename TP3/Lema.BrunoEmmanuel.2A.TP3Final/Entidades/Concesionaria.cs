using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Concesionaria
    {
        public List<Vehiculo> ListVehiculo;
        public int stockConcesionaria;
        
        public int stockAutos
        {
            get => stockConcesionaria;
             set
             {
                if(value>=0)
                {
                    this.stockConcesionaria = value;
                }
            
             }
        }
        
        public List<Vehiculo> Vehiculos
        {
            get => this.ListVehiculo;
            set
            {
                this.ListVehiculo = value;
            }
        }
        
        public Concesionaria()
        {
            this.ListVehiculo = new List<Vehiculo>();
        }
        
        public Concesionaria(int stockConcesionaria)
            :this()
        {
            this.stockAutos = stockConcesionaria;
        }

        public static bool operator ==(Concesionaria c, Vehiculo v)
        {
            bool retorno = false;

            foreach (Vehiculo item in c.ListVehiculo)
            {
                if (v.Equals(item))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Concesionaria c, Vehiculo v)
        {
            return !(c == v);
        }

        public static Concesionaria operator +(Concesionaria c, Vehiculo v)
        {
            if (!(c is null) && !(v is null))
            {
                if ((v is Auto) || (v is AutoFam))
                {
                    c.AgregarVehiculo(v);
                }
            }
            return c;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"STOCK DE AUTOS: {this.stockAutos}");
            foreach (Vehiculo item in Vehiculos)
            {
                sb.Append(item.ToString());
                sb.Append("________________________________________________________________\n");
            }
            return sb.ToString();
        }


        private void AgregarVehiculo(Vehiculo v)
        {
            this.ListVehiculo.Add(v);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
