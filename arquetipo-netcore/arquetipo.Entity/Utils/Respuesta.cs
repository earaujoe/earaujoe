﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arquetipo.Entity.Utils
{
    public class Respuesta
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Resultado { get; set; }
    }
}
