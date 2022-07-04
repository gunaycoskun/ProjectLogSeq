using Microsoft.Extensions.Options;
using ProjectSerilog.Abstract;
using Serilog;

namespace ProjectSerilog.Services.Serilog
{
    public class SeriLoggerService: ISeriLogger
    {
        private SerilogOption.SerilogOption _option;
        public SeriLoggerService(IOptions<SerilogOption.SerilogOption> serilog)
        {
            _option = serilog.Value;
        }
        public void Information(string message)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Seq(_option.Connection)
                .CreateLogger();
            Log.Information(message);
            Log.CloseAndFlush();
        }

        public void Error(string message)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Seq(_option.Connection)
                .CreateLogger();
            Log.Error(message);
            Log.CloseAndFlush();
        }
    }
}
