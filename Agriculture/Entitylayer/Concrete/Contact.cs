using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string Mail { get; set; }
        public DateTime Date { get; set; }
    }
}
