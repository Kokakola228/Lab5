using System;
using System.Text;
using System.Linq;

namespace struct_lab_student
{
    struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            // TODO   you SHOULD IMPLEMENT constructor with exactly this signature
            // lineWithAllData is string contating all data about one student, as described in statement
            
            var arrString = lineWithAllData.Split(' ');

            this.surName = arrString[0];
            this.firstName = arrString[1];
            this.patronymic = arrString[2];
            this.sex = Convert.ToChar(arrString[3]);
            this.dateOfBirth = arrString[4];
            this.mathematicsMark = Convert.ToChar(arrString[5]);
            this.physicsMark = Convert.ToChar(arrString[6]);
            this.informaticsMark = Convert.ToChar(arrString[7]);
            this.scholarship = Convert.ToInt32(arrString[8]);

        }
    }
}
