using System;
using System.Collections.Generic;
using System.IO;

namespace Leitor_E_mail.Utilidade
{
    class WriteCSV
    {
        public void WriteToCSV(string[] msg, bool append = true)
        {
            using (StreamWriter escritor = new StreamWriter(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory) + @"\Resources\server.csv", append))
            {
                for(int i = 0; i < msg.Length; i++)
                {
                    escritor.WriteLine(msg[i]);
                }
            }
        }
    }
}
