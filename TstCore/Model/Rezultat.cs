using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace TstCore.Model
{
    public partial class Rezultat
    {
        [Key]
        public DateTime setData { get; set; }
        public string rezval { get; set; }
        public string valminval { get; set; }
        public string valmaxval { get; set; }
    }
}
