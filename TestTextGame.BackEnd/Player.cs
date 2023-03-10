using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.IO;
using System.Runtime.ExceptionServices;

namespace TestTextGame.BackEnd
{
    class Player : Type
    {
        private List<Item> items;
        
        [DataMember(Name = "items")]
        public List<Item> Items { get { return items; } set { items = value; } }


    }
}
