using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnimaliValidaDownloadApp
{
    class Contracts
    {
        public interface IEncryptionService
        {
            FileInfo EncryptFile(string keyUserId, string sourceFile, string encryptedFile);
            FileInfo DecryptFile(string encryptedSourceFile, string decryptedFile);
          
        }
    }
}
