using System;
using System.Collections.Generic;

namespace FileWatcherLibrary.Models
{
    /// <summary>
    /// Represents and event in a file watcher.
    /// </summary>
    public class EventModel
    {
        /// <summary>
        /// This is the database primary key for an event.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// This is the period that the event will be ran, ex 00:30:00 will run the event every 30 minutes.
        /// </summary>
        public TimeSpan EventPeriodicity { get; set; }

        /// <summary>
        /// This is the full file path to the source directory of the current file watcher event.
        /// </summary>
        public string SourceDirectory { get; set; }

        /// <summary>
        /// This is the full file patch to the destination
        /// directory of the current file watcher event.
        /// </summary>
        public string DestinationDirectory { get; set; }

        /// <summary>
        /// This is a list of filters for the files that the
        /// file watcher is looking for.
        /// </summary>
        public List<string> FileNameFilter { get; set; } = new List<string>();
    }
}
