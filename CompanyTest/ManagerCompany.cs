using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyTest
{
    class ManagerCompany
    {
        private byte Age;

        public long numberId { get; set; }

        public string name { get; set; }

        public string lastName { get; set; }

        public byte age
        {
            set
            {
                if (value < 20 || value > 61)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.Age = value;
            }

            get { return this.Age; }
        }
    }
}



