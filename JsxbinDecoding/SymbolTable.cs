namespace jsxbin_to_jsx_GUI.JsxbinDecoding
{
    public sealed class SymbolTable
    {
        Dictionary<string, string> table = new Dictionary<string, string>();

        public void Add(string key, string value)
        {
            table[key] = value;
        }

        public string Get(string key)
        {
            return table[key];
        }
    }
}
