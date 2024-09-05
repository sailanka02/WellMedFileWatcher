using FileWatcherLibrary.Models;
using System;
using System.Collections.Generic;

namespace FileWatcherLibrary.DataAccess
{
    class TextConnector : IDataConnection
    {
        // TODO - Complete CreateFileWatcher for text file.
        /// <summary>
        /// Saves a new file watcher to text file.
        /// </summary>
        /// <param name="model">The file watcher information.</param>
        /// <returns>The file watcher information and unique indentifier.</returns>
        public FileWatcherModel CreateFileWatcher(FileWatcherModel model)
        {
            throw new NotImplementedException();
        }

        public List<FileWatcherModel> GetFileWatchers_All()
        {
            throw new NotImplementedException();
        }

        public void UpdateActiveFileWatcher(int FileWatcherID, bool ActiveFileWatcher)
        {
            throw new NotImplementedException();
        }

        public void DeleteFileWatcher(int FileWatcherID)
        {
            throw new NotImplementedException();
        }

        public void DeleteFileWatcherEvent(int FileWatcherID, int FW_EventID)
        {
            throw new NotImplementedException();
        }

        public void InsertLogRecord(int fileWatcherID, string fileWatcherName, string fileName, string sourceDirectory, string destinationDirectory, string status, DateTime statusDateTime)
        {
            throw new NotImplementedException();
        }

        public void UpdateFileWatcher(int FileWatcherID, DateTime LastEdited, string LastEditedBy, string LastEditSummary)
        {
            throw new NotImplementedException();
        }

        public FileWatcherModel UpdateFileWatcherEvents(FileWatcherModel model)
        {
            throw new NotImplementedException();
        }
    }
}
