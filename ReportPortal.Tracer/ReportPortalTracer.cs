﻿using System.Diagnostics;
using ReportPortal.Shared;

namespace ReportPortal.Tracer
{
    /// <summary>
    /// Custom trace listener for reporting logs directly to Report Portal.
    /// Logs will be viewable under current test item from shared context.
    /// </summary>
    public class ReportPortalTracer : TraceListener
    {
        public override void Write(string message)
        {
            Context.Current.Log.Info(message);
        }

        public override void WriteLine(string message)
        {
            Write(message);
        }
    }
}
