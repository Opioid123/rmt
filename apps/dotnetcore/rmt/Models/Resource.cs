using System;

namespace rmt
{
    public class Resource
    {
        public Data[] Data { get; set; }
    }

    public class Data {
        public string LDAP { get; set; }

        public string Name { get; set; }

        public string Id { get; set; } 
        public string Role { get; set; }
    }
}
    