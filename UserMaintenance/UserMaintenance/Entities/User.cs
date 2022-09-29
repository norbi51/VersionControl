using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaintenance.Entities
{
    public class User // itt fontos a public, hogy látszódjon máshol is
    {
            public Guid ID { get; set; } = Guid.NewGuid();
            
            public string FullName
            {
            get;set;
            }
    }
}
