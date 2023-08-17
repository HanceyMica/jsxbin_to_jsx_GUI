﻿using System.Text;

namespace jsxbin_to_jsx_GUI.JsxbinDecoding
{
    public class ForInStatementVersion2 : AbstractNode, IStatement
    {
        LineInfo bodyInfo;
        string loopVarName;
        string objExpr;
        int part25;
        string part3;
        bool isForEachLoop;

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
                return 2.0;
            }
        }

        public override void Decode()
        {
            bodyInfo = DecodeBody();
            loopVarName = DecodeNode().PrettyPrint();
            objExpr = DecodeNode().PrettyPrint();
            part25 = DecodeLength();
            part3 = DecodeId();
            isForEachLoop = DecodeBool();
        }

        public override string PrettyPrint()
        {
            string label = bodyInfo.CreateLabelStmt();
            string body = bodyInfo.CreateBody();
            string loopName = isForEachLoop ? "for each" : "for";
            StringBuilder b = new StringBuilder();
            b.AppendLine(string.Format("{0}{1} (var {2} in {3}) {{", label, loopName, loopVarName, objExpr));
            b.AppendLine(body);
            b.Append("}");
            return b.ToString();
        }
    }
}
