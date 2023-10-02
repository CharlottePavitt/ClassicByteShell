using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;



namespace ClassicByteShell
{
    public class ClassicByteShellException : Exception
    {
        public ClassicByteShellException() { }
        public ClassicByteShellException(string message) : base(message) {

            DateTime dt = new DateTime();
            dt.ToString("yyyy/MM/dd HH:mm:ss.fff");　
            StreamWriter Log = new StreamWriter("./logs/ExpectionOrErorr.classicbyteshell.log");
            Log.WriteLine(message);
            Log.Close();
        }
        public ClassicByteShellException(string message, Exception inner) : base(message, inner) { }
        protected ClassicByteShellException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
