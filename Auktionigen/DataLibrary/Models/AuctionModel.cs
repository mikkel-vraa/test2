﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class AuctionModel
    {
        public string Titel { get; set; }
        public int Time { get; set; }
        public float CurrentPrice { get; set; }
        public float MaxPrice { get; set; }
    }

}