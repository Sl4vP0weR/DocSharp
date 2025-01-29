using System.IO;

namespace DocSharp.Binary.OfficeDrawing
{
    [OfficeRecord(0xF00D)]
    public class ClientTextbox : Record
    {
        public byte[] Bytes;

        public ClientTextbox(BinaryReader _reader, uint size, uint typeCode, uint version, uint instance)
            : base(_reader, size, typeCode, version, instance) 
        {
            this.Bytes = this.Reader.ReadBytes((int)this.BodySize);
        }
    }
}
