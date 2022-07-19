using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chat
{

    [Serializable()] // this object can be serialized

    public class StreamedObject
    {
        private string host, data;

        public StreamedObject(string host, string data) {
            this.host = host; this.data = data;
        }

        public string Host
        {
            get
            {
                return this.host;
            }
        }

        public string Data
        {
            get
            {
                return this.data;
            }
        }

        public override string ToString()
        {
            return "Object type: " + this.GetType().ToString() + " | Data value: " + this.data + " | Host value: " + this.host;
        }
    }
}
