using System.Collections.Generic;
using DocSharp.Binary.Spreadsheet.XlsFileFormat.Ptg;
using DocSharp.Binary.StructuredStorage.Reader;

namespace DocSharp.Binary.Spreadsheet.XlsFileFormat.Structures
{
    /// <summary>
    /// This structure specifies a formula used in a chart.
    /// </summary>
    public class ChartParsedFormula
    {
        private ushort cce;
        
        /// <summary>
        /// LinkedList with the Ptg records !!
        /// </summary>
        public Stack<AbstractPtg> formula;

        public ChartParsedFormula(IStreamReader reader)
        {
            this.cce = reader.ReadUInt16();

            if (this.cce > 0)
            {
                this.formula = ExcelHelperClass.getFormulaStack(reader, this.cce);
            }
        }
    }
}
