namespace StudentClass.Models
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    using Enumerations;
    using Utils;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssnNumber;
        private string address;
        private string phone;
        private string email;
        private string course;
        private SpecialtyType specialty;
        private UniversityType university;
        private FacultyType faculty;

        public Student(
            string firstName,
            string middleName,
            string lastName,
            int ssnNumber,
            string address,
            string phone,
            string email,
            string course,
            SpecialtyType specialty,
            UniversityType university,
            FacultyType faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssnNumber;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                Validator.NullVerification(value);
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            private set
            {
                Validator.NullVerification(value);
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                Validator.NullVerification(value);
                this.lastName = value;
            }
        }

        public int SSN
        {
            get
            {
                return this.ssnNumber;
            }

            private set
            {
                Validator.ZeroOrNegative(value);
                this.ssnNumber = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            private set
            {
                Validator.NullVerification(value);
                this.address = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            internal set
            {
                Validator.NullVerification(value);
                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            internal set
            {
                Validator.NullVerification(value);
                this.email = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }

            internal set
            {
                Validator.NullVerification(value);
                this.course = value;
            }
        }

        public SpecialtyType Specialty { get; internal set; }

        public UniversityType University { get; internal set; }

        public FacultyType Faculty { get; internal set; }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !firstStudent.Equals(secondStudent);
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (this.SSN == student.SSN)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Student data");
            builder.AppendLine(new string('=', 50));
            builder.AppendLine($"Full name : {this.FirstName} {this.MiddleName} {this.LastName}");
            builder.AppendLine($"SSN Number : {this.SSN}");
            builder.AppendLine($"Adress: {this.Address}");
            builder.AppendLine($"Phone number : {this.Phone}");
            builder.AppendLine($"Email : {this.Email}");
            builder.AppendLine($"Course : {this.Course}");
            builder.AppendLine($"Specialty : {this.Specialty}");
            builder.AppendLine($"University : {this.University}");
            builder.AppendLine($"Faculty : {this.Faculty}");

            return builder.ToString();
        }

        public override int GetHashCode()
        {
            return (this.SSN.GetHashCode() + this.Phone.GetHashCode());
        }

        public object Clone()
        {
            return new Student(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.SSN,
                this.Address,
                this.Phone,
                this.Email,
                this.Course,
                this.Specialty,
                this.University,
                this.Faculty);
        }

        public int CompareTo(Student otherStudent)
        {
            var stringCompare = new List<Student> { this, otherStudent };
            Student sorted;
            if (this.FirstName != otherStudent.FirstName && this.MiddleName != otherStudent.MiddleName && this.LastName != otherStudent.LastName)
            {
                sorted = stringCompare
                    .OrderBy(x => x.FirstName)
                    .ThenBy(x => x.MiddleName)
                    .ThenBy(x => x.LastName)
                    .ToList()
                    .FirstOrDefault();

                if (sorted == this)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else if (this.SSN != otherStudent.SSN)
            {
                sorted = stringCompare
                    .OrderBy(x => x.SSN)
                    .ToList()
                    .FirstOrDefault();

                if (this.SSN == sorted.SSN)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
