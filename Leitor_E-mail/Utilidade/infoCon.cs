using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_E_mail.Utilidade
{
    static class infoCon
    {
        public static string server { get; set; }
        public static string serverSMTP { get; set; }
        public static string portaSMTP { get; set; }
        public static string serverPOP { get; set; }
        public static string portaPOP { get; set; }
        public static bool ssl { get; set; }
    }
}
