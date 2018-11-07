using SignalBrowser.JavaScript.Blocks;
using SignalBrowser.JavaScript.Lines;
using SignalBrowser.ProgrammingLanguage;
using System.Text;

namespace SignalBrowser.JavaScript
{
    public class Compiler : ICompiler
    {
        uint LastPointerId { get; set; }
        public uint GetNewPointerId
        {
            get
            {
                LastPointerId++;
                return LastPointerId;
            }
        }
        /// <summary>
        /// compile java script code to signal browser block
        /// </summary>
        /// <param name="sourceCode"></param>
        /// <returns></returns>
        public IBlockInfo Compile(string sourceCode)
        {
            //initialize main block
            BlockInfo blockInfo = new BlockInfo();
            StringBuilder stringBuilder = new StringBuilder();
            bool isStartFinding = false;
            for (int i = 0; i < sourceCode.Length; i++)
            {
                char currentChar = sourceCode[i];
                //don't need to calculate white spaces
                if (!isStartFinding && (currentChar == '\r' || currentChar == '\t' || currentChar == '\n' || currentChar == ' '))
                    continue;
                isStartFinding = true;
                stringBuilder.Append(currentChar);
                //if din chars == var then create a variable
                if (stringBuilder.Length == 3 && stringBuilder.ToString() == "var")
                {
                    i = VariableLine.GenerateVariable(i, ref sourceCode, blockInfo, this);
                    stringBuilder.Clear();
                    isStartFinding = false;
                    continue;
                }
            }
            return blockInfo;
        }



    }
}
