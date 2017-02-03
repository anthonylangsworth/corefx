using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace System.Security.Cryptography.Xml.Tests
{
    public class XmlNodeListEqualityComparer: IEqualityComparer<XmlNodeList>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool Equals(XmlNodeList x, XmlNodeList y)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int GetHashCode(XmlNodeList obj)
        {
            throw new NotImplementedException();
        }
    }
}
