namespace DocSharp.Binary.CommonTranslatorLib;

public abstract class BinaryDocument : IVisitable
{
    #region IVisitable Members

    public abstract void Convert<T>(T mapping);
    
    #endregion
}
