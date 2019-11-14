using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace ComplexObjectToXmlFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            Employees Emps = new Employees();
            // Note that only the collection is serialized -- not the
            // CollectionName or any other public property of the class.
            Emps.CollectionName = "Employees";
            Employee John100 = new Employee("Johnny", "100xxx");
            Emps.Add(John100);
            XmlSerializer x = new XmlSerializer(typeof(Employees));
            TextWriter writer = new StreamWriter(new FileStream("foo.xml",FileMode.Create),Encoding.UTF8);
            x.Serialize(writer, Emps,ns);

        }
    }
}
