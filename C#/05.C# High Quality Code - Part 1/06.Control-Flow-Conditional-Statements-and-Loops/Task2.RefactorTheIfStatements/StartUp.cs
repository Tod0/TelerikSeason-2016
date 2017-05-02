using Task2.RefactorTheIfStatements.CookPotato;
using Task2.RefactorTheIfStatements.VisitCell;

namespace Task2.RefactorTheIfStatements
{
    class StartUp
    {
        static void Main()
        {
            var cooker = new Cooker();
            var potato = new Potato();

            cooker.CheckIfPotatoIsReadyForCooking(potato);

            var cellValidator = new CellValidator();

            cellValidator.VisitedCell();
        }
    }
}
