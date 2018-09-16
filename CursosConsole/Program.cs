using CursosBusiness.Business;
using CursosConsole.ServiceReference1;
using GettingStartedWCFLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CursosConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0) 
                {
                    Console.WriteLine("FizzBuzz");
                }
                else 
                {
                    if (i % 5 == 0) 
                    {
                        Console.WriteLine("Buzz");
                    }
                    else 
                    {
                        if (i % 3 == 0)
                        {
                            Console.WriteLine("Fizz");
                        }
                        else 
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
            
            string p = "FINISHED FILES ARE THE RE- SULT OF YEARS OF SCIENTIF- IC STUDY COMBINED WITH THE EXPERIENCE OF YEARS ";
            int total = 0;
            for (var item=0;item < p.Length; item++)
            {
                if (p[item].Equals("F")) total++;
            }
            Console.WriteLine(total);
            // From Data out
            CommonB obj = new CommonB();
            var oCustomers = obj.GetUsuario("Admin", "2");
            Console.WriteLine(oCustomers.FirstOrDefault().Nombre);
            // Data in

            //GeneralB obj2 = new GeneralB();
            //obj2.CustomerCode = "c001";
            //obj2.CustomerName = "Shivprasad";
            Console.ReadLine();

            /// test wcf host
            //RunService();
            

            ///// test wcf client
            //TestService();

            // create xml
            //ExecuteXmlTest1();
            ExecuteXmlTest2();
            Console.ReadLine();
        }

        private static void ExecuteXmlTest2()
        {
            //XDocument xdocument = XDocument.Load("Employees.xml");
            XElement xelement = XElement.Load("Employees.xml");
            IEnumerable<XElement> employees = xelement.Elements();
            foreach (var employee in employees)
            {
                //Console.WriteLine(employee);
                //Console.WriteLine(employee.Element("Name").Value);
                Console.WriteLine("{0} has Employee ID {1}",
                    employee.Element("Name").Value,
                    employee.Element("EmpId").Value);
            }

            var name = from nm in xelement.Elements("Employee")
                       where (string)nm.Element("Sex") == "Female"
                       select nm;
            Console.WriteLine("Details of Female Employees:");
            foreach (XElement xEle in name)
                Console.WriteLine(xEle);

            var homePhone = from phoneno in xelement.Elements("Employee")
            where (string)phoneno.Element("Phone").Attribute("Type") == "Home"
            select phoneno;
            Console.WriteLine("List HomePhone Nos.");
            foreach (XElement xEle in homePhone)
            {
                Console.WriteLine(xEle.Element("Phone").Value);
            }

            var addresses = from address in xelement.Elements("Employee")            
                            where (string)address.Element("Address").Element("City") == "Alta"
                            select address;
            Console.WriteLine("Details of Employees living in Alta City");
            foreach (XElement xEle in addresses)
                Console.WriteLine(xEle);

            Console.WriteLine("List of all Zip Codes");
            foreach (XElement xEle in xelement.Descendants("Zip"))
            {
                Console.WriteLine((string)xEle);
            }

            // manipulation

            // Create an XML Document with Xml Declaration/Namespace/Comments using LINQ to XML
            XNamespace empNM = "urn:lst-emp:emp";
            XDocument xDoc = new XDocument(
                        new XDeclaration("1.0", "UTF-16", null),
                        new XElement(empNM + "Employees",
                            new XElement("Employee",
                                new XComment("Only 3 elements for demo purposes"),
                                new XElement("EmpId", "5"),
                                new XElement("Name", "Kimmy"),
                                new XElement("Sex", "Female")
                                )));

            StringWriter sw = new StringWriter();
            xDoc.Save(sw);
            Console.WriteLine(sw);

            // Save the XML Document to a XMLWriter or to the disk using LINQ to XML
            XmlWriter xWrite = XmlWriter.Create(sw);
            xDoc.Save(xWrite);
            xWrite.Close();

            // Save to Disk
            xDoc.Save("C:\\Something.xml");
            Console.WriteLine("Saved");

            // Load an XML Document using XML Reader using LINQ to XML
            XmlReader xRead = XmlReader.Create(@"Employees.xml");
            XElement xElem = XElement.Load(xRead);
            Console.WriteLine(xElem);
            xRead.Close();

            // List the First 2 Elements using LINQ to XML
            var emps = xElem.Descendants("Employee").Take(2);
            //var emps = xEle.Descendants("Employee").Skip(1).Take(2);
            //var emps = xEle.Descendants("Employee").Reverse().Take(2);
            foreach (var emp in emps)
                Console.WriteLine(emp);

            //Find the Element Count based on a condition using LINQ to XML
            var stCnt = from address in xelement.Elements("Employee")
                        where (string)address.Element("Address").Element("State") == "CA"
                        select address;
            Console.WriteLine("No of Employees living in CA State are {0}", stCnt.Count());

            //Add a new Element at runtime using LINQ to XML
            xElem.Add(new XElement("Employee",
                new XElement("EmpId", 5),
                new XElement("Name", "George")));

            Console.Write(xElem);

            //Add a new Element as the First Child using LINQ to XML
            xElem.AddFirst(new XElement("Employee",
                new XElement("EmpId", 5),
                new XElement("Name", "George")));

            //Add an attribute to an Element using LINQ to XML
            xElem.Add(new XElement("Employee",
                new XElement("EmpId", 5),
                new XElement("Phone", "423-555-4224", new XAttribute("Type", "Home"))));

            Console.Write(xElem);

            //Replace Contents of an Element/Elements using LINQ to XML
            var countries = xElem.Elements("Employee").Elements("Address").Elements("Country").ToList();
            foreach (XElement cEle in countries)
                cEle.ReplaceNodes("United States Of America");
 
            Console.Write(xElem);

            //Remove an attribute from all the Elements using LINQ to XML
            var phone = xElem.Elements("Employee").Elements("Phone").ToList();
            foreach (XElement pEle in phone)
                pEle.RemoveAttributes();
 
            Console.Write(xElem);

            //Delete an Element based on a condition using LINQ to XML
            var addr = xElem.Elements("Employee").ToList();
            foreach (XElement addEle in addr)
                addEle.SetElementValue("Address", null);
 
            Console.Write(xElem);

            // Remove ‘n’ number of Elements using LINQ to XML
            var emps2 = xElem.Descendants("Employee");
            emps2.Reverse().Take(2).Remove();
 
            Console.Write(xElem);

            // 4. Save/Persists Changes to the XML using LINQ to XML
            xElem.Add(new XElement("Employee",
            new XElement("EmpId", 5),
            new XElement("Name", "George"),
            new XElement("Sex", "Male"),
            new XElement("Phone", "423-555-4224", new XAttribute("Type", "Home")),
            new XElement("Phone", "424-555-0545", new XAttribute("Type", "Work")),
            new XElement("Address",
                new XElement("Street", "Fred Park, East Bay"),
                new XElement("City", "Acampo"),
                new XElement("State", "CA"),
                new XElement("Zip", "95220"),
                new XElement("Country", "USA"))));
 
            xElem.Save("..\\..\\Employees.xml");
            Console.WriteLine(xElem);
 
            Console.ReadLine();       
        }

        private static void ExecuteXmlTest1()
        {
            //XDocument xmlTree = new XDocument(
            //    new XElement("Parent",
            //        new XElement("Child1", "Child1 data"),
            //        new XElement("Child2", "Child2 data")
            //    )
            //);
            XElement contacts = new XElement("Contacts",
                new XElement("Contact",
                    new XElement("Name", "Patrick Hines"),
                    new XElement("Phone", "206-555-0144",
                        new XAttribute("Type", "Home")),
                    new XElement("phone", "425-555-0145",
                        new XAttribute("Type", "Work")),
                    new XElement("Address",
                        new XElement("Street1", "123 Main St"),
                        new XElement("City", "Mercer Island"),
                        new XElement("State", "WA"),
                        new XElement("Postal", "68042")
                    )
                )
            );
            // desde un text string
            XElement contactsString = XElement.Parse(
                @"<Contacts>
                    <Contact>
                        <Name>Patrick Hines</Name>
                        <Phone Type=""home"">206-555-0144</Phone>
                        <Phone type=""work"">425-555-0145</Phone>
                        <Address>
                        <Street1>123 Main St</Street1>
                        <City>Mercer Island</City>
                        <State>WA</State>
                        <Postal>68042</Postal>
                        </Address>
                        <NetWorth>10</NetWorth>
                    </Contact>
                    <Contact>
                        <Name>Gretchen Rivas</Name>
                        <Phone Type=""mobile"">206-555-0163</Phone>
                        <Address>
                        <Street1>123 Main St</Street1>
                        <City>Mercer Island</City>
                        <State>WA</State>
                        <Postal>68042</Postal>
                        </Address>
                        <NetWorth>11</NetWorth>
                    </Contact>
                </Contacts>");
            // desde un archivo 
            XElement booksFromFile = XElement.Load(@"contacts.xml");
            Console.WriteLine(booksFromFile);
            XElement xmlTree = XElement.Parse("<Root> <Child> </Child> </Root>");
            Console.WriteLine(xmlTree);
            string str =
                @"<?xml version=""1.0""?>
                <!-- comment at the root level -->
                <Root>
                    <Child>Content</Child>
                </Root>";
            XDocument doc = XDocument.Parse(str);
            Console.WriteLine(doc);
            Console.WriteLine(contacts);
            contacts.Save("contacts.xml", SaveOptions.None);
            //contacts.ToString();
            //contacts.WriteTo();
            //contacts.CreateWriter();
            string stringcontacts = File.ReadAllText("contacts.xml");
            IEnumerable<XElement> partNos =
                from item in contacts.Descendants("Contact")
                where item.Element("Name").Value.ToUpper().StartsWith("P")
                orderby (string)item.Element("Name")
                select item;
            //where item.Element("Name").Value.StartsWith("p") 
            foreach (var item in partNos)
            {
                Console.WriteLine("where" + item.ToString());
            }
            XElement po = XElement.Load("PurchaseOrder.xml");
            IEnumerable<XElement> childElements =
                from el in po.Elements()
                select el;
            foreach (XElement el in childElements)
                Console.WriteLine("Name: " + el.Name);

            IEnumerable<XElement> items =
            from el in po.Descendants("ProductName")
            select el;
            foreach (XElement prdName in items)
                Console.WriteLine(prdName.Name + ":" + (string)prdName);

            IEnumerable<XElement> names =
            from el in po
                .Elements("PurchaseOrder")
                .Elements("Address")
                .Elements("Name")
            select el;
            foreach (XElement e in names)
                Console.WriteLine("ele3" + e);

            XElement ele = po.Element("DeliveryNotes");
            Console.WriteLine(ele);

            XElement elem = new XElement("StringElement", "abcde");
            Console.WriteLine(elem);
            Console.WriteLine("Value of e:" + (string)elem);

            XElement root = XElement.Parse(@"<Root>
                <Child1>
                    <GrandChild1/>
                    <GrandChild2/>
                    <GrandChild3/>
                </Child1>
                <Child2>
                    <GrandChild4/>
                    <GrandChild5/>
                    <GrandChild6/>
                </Child2>
                <Child3>
                    <GrandChild7/>
                    <GrandChild8/>
                    <GrandChild9/>
                </Child3>
            </Root>");
            root.Element("Child1").Element("GrandChild1").Remove();
            root.Element("Child2").Elements().ToList().Remove();
            root.Element("Child3").Elements().Remove();
            Console.WriteLine(root);
            XElement root2 = new XElement("Root",
                new XElement("Child", "child content")
            );
            root2.SetValue("new content");
            Console.WriteLine(root);
        }

        private static void TestService()
        {
            //Step 1: Create an instance of the WCF proxy.
            CalculatorClient client = new CalculatorClient();

            // Step 2: Call the service operations.
            // Call the Add service operation.
            double value1 = 100.00D;
            double value2 = 15.99D;
            double result = client.Add(value1, value2);
            Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

            // Call the Subtract service operation.
            value1 = 145.00D;
            value2 = 76.54D;
            result = client.Subtract(value1, value2);
            Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);

            // Call the Multiply service operation.
            value1 = 9.00D;
            value2 = 81.25D;
            result = client.Multiply(value1, value2);
            Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);

            // Call the Divide service operation.
            value1 = 22.00D;
            value2 = 7.00D;
            result = client.Divide(value1, value2);
            Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);

            //Step 3: Closing the client gracefully closes the connection and cleans up resources.
            client.Close();
        }

        private static void RunService()
        {
            /// // Step 1 Create a URI to serve as the base address.
            Uri baseAddress = new Uri("http://localhost:8733/Design_Time_Addresses/GettingStartedWCFLib/Service1/mex");
            /// http://localhost:8733/Design_Time_Addresses/GettingStartedWCFLib/Service1/mex
            // Step 2 Create a ServiceHost instance
            ServiceHost selfHost = new ServiceHost(typeof(CalculatorService), baseAddress);

            try
            {
                // Step 3 Add a service endpoint.
                selfHost.AddServiceEndpoint(typeof(GettingStartedWCFLib.ICalculator), new WSHttpBinding(), "CalculatorService");

                // Step 4 Enable metadata exchange.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Step 5 Start the service.
                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}
