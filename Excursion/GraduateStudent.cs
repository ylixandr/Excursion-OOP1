using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Excursion
{
    class GraduateStudent:Student
    {

        int yearAducation;
        public int YearAducation 
        {
            get { return yearAducation; }
            set { yearAducation = value; }
        }

        //public void getScholarShip()
        //{
        //    if (averageMark >= 8.0)
        //        ScolarShip = 200;
        //    else if (averageMark < 8.0)
        //        ScolarShip = 180;


        //}

        public GraduateStudent(string name, DateTime dateBirth, string sex,decimal scolarship,int yearAducation, double averageMark):base (name, dateBirth, sex, scolarship, averageMark) 
        {
            this.yearAducation = yearAducation;
        }

        new public string InfoString()
        {
            string inf = $"\nАспирант\nимя: {Name}" +
                         $"\nдата рождения: {DateBirth.ToShortDateString()}" +
                         $"\nпол: {Sex}" +
                         $"\nСтипуха: {ScolarShip}"+
                          $"\nбалл: {AverageMark}";
            inf = inf + $"\n Лет обучения: {yearAducation}";
            return inf;
        }
    }
}
