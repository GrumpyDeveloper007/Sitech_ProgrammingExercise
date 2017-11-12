using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sitech_ProgrammingExercise
{
    public partial class MainWindow
    {

        // this handler will tell the main thread that we have completed processing, and is ok to add the result to the UI.
        public delegate void CompleteHandler(string[] files);

        // create a method that will scan a directory (including all sub folders)
        // looking for all files that have the .txt or .doc extension
        // the start path is passed into the "startPath" parameter.
        // note the method must not block the main thread and should process the data in the background.
        // the code must call the "done" handler with an array of file names when complete.
        public void Exercise4(string startPath, CompleteHandler done)
        {
            new Thread(() =>
            {
                List<string> files = new List<string>();
                files.AddRange(Directory.GetFiles(startPath, "*.txt", SearchOption.AllDirectories));
                files.AddRange(Directory.GetFiles(startPath, "*.doc", SearchOption.AllDirectories));
                done(files.ToArray());
            }
            ).Start();
        }
    }
}
