using System;
using System.Collections.Generic;
using System.Text;

namespace SignalBrowser.ProgrammingLanguage
{
    /// <summary>
    /// Variable of a block
    /// </summary>
    public interface IVariable
    {
        /// <summary>
        /// id of variable
        /// </summary>
        uint Id { get; set; }
        /// <summary>
        /// name of variable
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// value of variable
        /// </summary>
        object Value { get; set; }
        /// <summary>
        /// variables of variable like properties of class
        /// dictionary id is for access faster to variable
        /// </summary>
        Dictionary<uint, IVariable> Variables { get; set; }
        /// <summary>
        /// parent block of variable
        /// </summary>
        IBlockInfo Parent { get; set; }
    }
}
