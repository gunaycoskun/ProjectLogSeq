using Serilog;

namespace ProjectSerilog.Abstract
{
    public interface ISeriLogger
    {
        public void Information(string message);
        public void Error(string message);
       
    }
}
