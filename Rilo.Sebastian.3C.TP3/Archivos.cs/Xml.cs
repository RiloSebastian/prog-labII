using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        
        public bool Guardar(string archivo, T datos)
        {
            XmlTextWriter writer;
            XmlSerializer serializer;
            serializer = new XmlSerializer(typeof(T));
            writer = new XmlTextWriter(archivo, Encoding.UTF8);
            try
            {
                serializer.Serialize(writer, datos);
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            finally
            {
                writer.Close();
            }
        }

        public bool Leer(string archivo, out T datos)
        {
            XmlTextReader reader;
            XmlSerializer serializer;
            reader = new XmlTextReader(archivo);
            serializer = new XmlSerializer(typeof(T));
            try
            {
                datos = (T)serializer.Deserialize(reader);
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            finally
            {
                reader.Close();
            }
        }
    }
}