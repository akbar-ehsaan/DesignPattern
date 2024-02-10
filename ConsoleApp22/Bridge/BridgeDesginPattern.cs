using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22.Bridge
{

    public abstract class DataObject
    {
        public abstract void NextRecord();
        public abstract void PriorRecord();
        public abstract void AddRecord(string name);
        public abstract void DeleteRecord(string name);
        public abstract string GetCurrentRecord();
        public abstract void ShowRecord();
        public abstract void ShowAllRecord();
    }
    public class CustomerData : DataObject
    {
        private readonly List<string> customers = new List<string>();
        private int current = 0;
        private string city;
        public CustomerData(string city)
        {
            this.city = city;
            customers.Add("Jim Jones");
            customers.Add("Samual Jackson");
            customers.Add("Allen Good");
            customers.Add("Ann Stills");
            customers.Add("Lisa Giolani");
        }
        public override void NextRecord()
        {
            if (current <= customers.Count - 1)
            {
                current++;
            }
        }

        public override void PriorRecord()
        {
            if (current > 0)
            {
                current--;
            }
        }

        public override void AddRecord(string name)
        {
            customers.Add(name);
        }

        public override void DeleteRecord(string name)
        {
            customers.Remove(name);
        }

        public override string GetCurrentRecord()
        {
            return customers[current];
        }

        public override void ShowRecord()
        {
            Console.WriteLine(customers[current]);
        }

        public override void ShowAllRecord()
        {
            Console.WriteLine("Customer City: " + city);
            foreach (string customer in customers)
            {
                Console.WriteLine(" " + customer);
            }
        }
    }

    public class CustomerBase
    {
        private DataObject dataObject;

        public DataObject Data
        {

            set => dataObject = value;
            get => dataObject;
        }

        public virtual void Next() =>
            dataObject.NextRecord();
        public virtual void Prior() =>
            dataObject.PriorRecord();

        public virtual void Add(string customer) =>
            dataObject.AddRecord(customer);
        public virtual void Delete(string customer) =>
            dataObject.DeleteRecord(customer);
        public virtual void Show() =>
            dataObject.ShowRecord();

        public virtual void ShowAll() =>
            dataObject.ShowAllRecord();
    }
    public class Customers : CustomerBase
    {
        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }

}
