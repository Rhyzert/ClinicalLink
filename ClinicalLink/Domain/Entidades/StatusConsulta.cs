﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    [Table("STATUS_CONSULTA")]
    public class StatusConsulta
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("STATUS")]
        [StringLength(8)]
        public string Status { get; set; }

    }
}
