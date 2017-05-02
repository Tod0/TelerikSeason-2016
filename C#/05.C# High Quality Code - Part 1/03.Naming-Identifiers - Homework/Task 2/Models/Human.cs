namespace Task_2.Models
{
    using Enumerations.People;

    public class Human
    {
        public Human(int age)
        {
            this.Age = age;

            if (age % 2 == 0)
            {
                this.Name = "John";
                this.Gender = GenderType.Male;
            }
            else
            {
                this.Name = "Penka";
                this.Gender = GenderType.Female;
            }
        }

        public GenderType Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
