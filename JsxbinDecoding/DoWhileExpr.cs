﻿using System.Text;

namespace jsxbin_to_jsx_GUI.JsxbinDecoding
{
    public class DoWhileExpr : AbstractNode, IStatement
    {
        LineInfo body;
        string test;

        public int LineNumber
        {
            get
            {
                return body.LineNumber;
            }
        }

        public override string Marker
        {
            get { return Convert.ToChar(0x49).ToString(); }
        }

        public override NodeType NodeType
        {
            get
            {
                return NodeType.DoWhileExpr;
            }
        }

        public override void Decode()
        {
            body = DecodeBody();
            test = DecodeNode().PrettyPrint();
        }

        public override string PrettyPrint()
        {
            var label = body.CreateLabelStmt();
            var bodyExpr = body.CreateBody();
            StringBuilder b = new StringBuilder();
            b.AppendLine(label + "do {");
            b.AppendLine("  " + bodyExpr);
            b.Append("} while (" + test + ")");
            return b.ToString();
        }
    }
}
