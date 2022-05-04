using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace naman11.Models
{
    public class employess
    {
        [Key]
        public int eid { get; set; }
        public string ename { get; set; }
        public string gender{ get; set; }
        public int salary { get; set; }
        public string citys { get; set; }
        public post post { get; set; }

    }
}