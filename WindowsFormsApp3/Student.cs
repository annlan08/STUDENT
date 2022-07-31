using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Student
    {
        public Student()
        {

        }



        public Student(int T,Random ran)
        {
            ID = T;
            Name = _names[T];
            Chinese = ran.Next(50,101);
            Engilsh = ran.Next(50,101);
            Math = ran.Next(50, 101);

        }

        
        private int[] _grades = new int[3];
        private string[] _names = { "Apple", "Ban", "Cat", "Dog","Egg","Fox","GG","Hans","Ivry","Jack","Kat","Lee","Make","Nox" };
        public int studentCounts { get { return _names.Length; } }

        public int ID { get; set; }
        public string Name { get; set; }


        public int Chinese
        {
            get { return _grades[0]; }
            set { _grades[0] = value; }
        }


        public int Engilsh
        {
            get { return _grades[1]; }
            set { _grades[1] = value; }
        }

        public int Math
        {
            get { return _grades[2]; }
            set { _grades[2] = value; }
        }

        public int Sum { get { return _grades.Sum(); } }
        public int Max { get { return _grades.Max(); } }
        public int Min { get { return _grades.Min(); } }
        public double Avg { get { return _grades.Average(); } }

    }
}
