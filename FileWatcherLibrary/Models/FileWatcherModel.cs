using System;
using System.Collections.Generic;

namespace FileWatcherLibrary.Models
{
    /// <summary>
    /// Represents a single file watcher.
    /// </summary>
    public class FileWatcherModel
    {
        /// <summary>
        /// The unique identifier for a file watcher
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// This is the name of the file watcher.
        /// </summary>
        public string FileWatcherName { get; set; }

        /// <summary>
        /// This is the ID (PMMR) of the person who created the file
        /// watcher job.
        /// </summary>
        public string CreatorID { get; set; }

        /// <summary>
        /// If True, the file watcher is active and will execute.
        /// </summary>
        public bool ActiveFileWatcher { get; set; }

        /// <summary>
        /// This is true if the file watcher has a failed event.
        /// </summary>
        public bool FileWatcherFault { get; set; }

        /// <summary>
        /// This is the last time the the file watcher was edited.
        /// </summary>
        public DateTime LastEdited { get; set; }

        /// <summary>
        /// This is the ID of the last person who edited the file watcher.
        /// </summary>
        public string LastEditedBy { get; set; }

        /// <summary>
        /// This hold the last edit summary by the last editor of a file watcher.
        /// </summary>
        public string LastEditSummary { get; set; }

        /// <summary>
        /// This is a list of move events for the current file watcher.
        /// </summary>
        public List<EventModel> FileWatcherEvents { get; set; } = new List<EventModel>();
    }
}
