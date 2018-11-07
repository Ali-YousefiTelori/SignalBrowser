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
        /// get new pointer id for new classes and variables
        /// </summary>
        uint GetNewPointerId { get; }
        /// <summary>
        /// compile a source code to signal browser language
        /// </summary>
        /// <returns>main block</returns>
        IBlockInfo Compile(string sourceCode);
    }
}
