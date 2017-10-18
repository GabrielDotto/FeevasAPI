using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trab1Prog4.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Direitos> Direitos { get; set; }
    }
}