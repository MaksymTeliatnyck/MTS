﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MTS.DAL.Entities.Models
{
   public class MtsGosts
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
