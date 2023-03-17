using Microsoft.CodeAnalysis;

namespace InteractiveCrm
{
    internal static class DiagnosticsExtensions
    {
        public static DiagnosticViewModel ToViewModel(this Diagnostic diagnostic)
        {
            var locationLineSpan = diagnostic.Location.GetLineSpan();
            var descriptor = diagnostic.Descriptor;
            return new DiagnosticViewModel
            {
                Error = diagnostic.ToString()
            };
        }
    }
}