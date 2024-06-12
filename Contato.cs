using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240606AgendaTelefonica
{
    public class Contato
    {
        public int id { get; set; }
        public string name { get; set; }
        public string telefone { get; set; }

        public Contato(int id, string name, string telefone)
        {
            this.id = id;
            this.name = name;
            this.telefone = telefone;
        }

        public Contato()
        {
        }
    }
}
