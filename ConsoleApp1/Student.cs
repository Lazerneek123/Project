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
            surName = null;
            firstName = null;
            patronymic = null;
            sex = 'F';
            dateOfBirth = null;
            mathematicsMark = '5';
            physicsMark = '5';
            informaticsMark = '5';
            scholarship = 1200;

            lineWithAllData = surName + firstName + physicsMark + sex + dateOfBirth + mathematicsMark + physicsMark + informaticsMark + scholarship;
            
            // ТОДО, ЩО БУТЕ ВІДБУДИТИ конструктор із саме цим рядком підпису lineWithAllData - це рядок, що містить усі дані про одного учня, як описано у виписці
        }
    }
}
