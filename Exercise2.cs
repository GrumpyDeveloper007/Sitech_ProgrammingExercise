using System;
using System.IO;
using System.Security.Cryptography;

namespace Sitech_ProgrammingExercise
{
    public partial class MainWindow
    {
        // this method will be called several times with paths to 2 files.
        // the method should return true if the file contents match (files are equal)
        // and false if the file contents do not match.
        public bool Exercise2(string filePath1, string filePath2)
        {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;

            // Open the two files.
            using (fs1 = new FileStream(filePath1, FileMode.Open, FileAccess.Read))
            {
                using (fs2 = new FileStream(filePath2, FileMode.Open, FileAccess.Read))
                {

                    // Check the file sizes. If they are not the same, the files 
                    // are not the same.
                    if (fs1.Length != fs2.Length)
                    {
                        return false;
                    }

                    // Read and compare a byte from each file until either a
                    // non-matching set of bytes is found or until the end of
                    // file1 is reached.
                    do
                    {
                        // Read one byte from each file.
                        file1byte = fs1.ReadByte();
                        file2byte = fs2.ReadByte();
                    }
                    while ((file1byte == file2byte) && (file1byte != -1));

                }
            }

            // Return the success of the comparison. "file1byte" is 
            // equal to "file2byte" at this point only if the files are 
            // the same.
            return ((file1byte - file2byte) == 0);
        }
    }
}
