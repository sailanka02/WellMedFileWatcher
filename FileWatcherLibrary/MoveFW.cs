using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileWatcherLibrary.Models;

namespace FileWatcherLibrary
{
    class MoveFW
    {
        public static int MoveFile(EventModel e, int fileWatcherID, string fileWatcherName)
        {
            int countMoved = 0;
            int countRecords = 0;
            string Source = e.SourceDirectory;
            string Destination = e.DestinationDirectory;

            foreach (string name in e.FileNameFilter)
            {
                string[] files = Directory.GetFiles(e.SourceDirectory, name);

                foreach (string file in files)
                {
                    if (!String.IsNullOrEmpty(file))
                    {
                        countRecords++;

                        if (!File.Exists(Destination + Path.GetFileName(file)))
                        {
                            File.Move(file, Destination + Path.GetFileName(file));
                            File.Delete(file);
                            GlobalConfig.Connection.InsertLogRecord(fileWatcherID, fileWatcherName, Path.GetFileName(file), Source, Destination, "MOVED",DateTime.Now);
                            countMoved++;
                        }
                        else
                        {
                            GlobalConfig.Connection.InsertLogRecord(fileWatcherID, fileWatcherName, Path.GetFileName(file), Source, Destination, "NOT MOVED - FILE EXISTS IN TARGET LOCATION", DateTime.Now);
                        }
                    }
                }
            }
            return countMoved == countRecords ? 1 : -1;
        }
    }
}
