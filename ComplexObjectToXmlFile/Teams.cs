using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

namespace ComplexObjectToXmlFile
{

    

    [XmlRoot("Teams")]
    class Teams : ICollection
    {
        private ArrayList teamArray = new ArrayList();

        public Teams()
        {

        }

        public Team this[int index]
        {
            get { return (Team)teamArray[index]; }
        }

        public int Count => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Team
    {
        public Team()
        {

        }
    }
}
