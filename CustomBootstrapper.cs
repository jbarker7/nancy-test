using Nancy.Diagnostics;
using Nancy.Configuration;
using Nancy;

public class CustomBootstrapper : DefaultNancyBootstrapper
{
    public override void Configure(INancyEnvironment environment)
    {
        environment.Diagnostics(true, "password");
        environment.Tracing(enabled: false, displayErrorTraces: true);
        base.Configure(environment);
    }

}