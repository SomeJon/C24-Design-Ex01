using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Code.Pages.Data.Post
{
    public class PostData : PageData
    {
        private City m_Location;

        private static readonly Dictionary<eLoadOptions, string> sr_FieldsToLoad = new Dictionary<eLoadOptions, string>
        {
        {
            eLoadOptions.None,
            "id, name"
        },
        {
            eLoadOptions.Basic,
            "birthday,location{location},email,gender,hometown,name"
        },
        {
            eLoadOptions.Full,
            "birthday,location{location},email,gender,hometown,name"
        },
        {
            eLoadOptions.FullWithConnections,
            "birthday,location{location},email,gender,hometown,name"
        }
        };

        protected override Dictionary<eLoadOptions, string> FieldsToLoad => sr_FieldsToLoad;

        protected override void ResetForReFetch()
        {
            base.ResetForReFetch();
            m_Location = null;
        }
    }
}
