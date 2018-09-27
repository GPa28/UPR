using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UltimatePowerRankings.Models
{
    public class TopTenList
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string One { get; set; }

        public string Two { get; set; }

        public string Three { get; set; }
        public string Four { get; set; }
        public string Five { get; set; }
        public string Six { get; set; }
        public string Seven { get; set; }
        public string Eight { get; set; }
        public string Nine { get; set; }
        public string Ten { get; set; }
    }
}
