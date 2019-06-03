using System;

namespace DotNetCoreArchitecture.Model
{
    public class UserLogModel
    {
        public long UserLogId { get; }

        public long UserId { get; }

        public LogType LogType { get; }

        public DateTime DateTime { get; }
    }
}
