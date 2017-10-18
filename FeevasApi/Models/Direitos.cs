using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeevasApi.Models
{
    public class Direitos
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}