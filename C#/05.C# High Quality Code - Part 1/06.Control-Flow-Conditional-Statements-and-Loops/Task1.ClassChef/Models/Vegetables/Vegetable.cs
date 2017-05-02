using Task1.ClassChef.Contracts;

namespace Task1.ClassChef.Models.Vegetables
{
    public class Vegetable : IVegetable
    {
        public Vegetable()
        {
            this.IsRotten = false;
            this.IsPeeled = false;
            this.IsCut = false;
        }

        public bool IsRotten { get; set; }

        public bool IsPeeled { get; set; }

        public bool IsCut { get; set; }
    }
}
