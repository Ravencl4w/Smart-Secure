using SmartSecure.Domain.Models.SmartSecure;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSecure.Domain.Models.SmartSecure
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
