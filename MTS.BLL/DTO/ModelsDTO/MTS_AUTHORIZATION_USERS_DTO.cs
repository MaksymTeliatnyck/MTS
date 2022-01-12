using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.BLL.DTO.ModelsDTO
{
    public class MTS_AUTHORIZATION_USERS_DTO
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string PWD { get; set; }
        public int? USER_GROUPS_ID { get; set; }
        public string LOGIN { get; set; }
        public int? ONLINE { get; set; }
    }
}
