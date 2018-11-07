using System;
using System.Collections.Generic;
using System.Text;

namespace SignalBrowser.ProgrammingLanguage
{
    /// <summary>
    /// line of codes
    /// </summary>
    public interface ILineInfo
    {
        void Run();
        /// <summary>
        /// parent block of line
        /// </summary>
        IBlockInfo Parent { get; set; }
    }
}
