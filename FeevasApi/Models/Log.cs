﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeevasApi.Models
{
    public class Log
    {
        public int ID { get; set; }
        public string Acao { get; set; }
        public DateTime Data { get; set; }
        public Usuario Usuario { get; set; }
    }
}