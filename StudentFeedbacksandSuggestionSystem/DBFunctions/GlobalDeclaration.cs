using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace TESTING.DBFunctions
{
    internal class GlobalDeclaration
    {
            public static OleDbCommand command;
            public static OleDbDataReader reader;
            public static int itemcode;
            public static int ORNO;
    }
}
