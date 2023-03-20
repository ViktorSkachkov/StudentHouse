using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_House
{
    public class Task
    {
        private String name;
        private String type;
        public Task(String name, String type)
        {
            this.name = name;
            this.type = type;
        }
        public String Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public String Type
        {
            get { return this.type; }
            private set { this.type = value; }
        }
    }
}
