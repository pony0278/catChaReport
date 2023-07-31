using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace catChaWeb.Models
{
    public class CItems
    {
        public int fPId { get; set; }
        public int fPCld { get; set; }
        public string fPName { get; set; }
        public string fPDescription { get; set; }
        public byte[] fPImage { get; set; }
        public int fRQunatity { get; set; }
        public double fLotteryP { get; set; }

    }
}