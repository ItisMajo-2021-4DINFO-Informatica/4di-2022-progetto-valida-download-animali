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
                // controlla parametri
                if (string.IsNullOrEmpty(keyUserId))
                    throw new ArgumentException("keyUserId parameter is either empty or null", "keyUserId");
                if (string.IsNullOrEmpty(sourceFile))
                    throw new ArgumentException("sourceFile parameter is either empty or null", "sourceFile");
                if (string.IsNullOrEmpty(encryptedFile))
                    throw new ArgumentException("encryptedFile parameter is either empty or null", "encryptedFile");
             
                using (Stream sourceFileStream = new FileStream(sourceFile, FileMode.Open))
                {
                    using (Stream encryptedFileStream = new FileStream(encryptedFile, FileMode.Create))
                    {
                   
                        gpg.BinaryPath = Path.GetDirectoryName(appPath);
                        gpg.Recipient = keyUserId;
                        //  Performa l'encryptazione
                        gpg.Encrypt(sourceFileStream, encryptedFileStream);
                        return new FileInfo(encryptedFile);
                    }
                }
            }
        public FileInfo DecryptFile(string encryptedSourceFile, string decryptedFile)
        {
            // check parameters
            if (string.IsNullOrEmpty(encryptedSourceFile))
                throw new ArgumentException("encryptedSourceFile parameter is either empty or null", "encryptedSourceFile");
            if (string.IsNullOrEmpty(decryptedFile))
                throw new ArgumentException("decryptedFile parameter is either empty or null", "decryptedFile");

            using (FileStream encryptedSourceFileStream = new FileStream(encryptedSourceFile, FileMode.Open))
            {
                //  make sure the stream is at the start.
                encryptedSourceFileStream.Position = 0;

                using (FileStream decryptedFileStream = new FileStream(decryptedFile, FileMode.Create))
                {
                    //  Specify the directory containing gpg.exe (again, not sure why).
                    gpg.BinaryPath = Path.GetDirectoryName(appPath);

                    //  Decrypt
                    gpg.Decrypt(encryptedSourceFileStream, decryptedFileStream);
                }
            }
            return new FileInfo(decryptedFile);
        }
    }
    }

