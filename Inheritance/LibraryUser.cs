using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class LibraryUser : Person
    {
        protected int ReadersTicketNumber;
        protected DateTime DateOfIssue;
        protected double SizeOfReadersContribution;

        public LibraryUser()
        {
            ReadersTicketNumber = 100;
            DateOfIssue = new DateTime(2018, 1, 1);
            SizeOfReadersContribution = 10;
        }
        public LibraryUser(string name, string surname, DateTime birthdate)
        {
            this.Name = name;
            this.Surname = surname;
            this.BirthDate = birthdate;
        }

        public LibraryUser(int readersTicketNumber, DateTime dateOfIssue, double sizeOfReadersContribution)
        {
            ReadersTicketNumber = readersTicketNumber;
            DateOfIssue = dateOfIssue;
            SizeOfReadersContribution = sizeOfReadersContribution;
        }

        public LibraryUser(string Name, string Surname, DateTime Birthdate, int readersTicketNumber, DateTime dateOfIssue, double sizeOfReadersContribution) :
            base(Name, Surname, Birthdate)
        {
            ReadersTicketNumber = readersTicketNumber;
            DateOfIssue = dateOfIssue;
            SizeOfReadersContribution = sizeOfReadersContribution;
        }


        public LibraryUser(LibraryUser obj)
        {
            obj = new LibraryUser();
        }

        public int GetReadersTicketNumber()
        {
            return ReadersTicketNumber;
        }

        public void SetReadersTicketNumber(int ReadersTicketNumber)
        {
            this.ReadersTicketNumber = ReadersTicketNumber;
        }

        public DateTime GetDateOfIssue()
        {
            return DateOfIssue;
        }

        public void SetDateOfIssue(DateTime DateOfIssue)
        {
            this.DateOfIssue = DateOfIssue;
        }

        public double GetSizeOfReadersContribution()
        {
            return SizeOfReadersContribution;
        }

        public void SetSizeOfReadersContribution(double SizeOfReadersContribution)
        {
            this.SizeOfReadersContribution = SizeOfReadersContribution;
        }

        
    }
}
