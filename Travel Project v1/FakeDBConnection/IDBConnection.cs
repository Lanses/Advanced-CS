using System;
using System.Collections.Generic;
using System.Text;

namespace FakeDBConnection
{
    public interface IDBConnection
    {
        void Open();
        void Close();
        string ExecuteConnection(string connection);
    }
}
