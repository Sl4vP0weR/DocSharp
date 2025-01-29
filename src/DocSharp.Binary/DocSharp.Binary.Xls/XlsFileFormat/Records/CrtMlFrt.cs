﻿using DocSharp.Binary.Spreadsheet.XlsFileFormat.Structures;
using DocSharp.Binary.StructuredStorage.Reader;

namespace DocSharp.Binary.Spreadsheet.XlsFileFormat.Records
{
    [BiffRecord(RecordType.CrtMlFrt)]
    public class CrtMlFrt : BiffRecord
    {
        public FrtHeader frtHeader;

        /// <summary>
        /// An unsigned integer that specifies the size, in bytes, 
        /// of the XmlTkChain structure starting in the xmltkChain field, 
        /// including the data contained in the optional CrtMlFrtContinue records.<br/> 
        /// MUST be less than or equal to 0x7FFFFFEB.
        /// </summary>
        public uint cb;

        public XmlTkChain xmltkChain;

        public CrtMlFrt(IStreamReader reader, RecordType id, ushort length)
            : base(reader, id, length)
        {
            long pos = reader.BaseStream.Position;

            this.frtHeader = new FrtHeader(reader);
            this.cb = reader.ReadUInt32();
            this.xmltkChain = new XmlTkChain(reader);
            reader.ReadBytes(4); // unused

            reader.BaseStream.Position = pos + length;
        }
    }
}
