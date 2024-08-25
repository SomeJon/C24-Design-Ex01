using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchHandler.Fetch
{
    public class FacebookCollectionWithPaging<T>
    {
        public FacebookObjectCollection<T> Collection { get; } = new FacebookObjectCollection<T>();


    }
}
