using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ZadanieC
{
    class XMLWriter
    {
        public static void saveData(object myClass, string fileName)
        {
            StreamWriter writer = null;
            try
            {
                XmlSerializer xmlSer = new XmlSerializer(myClass.GetType());
                writer = new StreamWriter(fileName);
                xmlSer.Serialize(writer, myClass);

            }
            finally
            {
                if (writer != null)
                    writer.Close();
                writer = null;
            }
            
        }
    }
}
