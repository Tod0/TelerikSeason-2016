using System.Collections.Generic;

using Task1.ClassChef.Contracts;

namespace Task1.ClassChef.Models.Dishes
{
    public class Bowl : IDish
    {
        private IList<IVegetable> vegetables;

        public Bowl()
        {
            this.Vegetables = new List<IVegetable>();
        }

        public IList<IVegetable> Vegetables
        {
            get
            {
                return this.vegetables;
            }
            set
            {
                this.vegetables = new List<IVegetable>();
            }
        }

        public void Add(IVegetable vegetable)
        {
            this.vegetables.Add(vegetable);
        }
    }
}
