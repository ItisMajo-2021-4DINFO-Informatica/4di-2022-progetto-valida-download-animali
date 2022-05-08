using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Starksoft.Cryptography.OpenPGP;
using static AnimaliValidaDownloadApp.Contracts;

namespace AnimaliValidaDownloadApp
{
        public class EncryptionService : IEncryptionService
    {
            private GnuPG gpg = new GnuPG();
            private string appPath;

            public EncryptionService()
            {
            }

            public EncryptionService(string appPath)
            {
                this.appPath = appPath;
            }

            public FileInfo EncryptFile(string keyUserId, string sourceFile, string encryptedFile)
            {
                // check parameters
                if (string.IsNullOrEmpty(keyUserId))
                    throw new ArgumentException("keyUserId parameter is either empty or null", "keyUserId");
                if (string.IsNullOrEmpty(sourceFile))
                    throw new ArgumentException("sourceFile parameter is either empty or null", "sourceFile");
                if (string.IsNullOrEmpty(encryptedFile))
                    throw new ArgumentException("encryptedFile parameter is either empty or null", "encryptedFile");
                // Create streams - one for the unencrypted source file and one for the decrypted destination file
                using (Stream sourceFileStream = new FileStream(sourceFile, FileMode.Open))
                {
                    using (Stream encryptedFileStream = new FileStream(encryptedFile, FileMode.Create))
                    {
                        //  Specify the directory containing gpg.exe (not sure why).
                        gpg.BinaryPath = Path.GetDirectoryName(appPath);
                        gpg.Recipient = keyUserId;
                        //  Perform encryption
                        gpg.Encrypt(sourceFileStream, encryptedFileStream);
                        return new FileInfo(encryptedFile);
                    }
                }
            }
        }
    }

