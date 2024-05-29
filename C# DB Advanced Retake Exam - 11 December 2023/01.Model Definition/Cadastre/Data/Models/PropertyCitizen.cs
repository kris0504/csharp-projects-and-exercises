﻿using Cadastre.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastre.Data.Models
{
    public class PropertyCitizen
    {
        [ForeignKey(nameof(PropertyId))]
        public int PropertyId { get; set; }
        public Property Property { get; set; }
        [ForeignKey(nameof(CitizenId))]
        public int CitizenId { get; set; }
        public Citizen Citizen { get;}
    }
}
//•	PropertyId – integer, Primary Key, foreign key (required)
//•	Property – Property
//•	CitizenId – integer, Primary Key, foreign key (required)
//•	Citizen – Citizen
