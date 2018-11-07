using System.Collections.Generic;

namespace SignalBrowser.ProgrammingLanguage
{
    /// <summary>
    /// class,method,functions if,for,foreach etc
    /// </summary>
    public interface IBlockInfo
    {
        /// <summary>
        /// variables of variable like properties of class
        /// dictionary id is for access faster to variable
        /// </summary>
        Dictionary<uint, IVariable> Variables { get; set; }
        /// <summary>
        /// class,method,functions if,for,foreach etc blocks in this block info
        /// </summary>
        Dictionary<uint, IBlockInfo> BlockInfoes { get; set; }
        /// <summary>
        /// lines of codes in block
        /// </summary>
        List<ILineInfo> ILineInfoes { get; set; }
        /// <summary>
        /// parent block
        /// if null that is main block of application
        /// </summary>
        IBlockInfo Parent { get; set; }
    }
}
