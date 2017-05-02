using EuclideanSpace.Models;
using System.IO;

namespace EuclideanSpace
{
    public static class PathStorage
    {
        public static void SavePath(Models.Path path, string filePath)
        {
            using (var writer = new StreamWriter(filePath, true))
            {
                foreach (var point in path)
                {
                    writer.WriteLine(point);
                }
            }
        }

        public static Models.Path LoadPath(string filePath)
        {
            var path = new Models.Path();
            
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    var point = Point3D.Parse(line);
                    path.AddPoint(point);
                }
            }

            return path;
        }
    }
}
