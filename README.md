[![Build status](https://ci.appveyor.com/api/projects/status/jipm6r9qfbwlrwjm?svg=true)](https://ci.appveyor.com/project/nvborisenko/logger-net-tracelistener)

# Installation

Install **ReportPortal.Tracer** NuGet package.

[![NuGet version](https://badge.fury.io/nu/reportportal.tracer.svg)](https://badge.fury.io/nu/reportportal.tracer)


> PS> Install-Package ReportPortal.Tracer

# Configuration
Add custom listener in your *App.config* file.
```xml
<configuration>
  ...
  <system.diagnostics>
    <trace>
      <listeners>
        <add name="ReportPortalListener" type="ReportPortal.ReportPortalTracer, ReportPortal.Tracer" />
      </listeners>
    </trace>
  </system.diagnostics>
  ...
</configuration>
```
