namespace jsxbin_to_jsx_GUI.JsxbinDecoding
{
    public interface IPrintableNode
    {
        bool PrintStructure { get; set; }
        int IndentLevel { get; set; }
    }
}
