using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Petro", "Petrov", new DateTime(1999, 5, 6));
            Person person2 = new Person(person);

            LibraryUser library_user = new LibraryUser("Sasha", "Kotenko", new DateTime(2002, 5, 2), 1023, new DateTime(2018, 9, 1), 30);

            Entrant entrant = new Entrant(200, 11.9, "Ushomyr Gymnasium");
            entrant.SetName("Sasha");
            entrant.SetSurname("Kotenko");
            entrant.SetBirthDate(new DateTime(2002, 5, 2));
            string EntrantName = entrant.GetName();

            Student student = new Student("Andrew", "Gras", new DateTime(2001, 12, 15), 1, "15BD-POkt", "Fiz-mat", "ZDU");
            student.SetPointsEdDocument(8.2);

            Teacher teacher = new Teacher("Teacher of Programming", "Informatics", "Fiz-mat", "ZDU");
            teacher.SetName("Oleg");
            teacher.SetSurname("Taburetkin");
            teacher.SetBirthDate(new DateTime(1980, 11, 17));
            teacher.SetReadersTicketNumber(1124);
            teacher.SetDateOfIssue(new DateTime(2007, 9, 5));
            teacher.SetSizeOfReadersContribution(55);

            Teacher teacher2 = new Teacher(teacher);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
