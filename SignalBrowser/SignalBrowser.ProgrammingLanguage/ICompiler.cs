using System;
using System.Collections.Generic;
using System.Text;

namespace SignalBrowser.ProgrammingLanguage
{
    /// <summary>
    /// compile a pure code to signal browser language
    /// </summary>
    public interface ICompiler
    {
        /// <summary>
        /// compile a source code to signal browser language
        /// </summary>
        /// <returns>main block</returns>
        IBlockInfo ICompiler(string sourceCode);
    }
}
