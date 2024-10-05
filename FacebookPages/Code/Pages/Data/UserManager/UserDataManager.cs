using System;
using System.Collections.Generic;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookPages.Code.Pages.Data.UserManager
{
    public class UserDataManager
    {
        private static UserDataManager s_Instance = null;
        private Dictionary<string, SingleUserPagesData> DataDictionary { get; } = new Dictionary<string, SingleUserPagesData>();
        private static readonly object sr_LockObj = new object();


        private UserDataManager() { }

        public static UserDataManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new UserDataManager();
                        }
                    }
                }


                return s_Instance;
            }
        }

        public SingleUserPagesData GetUserData(EnhancedUser i_User)
        {
            if(!DataDictionary.ContainsKey(i_User.Id))
            {
                SingleUserPagesData newPagesData = new SingleUserPagesData(i_User);
                DataDictionary[i_User.Id] = newPagesData;
            }

            return DataDictionary[i_User.Id];
        }
    }
}