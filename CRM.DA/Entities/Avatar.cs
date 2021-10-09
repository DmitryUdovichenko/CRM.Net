﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Entities
{
    public class Avatar
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}