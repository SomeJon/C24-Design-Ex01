using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FacebookWrapper.ObjectModel.DynamicWrapper;

namespace FacebookPages.Code.Pages.Data
{
    public interface HasSetData
    {
        void SetData(dynamic i_DynamicData, eLoadOptions i_LoadOptions = eLoadOptions.None);
    }
}
