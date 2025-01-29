using System.Collections.Generic;
using DocSharp.Binary.Spreadsheet.XlsFileFormat.Ptg;
using DocSharp.Binary.StructuredStorage.Reader;
using DocSharp.Binary.Tools;

namespace DocSharp.Binary.Spreadsheet.XlsFileFormat.Structures
{
    /// <summary>
    /// This structure specifies a formula used by an embedded object.
    /// </summary>
    public class ObjectParsedFormula
    {
        private ushort cce;
        
        /// <summary>
        /// LinkedList with the Ptg records !!
        /// </summary>
        public Stack<AbstractPtg> formula;

        public ObjectParsedFormula(IStreamReader reader)
        {
            this.cce = Utils.BitmaskToUInt16(reader.ReadUInt16(), 0x7FFF);
            reader.ReadBytes(4);

            if (this.cce > 0)
            {
                this.formula = ExcelHelperClass.getFormulaStack(reader, this.cce);
            }
        }
    }
}
