namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Models;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void Course_ShouldCreateACourse_IfConstructorIsWorkingProperly()
        {
            var course = new Course();

            Assert.IsNotNull(course);
        }

        [TestMethod]
        public void Course_ShouldAddStudent_IfAddStudentIsWorkingProperly()
        {
            var course = new Course();
            var student = new Student("Gosho");
            var expectedStudentCount = 1;

            course.AddStudent(student);
            var actualStudentCount = course.Students.Count;

            Assert.AreEqual(expectedStudentCount, actualStudentCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_ShouldThrowAnException_IfAddStudentWhenCourseIsFull()
        {
            var course = new Course();
            var student = new Student("Gosho");

            for (int i = 0; i < 31; i++)
            {
                course.AddStudent(student);
            }
        }

        [TestMethod]
        public void Course_ShouldRemoveStudent_IfRemoveStudentIsWorkingProperly()
        {
            var course = new Course();
            var student = new Student("Gosho");
            var expectedStudentCount = 0;

            course.AddStudent(student);
            course.RemoveStudent(student);
            var actualStudentCount = course.Students.Count;

            Assert.AreEqual(expectedStudentCount, actualStudentCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_ShouldThrowAnException_IfRemoveStudentWhenCourseIsEmpty()
        {
            var course = new Course();
            var student = new Student("Gosho");

            course.RemoveStudent(student);
        }
    }
}
