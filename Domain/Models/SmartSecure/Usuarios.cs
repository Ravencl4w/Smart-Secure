using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SmartSecure.Domain.Models.SmartSecure
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public Condominio Condominio { get; set; }
    }
}
