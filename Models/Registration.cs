﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agence.Models
{
    public class Registration
    {
        public int RegId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}