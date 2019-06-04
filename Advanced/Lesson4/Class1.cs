using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{

   public class Class1
    {
        internal void SaveFile(Func<string, IFile> download, string path)
        {
            var file = download(path);
        }

        public delegate void EventHandler(object sender, EventArgs args);
    }
}
