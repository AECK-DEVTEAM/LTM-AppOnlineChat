using System.Collections;

namespace TCP_Private_Server
{
    public class Group
    {
        public string id;
        public string name;
        public Hashtable clients = new Hashtable();
    }
}