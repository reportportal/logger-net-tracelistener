using System;
using System.Diagnostics;
using ReportPortal.Client.Models;
using ReportPortal.Client.Requests;
using ReportPortal.Shared;

namespace ReportPortal.Tracer
{
    /// <summary>
    /// Custom trace listener for reporting logs directly to Report Portal.
    /// Logs will be viewable under current test item from shared context.
    /// </summary>
    public class ReportPortalTracer: TraceListener
    {
        public override void Write(string message)
        {
            if (Bridge.Context.TestId != null)
            {
                var request = new AddLogItemRequest
                {
                    TestItemId = Bridge.Context.TestId,
                    Level = LogLevel.Info,
                    Time = DateTime.UtcNow,
                    Text = message
                };

                Bridge.Service.AddLogItem(request);
            }
        }

        public override void WriteLine(string message)
        {
            Write(message);
        }
    }
}
