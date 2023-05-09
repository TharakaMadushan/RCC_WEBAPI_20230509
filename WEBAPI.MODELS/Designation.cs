using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI.MODELS
{
    public class Designation
    {
        [MaxLength(50)]
        public string DesigCode { get; set; }
        [MaxLength(100)]
        public string DesigDes { get; set; }
        public bool Status { get; set; }
        public string EnterUser { get; set;}
        public DateTime EnterDate { get; set; }
         
    }
}
