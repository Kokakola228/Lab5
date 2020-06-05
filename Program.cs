using System;
using System.IO;
using struct_lab_student;

namespace Lab5
{
    class Program
    {
        static Student[] ReadData(string fileName)
        {
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill 
            
            string path = "C:\\Users\\Admin\\Desktop\\Lab5\\Lab5\\";
            string newPath = path.Insert(path.Length, fileName);
            int count = System.IO.File.ReadAllLines(newPath).Length;
            Student[] students = new Student[count];
            var stream = File.Open(newPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(stream, System.Text.Encoding.Default);
            StreamWriter sw = File.AppendText(newPath);
            for (int i = 0; i < count; i++) {
                var line = sr.ReadLine();
                Student newStudent = new Student(line);
                students[i] = newStudent;
            }

            return students;
             
        }

        static void runMenu(Student[] studs)
        {
            for (int i = 0; i < studs.Length; i++)
            {
                var infoMark = Convert.ToString(studs[i].informaticsMark);
                int number;
                bool success = Int32.TryParse(infoMark, out number);
                if (!success)
                {
                    break;
                }

                if (number == 5 && studs[i].sex == 'F')
                {
                    Console.WriteLine("Informatics mark 5 && Female ---> {0}", studs[i].surName);
                }
            }
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("data.txt");
            runMenu(studs);
        }
       
    }
}
