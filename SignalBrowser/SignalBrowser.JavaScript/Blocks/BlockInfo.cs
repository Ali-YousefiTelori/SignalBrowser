using SignalBrowser.ProgrammingLanguage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignalBrowser.JavaScript.Blocks
{
    /// <summary>
    /// class,method,functions if,for,foreach etc
    /// </summary>
    public class BlockInfo : IBlockInfo
    {
        /// <summary>
        /// class,method,functions if,for,foreach etc blocks in this block info
        /// </summary>
        public Dictionary<uint, IBlockInfo> BlockInfoes { get; set; } = new Dictionary<uint, IBlockInfo>();
        /// <summary>
        /// lines of codes in block
        /// </summary>
        public List<ILineInfo> ILineInfoes { get; set; } = new List<ILineInfo>();
        /// <summary>
        /// parent block
        /// if null that is main block of application
        /// </summary>
        public IBlockInfo Parent { get; set; }
        /// <summary>
        /// variables of variable like properties of class
        /// dictionary id is for access faster to variable
        /// </summary>
        public Dictionary<uint, IVariable> Variables { get; set; } = new Dictionary<uint, IVariable>();
    }
}
