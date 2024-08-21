using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DtoPost : Dto
    {
        public enum eType
        {
            link,
            photo,
            video,
            checkin,
            status,
            swf
        }


    }
}
