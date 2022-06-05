using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Xml<T> : IArchivo<T>
    {
        #region Metodos
        /// <summary>
        /// Guarda el objeto xml en la ruta indicada
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {

                using (XmlTextWriter write = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(write, datos);
                    return true;
                }

        }


        /// <summary>
        /// Lee los datos de la ruta indicada
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            if(File.Exists(archivo))
            {
                using (XmlTextReader reader = new XmlTextReader(archivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    datos = (T)ser.Deserialize(reader);
                }
                return true;
            }
            datos = default(T);
            return false;
            
  
        }
        #endregion
    }
}