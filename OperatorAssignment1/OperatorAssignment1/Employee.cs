using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignment1
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee em1, Employee em2)
        {
            if (em1.Id == em2.Id)
            {
                return true;//something is wrong;
            }
            else
            {
                return false; // it is right.
            }
        }
        public static bool operator !=(Employee em1, Employee em2)
        {
            if (em1.Id != em2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
