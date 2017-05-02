namespace EuclideanSpace.Models
{
    using System.Collections.Generic;

    public class Path : IEnumerable<Point3D>
    {
        public ICollection<Point3D> points;

        public Path()
        {
            this.points = new HashSet<Point3D>();       // HashSet contains only unique points, while List may contain the same point multiple times
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            return this.points.GetEnumerator(); 
        }

        System.Collections.IEnumerator 
            System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
