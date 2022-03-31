using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace AnimaliValidaDownloadApp
{
    class ClasseDelloSha256
    {
        public string SHA256CheckSum (string filePath)
        {
            using (SHA256 SHA256 = SHA256Managed.Create())
            {
                using (FileStream fileStream = File.OpenRead(filePath))
                    return (BitConverter.ToString(SHA256.ComputeHash(fileStream)).Replace("-", "")).ToLower();
                
            }
        }
      
    }
}