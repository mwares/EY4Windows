using System;
using System.Collections.Generic;
using System.Text;

namespace EY4Windows
{
    public class Child
    {
         private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public Child()
        {
        }
    }
}
