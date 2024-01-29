using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace GraphicApp.FileHandler
{
    public static class FileHandler
    {



        public static void SaveToFile(List<Shape> shapes, string fileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Shape>));

                using (TextWriter writer = new StreamWriter(fileName))
                {
                    serializer.Serialize(writer, shapes);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving file: {ex.Message}");
            }
        }
    

        public static List<Shape> Load(string filePath)
        {
            List<Shape> shapes = null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Shape>));

                using (StreamReader reader = new StreamReader(filePath))
                {
                    shapes = (List<Shape>)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., file not found, invalid XML, etc.)
                Console.WriteLine($"Error reading XML file: {ex.Message}");
            }

            return shapes;
        }
    }
}
