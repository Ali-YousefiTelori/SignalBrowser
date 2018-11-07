using SignalBrowser.ProgrammingLanguage;
using System.Collections.Generic;
using System.Text;

namespace SignalBrowser.JavaScript.Lines
{
    public class VariableLine : IVariable
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public object Value { get; set; }

        public Dictionary<uint, IVariable> Variables { get; set; }

        public IBlockInfo Parent { get; set; }

        /// <summary>
        /// generate a variable
        /// </summary>
        /// <param name="fromIndex">from index of source string</param>
        /// <param name="source">source string</param>
        /// <param name="blockInfo">block of variable</param>
        /// <param name="compiler">compile for new variable ids</param>
        /// <returns>new index of source to find next objects</returns>
        public static int GenerateVariable(int fromIndex, ref string source, IBlockInfo blockInfo, ICompiler compiler)
        {
            int i = fromIndex + 1;
            StringBuilder stringBuilder = new StringBuilder();
            //find end of variable
            for (; i < source.Length; i++)
            {
                char currentChar = source[i];
                if (currentChar == ';')
                    break;
                stringBuilder.Append(currentChar);
            }
            //create variable
            VariableLine variableLine = new VariableLine();
            string result = stringBuilder.ToString();
            //split if variable has = char
            int indexOfEqual = result.IndexOf('=');

            string leftSideOfEqual = "", rightSideOfEqual = "";

            if (indexOfEqual > 0)
            {
                //left side of '=' char
                leftSideOfEqual = result.Substring(0, indexOfEqual);
                //right side of '=' char
                rightSideOfEqual = result.Substring(indexOfEqual + 1);
            }
            else
                leftSideOfEqual = result;
            //set variable name
            variableLine.Name = leftSideOfEqual.Trim();
            //set variable value
            variableLine.Value = rightSideOfEqual;
            //add variable to block with new id
            blockInfo.Variables.Add(compiler.GetNewPointerId, variableLine);
            return i;
        }
    }
}
