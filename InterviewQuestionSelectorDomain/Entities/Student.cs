using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestionSelectorDomain.Entities
{
    class Student
    {
        public Student(string firstName, string lastName, int studentID)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentID = studentID;
        }

        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public int StudentID { get; set; }
    }
}
