using Jsbeautifier;
using jsxbin_to_jsx_GUI.JsxbinDecoding;
using System.Text;

namespace jsxbin_to_jsx_GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择输入文件";
            dialog.Filter = "二进制JSX文件(*.jsxbin)|*.jsxbin";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string file = dialog.FileName;
                textInput.Text = file;
                textOutput.Text = Path.GetDirectoryName(dialog.FileName);
                textFileName.Text = Path.GetFileNameWithoutExtension(dialog.FileName);
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            if (textInput.Text.Equals("") || textInput.Text == null)
            {
                OutputPathAlert alert = new OutputPathAlert();
                alert.ShowDialog();
            }
            else
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择输出文件夹";
                dialog.UseDescriptionForTitle = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string outputPath = dialog.SelectedPath;
                    textOutput.Text = outputPath;
                }
            }
        }

        // 逻辑：如果输入输出文本不为空，则开始调用Decode()，否则弹出NullInputAlert
        private void converButton_Click(object sender, EventArgs e)
        {
            if (textInput.Text.Equals("") || textOutput.Text.Equals(""))
            {
                PathAlert alert = new PathAlert();
                alert.ShowDialog();
            }
            else
            {
                string[] input = new string[2];
                input[0] = textInput.Text;
                input[1] = textOutput.Text + "\\" + formatName.Text;
                DecodeArgs parsedArgs;
                try
                {
                    parsedArgs = ParseCommandLine(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                Decode(parsedArgs);
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        static void Decode(DecodeArgs decoderArgs)
        {
            try
            {
                Console.WriteLine("Decoding {0}", decoderArgs.JsxbinFilepath);
                string jsxbin = File.ReadAllText(decoderArgs.JsxbinFilepath, Encoding.ASCII);
                string jsx = AbstractNode.Decode(jsxbin, decoderArgs.PrintStructure);
                jsx = new Beautifier().Beautify(jsx);
                File.WriteAllText(decoderArgs.JsxFilepath, jsx, Encoding.UTF8);
                Console.WriteLine("Jsxbin successfully decoded to {0}", decoderArgs.JsxFilepath);
                SuccessAlert alert = new SuccessAlert();
                alert.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Decoding failed. If this problem persists, please raise an issue on github. Error message: {0}. Stacktrace: {1}.", ex.Message, ex.StackTrace);

            }
        }

        static DecodeArgs ParseCommandLine(string[] args)
        {
            var decoderArgs = new DecodeArgs();
            int flagOffset = 0;
            if (args.Length > 2)
            {
                if (args[0] == "-v")
                {
                    flagOffset++;
                    decoderArgs.PrintStructure = true;
                }
                else
                {
                    throw new Exception(string.Format("Flag {0} is not valid.", args[0]));
                }
            }
            decoderArgs.JsxbinFilepath = args[flagOffset];
            decoderArgs.JsxFilepath = args[flagOffset + 1];
            return decoderArgs;
        }

        private class DecodeArgs
        {
            public string JsxFilepath { get; set; }
            public string JsxbinFilepath { get; set; }
            public bool PrintStructure { get; set; }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}