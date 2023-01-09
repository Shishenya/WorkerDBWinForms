using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersDB.Models
{
    public class Worker
    {
        public int id;
        public string name;
        public string family;
        public string position;
        public int birthday;
        public int salary;

        public Worker(int id, string name, string family, string position, int birthday, int salary)
        {
            this.id = id;
            this.name = name;
            this.family = family;
            this.position = position;
            this.birthday = birthday;
            this.salary = salary;
        }

    }    
}
