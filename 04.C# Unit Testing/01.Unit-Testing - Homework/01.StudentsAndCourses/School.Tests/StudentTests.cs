namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Models;
    using Utils;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void Student_ShouldCreateAStudent_IfConstructorIsWorkingProperly()
        {
            var student = new Student("Gosho");

            Assert.IsNotNull(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Student_ShouldThrowAnException_IfNameIsEmpty()
        {
            var student = new Student("");
        }

        [TestMethod]
        public void Student_ShouldReturnTrue_IfStudentIDIsWithinRange()
        {
            var student = new Student("Gosho");
            bool isWithinRange = false;

            if (student.Id >= Constants.MinimumIdNumber && student.Id <= Constants.MaximumIdNumber)
            {
                isWithinRange = true;
            }

            Assert.IsTrue(isWithinRange);
        }
    }
}
