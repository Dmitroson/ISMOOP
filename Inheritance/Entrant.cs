using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Entrant : LibraryUser
    {
        protected double PointsEIT;
        protected double PointsEdDocument;
        protected string SchoolName;

        public Entrant()
        {
            PointsEIT = 190;
            PointsEdDocument = 11.3;
            SchoolName = "Zhytomyr School №17";
        }

        public Entrant(double PointsEIT, double PointsEdDocument, string SchoolName)
        {
            this.PointsEIT = PointsEIT;
            this.PointsEdDocument = PointsEdDocument;
            this.SchoolName = SchoolName;
        }

        public Entrant(string Name, string Surname, DateTime BirthDate, double PointsEIT, double PointsEdDocument, string SchoolName) : base(Name, Surname, BirthDate)
        {
            this.PointsEIT = PointsEIT;
            this.PointsEdDocument = PointsEdDocument;
            this.SchoolName = SchoolName;
        }

        public double GetPointsEIT()
        {
            return PointsEIT;
        }

        public void SetPointsEIT(double PointsEIT)
        {
            this.PointsEIT = PointsEIT;
        }

        public double GetPointsEdDocument()
        {
            return PointsEdDocument;
        }

        public void SetPointsEdDocument(double PointsEdDocument)
        {
            this.PointsEdDocument = PointsEdDocument;
        }

        public string GetSchoolName()
        {
            return SchoolName;
        }

        public void SetSchoolName(string SchoolName)
        {
            this.SchoolName = SchoolName;
        }

    }
}
