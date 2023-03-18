using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InteractiveCrm
{
    // TODO insieme di eventi a cui si possono iscrivere varie cose per aggiungere le diagnostiche
    // Syntax tree => errori di sintassi
    // Semantic model => errori di semantica
    // Compilation => errori di compilazione 
    internal class DiagnosticManager
    {
        private readonly BindingSource _diagnosticBindingSource;
        private readonly List<Diagnostic> _diagnostics; 

        public DiagnosticManager(BindingSource diagnosticBindingSource)
        {
            _diagnosticBindingSource = diagnosticBindingSource;
            _diagnostics = new List<Diagnostic>();
            _diagnosticBindingSource.Clear();
        }

        public void SetDiagnostics(IEnumerable<Diagnostic> diagnostics) 
        {
            _diagnostics.Clear();
            _diagnostics.AddRange(diagnostics);
            SyncBindingSource();
        }

        public void AddDiagnostic(Diagnostic diagnostic)
        {
            _diagnostics.Add(diagnostic);
            SyncBindingSource();
        }

        public void ClearDiagnostics()
        {
            _diagnostics.Clear();
            SyncBindingSource();
        }

        public Diagnostic GetDiagnostic(int index)
        {
            return _diagnostics[index];
        }

        public void SyncBindingSource()
        {
            _diagnosticBindingSource.Clear();
            foreach(var diagnostic in _diagnostics)
            {
                _diagnosticBindingSource.Add(diagnostic.ToViewModel());
            }
        }
    }
}