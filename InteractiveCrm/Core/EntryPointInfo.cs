namespace InteractiveCrm
{
    public struct EntryPointInfo
    {
        public string Namespace { get; set; } // TODO not utilized ( global namespace for now )
        public string Class { get; set; }
        public string Method { get; set; }
    }
}