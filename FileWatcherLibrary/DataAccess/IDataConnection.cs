using FileWatcherLibrary.Models;
using System;
using System.Collections.Generic;

namespace FileWatcherLibrary.DataAccess
{
    public interface IDataConnection
    {
        FileWatcherModel CreateFileWatcher(FileWatcherModel model);
        List<FileWatcherModel> GetFileWatchers_All();
        void UpdateActiveFileWatcher(int FileWatcherID, bool ActiveFileWatcher);
        void InsertLogRecord(int FileWatcherID, string FileWatcherName, string FileName, string SourceDirectory, string DestinationDirectory, string Status, DateTime StatusDateTime);
        void DeleteFileWatcherEvent(int FileWatcherID, int FW_EventID);
        void DeleteFileWatcher(int FileWatcherID);
        void UpdateFileWatcher(int FileWatcherID, DateTime LastEdited, string LastEditedBy, string LastEditSummary);
        FileWatcherModel UpdateFileWatcherEvents(FileWatcherModel model);
    }
}
