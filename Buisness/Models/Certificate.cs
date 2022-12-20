using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Models
{
    public class Certificate
    {
        public int owner_id;
        public bool isApproved;
        public string data;
        public int id;

        public void Approve()
        {
            isApproved = true;
        }
        public void Deny()
        {
            isApproved = false;
        }
    }
}
