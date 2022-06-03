using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSecure.Domain.Models.SmartSecure
{
    public class Persona
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Tag Tag { get; set; }
        public string CompleteName { get; set; }
        public string Photo { get; set; }
    }
}

