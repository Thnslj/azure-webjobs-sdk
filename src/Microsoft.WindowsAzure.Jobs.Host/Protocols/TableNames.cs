﻿namespace Microsoft.WindowsAzure.Jobs.Host.Protocols
{
    internal static class TableNames
    {
        internal const string Prefix = "AzureJobs";

        public const string EventQueueTableName = Prefix + "EventQueue";

        public const string FunctionInvokeLogTableName = Prefix + "FunctionLogs";

        public const string FunctionCausalityLog = Prefix + "FunctionCausalityLog";

        public const string RunningHostsTableName = Prefix + "RunningHosts";

        public const string FunctionsInJobIndex = Prefix + "FunctionsInJobIndex";
    }
}