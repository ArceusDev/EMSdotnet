using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BaseLib.Entities
{
    public class Relationship
    {
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}
