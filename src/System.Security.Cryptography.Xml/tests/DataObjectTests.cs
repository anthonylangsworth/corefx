using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xunit;

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
    }
}
