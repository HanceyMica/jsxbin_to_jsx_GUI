namespace jsxbin_to_jsx_GUI.JsxbinDecoding
{
    public interface INode
    {
        NodeType NodeType { get; }
        string Marker { get; }
        void Decode();
        string PrettyPrint();
        double JsxbinVersion { get; }
        string DecodeId();
        bool DecodeBool();
    }
}
