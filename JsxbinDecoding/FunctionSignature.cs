﻿namespace jsxbin_to_jsx_GUI.JsxbinDecoding
{
    public class FunctionSignature
    {
        public FunctionSignature()
        {
            Parameter = new List<Tuple<string, int>>();
        }

        public int Header1 { get; set; }
        public int Type { get; set; }
        public int Header3 { get; set; }
        public string Name { get; set; }
        public int Header5 { get; set; }
        public List<Tuple<string, int>> Parameter { get; set; }
    }
}
