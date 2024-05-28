using System;
using System.Collections.Generic;

#nullable disable

namespace transport.Models
{
    public partial class City
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public int SofiaDistance { get; set; }
    }
}
