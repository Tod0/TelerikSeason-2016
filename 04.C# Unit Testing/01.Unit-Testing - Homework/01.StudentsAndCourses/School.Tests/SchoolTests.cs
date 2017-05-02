namespace School.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Models;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void School_ShouldCreateASchool_IfConstructorIsWorkingProperly()
        {
            var school = new School();

            Assert.IsNotNull(school);
        }
    }
}
