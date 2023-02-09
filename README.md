# dotnet-exception-handler

Simple way of handling exceptions in ASP.NET

### Core Concept

Thrown exceptions are being caught in middleware and then being handled respectfully returning `ProblemDetails` class in know 
[specification](https://www.rfc-editor.org/rfc/rfc7807)
