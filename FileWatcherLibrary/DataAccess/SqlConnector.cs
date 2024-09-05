using Dapper;
using FileWatcherLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FileWatcherLibrary.DataAccess
{
    class SqlConnector : IDataConnection
    {
        private const string db = "IS_FileWatcher";

        /// <summary>
        /// Saves a new file watcher to the database.
        /// </summary>
        /// <param name="model">The file watcher information.</param>
        /// <returns>The file watcher information and unique indentifier.</returns>
        public FileWatcherModel CreateFileWatcher(FileWatcherModel model)
        {
            // TODO - Handle error checking.
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@FileWatcherName", model.FileWatcherName);
                p.Add("@CreatorID", model.CreatorID);
                p.Add("@ActiveFileWatcher", model.ActiveFileWatcher);
                p.Add("@FileWatcherFault", model.FileWatcherFault);
                p.Add("@LastEdited", model.LastEdited);
                p.Add("@LastEditedBy", model.LastEditedBy);

                _ = connection.Execute("dbo.spFileWatcher_InsertNew", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@ID");

                foreach (EventModel em in model.FileWatcherEvents)
                {
                    p = new DynamicParameters();
                    p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    p.Add("@EventPeriodicity", em.EventPeriodicity);
                    p.Add("@SourceDirectory", em.SourceDirectory);
                    p.Add("@DestinationDirectory", em.DestinationDirectory);
                    p.Add("@FileWatcherID", model.ID);
                    
                    _ = connection.Execute("dbo.spFW_Event_InsertNew", p, commandType: CommandType.StoredProcedure);

                    em.ID = p.Get<int>("@ID");

                    foreach (string namefilter in em.FileNameFilter)
                    {
                        p = new DynamicParameters();
                        p.Add("@NameFilterString", namefilter);
                        p.Add("@FW_EventID", em.ID);

                        _ = connection.Execute("dbo.spNameFilter_InsertNew", p, commandType: CommandType.StoredProcedure);
                    }
                }
                return model;
            }
        }

        /// <summary>
        /// Gets all the file watcher data from tthe database and loads into application.
        /// </summary>
        /// <returns></returns>
        public List<FileWatcherModel> GetFileWatchers_All()
        {
            List<FileWatcherModel> output = new List<FileWatcherModel>();

            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<FileWatcherModel>("dbo.spFileWatcher_GetAll").ToList();

                var p = new DynamicParameters();
                foreach (FileWatcherModel f in output)
                {
                    p = new DynamicParameters();
                    p.Add("@FileWatcherID", f.ID);

                    f.FileWatcherEvents = connection.Query<EventModel>("dbo.spFW_Events_GetByFileWatcherID", p, commandType: CommandType.StoredProcedure).ToList();
                    foreach (EventModel model in f.FileWatcherEvents)
                    {
                        p = new DynamicParameters();
                        p.Add("FW_EventID", model.ID);
                        model.FileNameFilter = connection.Query<string>("dbo.spNameFilter_GetByFW_EventID", p, commandType: CommandType.StoredProcedure).ToList();
                    }
                }
            }
            return output;
        }

        /// <summary>
        /// Updates whether the selected filewatcher is active or paused in the database.
        /// </summary>
        /// <param name="FileWatcherID">The ID of the selected filewatcher.</param>
        /// <param name="ActiveFileWatcher">The current status of the filewatcher.</param>
        public void UpdateActiveFileWatcher(int FileWatcherID, bool ActiveFileWatcher)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FileWatcherID", FileWatcherID);
                p.Add("@ActiveFileWatcher", ActiveFileWatcher);
                _ = connection.Execute("dbo.spFileWatcher_UpdateActiveFileWatcher", p, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Inserts entry into the FileWatcherLogging table.
        /// </summary>
        /// <param name="fileWatcherID">ID of the file watcher referenced.</param>
        /// <param name="fileWatcherName">Name of the file watcher referenced.</param>
        /// <param name="fileName">Filename of file being processed.</param>
        /// <param name="sourceDirectory">File source directory.</param>
        /// <param name="destinationDirectory">File destination directory.</param>
        /// <param name="status">Status of the current file event.</param>
        /// <param name="statusDateTime">Date and time that the log entry was made.</param>
        public void InsertLogRecord(int fileWatcherID, string fileWatcherName, string fileName, string sourceDirectory, string destinationDirectory, string status, DateTime statusDateTime)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FileWatcherID", fileWatcherID);
                p.Add("@FileWatcherName", fileWatcherName);
                p.Add("@FileName", fileName);
                p.Add("@SourceDirectory", sourceDirectory);
                p.Add("@DestinationDirectory", destinationDirectory);
                p.Add("@Status", status);
                p.Add("@StatusDateTime", statusDateTime);
                _ = connection.Execute("dbo.spFileWatcherLogging_InsertNew", p, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Deletes the name filters and event for a given file watcher event.
        /// </summary>
        /// <param name="FileWatcherID">ID of the current file watcher.</param>
        /// <param name="FW_EventID">ID of the current file watcher event.</param>
        public void DeleteFileWatcherEvent(int FileWatcherID, int FW_EventID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FileWatcherID", FileWatcherID);
                p.Add("@FW_EventID", FW_EventID);
                _ = connection.Execute("dbo.spFW_Event_NameFilter_DeleteByID", p, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Deletes the given file watcher.
        /// </summary>
        /// <param name="FileWatcherID">ID of the current file watcher</param>
        public void DeleteFileWatcher(int FileWatcherID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ID", FileWatcherID);
                _ = connection.Execute("dbo.spFileWatcher_DeleteByID", p, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Updates the given file watcher edit information.
        /// </summary>
        /// <param name="FileWatcherID">ID of the current file watcher.</param>
        /// <param name="LastEdited">Date and time of the last edit</param>
        /// <param name="LastEditedBy">User domain name and user name of person that last edited the file watcher.</param>
        /// <param name="LastEditSummary">Summary of the last changes made to the file watcher.</param>
        public void UpdateFileWatcher(int FileWatcherID, DateTime LastEdited, string LastEditedBy, string LastEditSummary)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ID", FileWatcherID);
                p.Add("@LastEdited", LastEdited);
                p.Add("@LastEditedBy", LastEditedBy);
                p.Add("@LastEditSummary", LastEditSummary);
                _ = connection.Execute("dbo.spFileWatcher_UpdateByID", p, commandType: CommandType.StoredProcedure);
            }
        }

        public FileWatcherModel UpdateFileWatcherEvents(FileWatcherModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                foreach (EventModel em in model.FileWatcherEvents)
                {
                    var p = new DynamicParameters();
                    p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    p.Add("@EventPeriodicity", em.EventPeriodicity);
                    p.Add("@SourceDirectory", em.SourceDirectory);
                    p.Add("@DestinationDirectory", em.DestinationDirectory);
                    p.Add("@FileWatcherID", model.ID);

                    _ = connection.Execute("dbo.spFW_Event_InsertNew", p, commandType: CommandType.StoredProcedure);

                    em.ID = p.Get<int>("@ID");

                    foreach (string namefilter in em.FileNameFilter)
                    {
                        p = new DynamicParameters();
                        p.Add("@NameFilterString", namefilter);
                        p.Add("@FW_EventID", em.ID);

                        _ = connection.Execute("dbo.spNameFilter_InsertNew", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }
            return model;
        }
    }
}
