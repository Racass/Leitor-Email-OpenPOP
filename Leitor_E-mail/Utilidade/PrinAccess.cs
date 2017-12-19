using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leitor_E_mail.Utilidade;

namespace Leitor_E_mail.Utilidade
{
    static class PrinAccess
    {
        public static int qtd { get; set; }
        public static void ControlaBar()
        {
            if (Referencia.refPrin.InvokeRequired)
            {
                Referencia.refPrin.Invoke(new System.Windows.Forms.MethodInvoker(ControlaBar));
                return;
            }
            if (qtd <= Referencia.refPrin.progresso.Maximum)
                Referencia.refPrin.progresso.Value = qtd;
        }

        public static void AttBinding()
        {
            if (Referencia.refPrin.InvokeRequired)
            {
                Referencia.refPrin.Invoke(new System.Windows.Forms.MethodInvoker(AttBinding));
                return;
            }
            Referencia.refPrin.AtualizarDataBindings();
        }

        public static void AttBtn()
        {
            if (Referencia.refPrin.InvokeRequired)
            {
                Referencia.refPrin.Invoke(new System.Windows.Forms.MethodInvoker(AttBtn));
                return;
            }
            Referencia.refPrin.ControlButtons(true);
        }
    }
}
