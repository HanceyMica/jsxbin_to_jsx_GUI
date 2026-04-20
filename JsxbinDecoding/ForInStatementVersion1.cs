using System.Text;

namespace jsxbin_to_jsx_GUI.JsxbinDecoding
{
    public class ForInStatementVersion1 : AbstractNode, IStatement
    {
        LineInfo bodyInfo = null!;
        string loopVarName = null!;
        string objExpr = null!;
        int part25;
        string part3 = null!;

        public int LineNumber
        {
            get
            {
                return bodyInfo.LineNumber;
            }
        }

        public override string Marker
        {
            get { return Convert.ToChar(0x4C).ToString(); }
        }

        public override NodeType NodeType
        {
            get
            {
                return NodeType.ForInStatement;
            }
        }

        public override double JsxbinVersion
        {
            get
            {
                return 1.0;
            }
        }

        public override void Decode()
        {
            bodyInfo = DecodeBody();
            loopVarName = DecodeNode().PrettyPrint();
            objExpr = DecodeNode().PrettyPrint();
            part25 = DecodeLength();
            part3 = DecodeId();
            // Doesn't seem to exist in version 1.0
            // isForEachLoop = DecodeBool();
        }

        public override string PrettyPrint()
        {
            string label = bodyInfo.CreateLabelStmt();
            string body = bodyInfo.CreateBody();
            StringBuilder b = new StringBuilder();
            b.AppendLine(string.Format("{0}for (var {1} in {2}) {{", label, loopVarName, objExpr));
            b.AppendLine(body);
            b.Append("}");
            return b.ToString();
        }
    }
}
