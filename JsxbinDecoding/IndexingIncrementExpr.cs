﻿namespace jsxbin_to_jsx_GUI.JsxbinDecoding
{
    public class IndexingIncrementExpr : AbstractNode
    {
        string varName;
        int addOrSubtract;
        bool isPostfix;

        public override string Marker
        {
            get { return Convert.ToChar(0x50).ToString(); }
        }

        public override NodeType NodeType
        {
            get
            {
                return NodeType.IndexingIncrementExpr;
            }
        }

        public override void Decode()
        {
            varName = DecodeNode().PrettyPrint();
            addOrSubtract = DecodeLiteralNumber2();
            isPostfix = DecodeBool();
        }

        public override string PrettyPrint()
        {
            string op = addOrSubtract == 1 ? "++" : "--";
            var result = isPostfix ? varName + op : op + varName;
            return result;
        }
    }
}
