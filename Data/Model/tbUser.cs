using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class tbUser
    {
        public int ID { get; set; }
        public string? Username { get; set; }    
        public string? Email { get; set; }
        public string? Password { get; set; }
        public float? IsDeleted { get; set; }
        public DateTime? Accesstime { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
