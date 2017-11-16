using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace OtherShit
{
    public class Student
    {
        private readonly Shcolarship shcolarship;

        public Student(string firstName, string lastName, string middleName, string speciality, decimal grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.Speciality = speciality;
            this.Grade = grade;
            this.shcolarship = new Shcolarship(this.Grade);
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Speciality { get; set; }

        public decimal Grade { get; set; }

        public override string ToString()
        {
            return $"Student: {this.FirstName} {this.LastName} {this.MiddleName} {Environment.NewLine}" +
                   $"Speciality: {this.Speciality} {Environment.NewLine}" +
                   $"Grade: {this.Grade}{Environment.NewLine}" +
                   $"Scholarship: {this.shcolarship.Money}";
        }
    }
}

