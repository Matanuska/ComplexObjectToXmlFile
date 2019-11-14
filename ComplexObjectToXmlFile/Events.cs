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
    [XmlRoot("Events")]
    class Events : ICollection
    {
        public string CollectionName;
        private ArrayList eventArray = new ArrayList();

        public Event this[int index]
        {
            get { return (Event)eventArray[index]; }
        }

        public int Count
        {
            get { return eventArray.Count; }
        }
        public object SyncRoot
        {
            get { return this; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }
        public void CopyTo(Array a, int index)
        {
            eventArray.CopyTo(a, index);
        }

        public IEnumerator GetEnumerator()
        {
            return eventArray.GetEnumerator();
        }


        public void Add(Employee newEvent)
        {
            eventArray.Add(newEvent);
        }
    }

    public class Event
    {
        public string EmpName;
        public string EmpID;
        public Event() { }
        public Event(string empName, string empID)
        {
            EmpName = empName;
            EmpID = empID;
        }
    }
}
