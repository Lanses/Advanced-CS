using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Disposable
{
    public class FileExample
    {

        private string _filePath = @"C:\Users\Alexander\Desktop\ITEA_C-\Advanced";
        public void WriteToFile(string message)
        {

            using (var file = File.OpenWrite(_filePath))
            {
                using (var writer = new StreamWriter(file))
                {
                    if (file.CanSeek)
                        File.Seek(0, SeekOrigin.End);

                    writer.Write(message);
                }
            }


            //using (var memStream = new MemoryStream())

            //using (var file = File.Open(_filePath, FileMode.Open, FileAccess.ReadWrite))
            //{
            //    file.Write(Encoding.ASCII.GetBytes(message), 0, int.MaxValue);
            //}

            using (var stream = new StreamWriter(_filePath))
            {
                stream.WriteLine(message);
            }



        }
    }
}
