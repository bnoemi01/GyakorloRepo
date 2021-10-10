using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas_IRF_2.Entities
{
    class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();

        public string FullName { get; set; }
    }
}
