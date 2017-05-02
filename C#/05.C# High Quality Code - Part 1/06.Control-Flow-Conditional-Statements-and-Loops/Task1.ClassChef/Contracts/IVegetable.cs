namespace Task1.ClassChef.Contracts
{
    public interface IVegetable
    {
        bool IsRotten { get; set; }

        bool IsPeeled { get; set; }

        bool IsCut { get; set; }
    }
}
