using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using Microsoft.Win32;
namespace AnimaliValidaDownloadApp
{
    class ClasseDelloSha256
    {
        public string SHA256CheckSum(string filePath)                     
        {
            using (SHA256 SHA256 = SHA256Managed.Create())
            {
                using (FileStream fileStream = File.OpenRead(filePath))
                return (BitConverter.ToString(SHA256.ComputeHash(fileStream)).Replace("-", "")).ToLower();

            }
        }


        public string LetturaInterna(string percorso)
        {
            string linea = "";
            string ShaFile = "";
            string[] elementi;

            using (FileStream flusso = new FileStream(percorso, FileMode.Open, FileAccess.Read))
            {

                StreamReader reader = new StreamReader(flusso);
                while(!reader.EndOfStream)
                {
                    linea = reader.ReadLine();
                }
                elementi = linea.Split(' ');
                ShaFile = elementi[0];

            }
            return ShaFile;
        }

      
    }
}