﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class StatusConsulta
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }

    }
}
