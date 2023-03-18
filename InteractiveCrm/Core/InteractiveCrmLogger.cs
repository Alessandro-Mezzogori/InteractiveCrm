using InteractiveCrm.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveCrm.Core
{
    internal class InteractiveCrmLogger : IInteractiveCrmLogger
    {
        private readonly TextWriter _writer;

        public InteractiveCrmLogger(TextWriter writer)
        {
            _writer = writer;
        }

        public void Log(string message)
        {
            _writer.WriteLine($"[{DateTime.Now.TimeOfDay.ToString("")}] - {message}");
        }
    }
}
