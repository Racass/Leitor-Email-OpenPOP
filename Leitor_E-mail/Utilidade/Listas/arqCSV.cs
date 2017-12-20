using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_E_mail.Utilidade.Listas
{
    class arqCSV
    {
        public string server { get; set; }
        public string serverSMTP { get; set; }
        public string portaSMTP { get; set; }
        public string serverPOP { get; set; }
        public string portaPOP { get; set; }
        public bool ssl { get; set; }
    }
}
