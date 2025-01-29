﻿using DocSharp.Binary.OfficeDrawing;
using System.IO;

namespace DocSharp.Binary.PptFileFormat
{
    [OfficeRecord(0x0400)]
    public class VbaInfoAtom: Record
    {
        public uint persistIdRef;

        public bool fHasMacros;

        public uint version;

        public VbaInfoAtom(BinaryReader _reader, uint size, uint typeCode, uint version, uint instance)
            : base(_reader, size, typeCode, version, instance)
        {
            this.persistIdRef = _reader.ReadUInt32();
            this.fHasMacros =  Tools.Utils.ByteToBool((byte)_reader.ReadUInt32());
            this.version = _reader.ReadUInt32();
        }
    }

}
