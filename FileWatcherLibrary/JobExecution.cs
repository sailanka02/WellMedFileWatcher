using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using FileWatcherLibrary.Models;
using FileWatcherLibrary;
using System.Reflection;


namespace FileWatcherLibrary
{
    class JobExecution
    {
        public static void ExecuteJob()
        {
            List<FileWatcherModel> fileWatchers = GlobalConfig.Connection.GetFileWatchers_All();
            for (int i = 0; i < fileWatchers.Count(); i++)
            {
                ThreadPool.QueueUserWorkItem((o) => { threadEx(fileWatchers[i]); });
                /*
                Thread temp = new Thread(threadEx(fileWatchers[i]))
                {
                    Name = "Thread" + i
                };
                temp.Start();
                */

            }

                    /*
                    string[] intervalParts = e.EventPeriodicity.Split(':');
                    int intervalSeconds = int.Parse(intervalParts[0]) * 3600 + int.Parse(intervalParts[1]) * 60 + int.Parse(intervalParts[2]);
                    DateTime startTime = DateTime.Now;
                    DateTime endTime = startTime.AddDays(9);

                    while (DateTime.Now <= endTime)
                    {
                        TimeSpan elapsedTime = DateTime.Now - startTime;
                        if (elapsedTime.TotalSeconds >= intervalSeconds)
                        {
                            MoveFW.MoveFile(e, model.ID, model.FileWatcherName);
                            startTime = DateTime.Now;
                        }
                        Thread.Sleep(60000); //1 min
                    }
                    */


                    /*
                    if (e.EventPeriodicity.Hours == DateTime.Now.TimeOfDay.Hours && e.EventPeriodicity.Minutes == DateTime.Now.TimeOfDay.Minutes)
                    {
                        MoveFW.MoveFile(e, model.ID, model.FileWatcherName);
                      
                      =======
                        switch (e.Action)
                        {
                            case "Archive":
                                int a = ArchiveFW.archiveFile(e);
                                break;
                            case "Create":
                                int c = CreateFW.createFile(e);
                                break;
                            case "Delete":
                                int d = DeleteFW.deleteFile(e, fwm.);
                                break;
                            case "Move":
                                int m = MoveFW.moveFile(e);
                                break;
                            default:
                                Console.WriteLine("Something went wrong");
                                break;
                        }
                      >>>>>>> sailanka2.0
                      
                    }
                    */
        }

        public static void threadEx(FileWatcherModel model)
        {
            Thread t = Thread.CurrentThread;
            foreach (EventModel e in model.FileWatcherEvents)
            {
                double intervalSeconds = e.EventPeriodicity.TotalSeconds;
                DateTime startTime = DateTime.Now;
                while (true)
                {
                    TimeSpan elapsedTime = DateTime.Now - startTime;
                    if (elapsedTime.TotalSeconds >= intervalSeconds)
                    {
                        MoveFW.MoveFile(e, model.ID, model.FileWatcherName);
                        startTime = DateTime.Now; //resets startTime 
                        
                    }
                }
            }
        }
    }
}
