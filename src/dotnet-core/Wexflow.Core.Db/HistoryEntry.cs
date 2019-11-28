﻿using System;
using System.Collections.Generic;

namespace Wexflow.Core.Db
{
    public class HistoryEntry
    {
        public static readonly string DocumentName = "historyEntries";

        public int WorkflowId { get; set; }
        public string Name { get; set; }
        public LaunchType LaunchType { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime StatusDate { get; set; }
        public List<string> ServerLogs { get; set; }
        public virtual string GetDbId()
        {
            return "-1";
        }

    }
}
