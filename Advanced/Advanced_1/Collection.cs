using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Advanced_1
{
    class Collection
    {
        List<int> myList = new List<int>();
        public void Add(int a)
        {
            myList.Add(a);
        }
        
        public void Remove(int b)
        {
            myList.Remove(b);
        }


        System.String myString = " ";

        public void AddString(string n)
        {
            string firstName = n;
        }

        public void RemoveString(string n)
        {
            string firstName = myString;
        }


        System.String myDouble = " ";

        public void AddDouble(string k)
        {
            string firstName = k;
        }

        public void RemoveDouble(string q)
        {
            string firstName = myString;
        }


    }
}
