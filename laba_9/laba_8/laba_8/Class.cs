using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    public class Class
    {
        public int ID{ get; set; }
        public string Name { get; set; } = string.Empty;
        public int Years { get; set; }
        public int Semester { get; set; }
        public int CountOfLabs { get; set; }
        public int CountOfLectrs { get; set; }
        public int CheckType { get; set; }

        public Class(int id, string name, int sem, int year, int labs, int lect, int type)
        {
            ID = id;
            Name = name;
            Years = year;
            Semester = sem;
            CountOfLabs = labs;
            CountOfLectrs = lect;
            CheckType = type;
        }
        public Class()
        {
            ID = -1;
        }
    }
}
