using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OSRS_Charts.Data
{
    public class Item
    {
        public int ItemID { get; set; }

        [MaxLength(500)]
        public string Name { get; set; }
    }
}
