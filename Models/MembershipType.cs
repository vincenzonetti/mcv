using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Veenca.Models
{
    public class MembershipType
    {
        public byte id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonth { get; set; }

        [Required]
        [StringLength(255)]
        public string textAbbonamento { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte nonPagah = 1;
    }
}