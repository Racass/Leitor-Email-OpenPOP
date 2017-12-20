using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_E_mail
{
    public class E_mail
    {
        public string Id { get; set; }
        public string Assunto { get; set; }
        public string De { get; set; }
        public string Para { get; set; }
        public DateTime Data { get; set; }
        public string ConteudoTexto { get; set; }
        public string ConteudoHtml { get; set; }
    }
}
