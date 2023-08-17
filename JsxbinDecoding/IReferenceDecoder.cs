namespace jsxbin_to_jsx_GUI.JsxbinDecoding
{
    public interface IReferenceDecoder
    {
        double JsxbinVersion { get; }
        Tuple<string, bool> Decode(INode node);
    }
}
