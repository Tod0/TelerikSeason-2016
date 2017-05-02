using Task1.ClassChef.Contracts;
using Task1.ClassChef.Models.Dishes;
using Task1.ClassChef.Models.Vegetables;

namespace Task1.ClassChef
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
            Bowl bowl = this.GetBowl();

            this.Peel(potato);
            this.Cut(potato);
            bowl.Add(potato);

            this.Peel(carrot);
            this.Cut(carrot);
            bowl.Add(carrot);
        }

        private Bowl GetBowl()
        {
            var bowl = new Bowl();

            return bowl;
        }

        private Carrot GetCarrot()
        {
            var carrot = new Carrot();

            return carrot;
        }

        private Potato GetPotato()
        {
            var potato = new Potato();

            return potato;
        }
        
        private void Cut(IVegetable vegetable)
        {
            vegetable.IsCut = true;
        }

        private void Peel(IVegetable vegetable)
        {
            vegetable.IsPeeled = true;
        }
    }
}
