using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Xunit;
using XmlDocument = System.Xml.XmlDocument;
using XmlElement = System.Xml.XmlElement;

namespace System.Security.Cryptography.Xml.Tests
{
    public class DataObjectTests
    {
        [Fact]
        public void Constructor_Empty()
        {
            DataObject dataObject = new DataObject();

            Assert.Empty(dataObject.Data);
            Assert.Null(dataObject.Encoding);
            Assert.Null(dataObject.Id);
            Assert.Null(dataObject.MimeType);

            XmlElement xmlElement = dataObject.GetXml();
            Assert.NotNull(xmlElement);
            Assert.Equal("<Object xmlns=\"http://www.w3.org/2000/09/xmldsig#\" />", xmlElement.OuterXml);
        }

        [Fact]
        public void Constructor_Params()
        {
            string id = "id";
            string mimeType = "text/test";
            string encoding = "utf-42";
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement initialXmlElement = xmlDocument.CreateElement("name");
            DataObject dataObject = new DataObject(id, mimeType, encoding, initialXmlElement);

            Assert.Collection(
                (IEnumerable<IXmlNode>) dataObject.Data, 
                element1 => Assert.Equal(element1, initialXmlElement));
            Assert.Null(dataObject.Encoding);
            Assert.Null(dataObject.Id);
            Assert.Null(dataObject.MimeType);

            XmlElement xmlElement = dataObject.GetXml();
            Assert.NotNull(xmlElement);
            Assert.Equal("<Object xmlns=\"http://www.w3.org/2000/09/xmldsig#\" />", xmlElement.OuterXml);
        }
    }
}
