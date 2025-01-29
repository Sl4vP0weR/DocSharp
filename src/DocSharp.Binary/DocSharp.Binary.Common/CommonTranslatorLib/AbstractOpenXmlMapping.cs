using System.Xml;

namespace DocSharp.Binary.CommonTranslatorLib
{
    public abstract class AbstractOpenXmlMapping
    {
        protected XmlWriter _writer;
        protected XmlDocument _nodeFactory;

        public AbstractOpenXmlMapping(XmlWriter writer)
        {
            this._writer = writer;
            this._nodeFactory = new XmlDocument();
        }
    }
}
