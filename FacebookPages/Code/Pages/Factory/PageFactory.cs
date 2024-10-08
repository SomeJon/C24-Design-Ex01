using FacebookPages.Code.Pages.Data;
using FacebookPages.Code.Pages.Data.Post;
using FacebookPages.Code.Pages.Data.UserManager;
using FacebookPages.Code.Pages.Factory.Interfaces;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookPages.Code.Pages.Factory
{
    public class PageFactory : IPageFactory
    {
        private LoginPage m_LoginPage = new LoginPage();
        public EnhancedUser LoggedUser { get; private set; }
        

        public Page CreatePage(IHasSwitchPage i_PageChoice)
        {
            Page returningPage = null;
            EnhancedUser pageUser = i_PageChoice.NewPageOwner;
            SingleUserPagesData pagesData = null;

            if(pageUser != null)
            {
                pagesData = UserDataManager.GetUserData(pageUser);
            }

            switch (i_PageChoice.PageChoice)
            {
                case ePageChoice.HomePage:
                    if(LoggedUser == null) //Only happens on login
                    {
                        LoggedUser = pageUser;
                    }

                    pagesData = UserDataManager.GetUserData(LoggedUser);

                    returningPage = createHomePage(pagesData?.WallData);
                    break;
                case ePageChoice.WallPage:
                    returningPage = createWallPage(pagesData?.WallData);
                    break;
                case ePageChoice.Login:
                    returningPage = m_LoginPage;
                    break;
                case ePageChoice.LoginSetting:
                    returningPage = new LoginSettingPage();
                    break;
                case ePageChoice.AboutMePage:
                    returningPage = createAboutPage(pagesData?.AboutMeData);
                    break;
                case ePageChoice.FriendPage:
                    returningPage = createFriendPage(pageUser, pagesData?.WallData);
                    break;
                case ePageChoice.PicturePage:
                    returningPage = createPhotoPage(pagesData?.PhotoData);
                    break;
                case ePageChoice.AnalyticPage:
                    returningPage = createPostAnalyticPage(pagesData?.PostAnalyticData);
                    break;
                case ePageChoice.Logout:
                    UserDataManager.Clear();
                    LoggedUser = null;
                    returningPage = null;
                    break;
                case ePageChoice.Exit:
                    returningPage = null;
                    break;
            }

            return returningPage;
        }

        private Page createPostAnalyticPage(IPageData i_PageData)
        {
            PostAnalyticPage newWallPage = new PostAnalyticPage();

            newWallPage.PageData = (PostAnalyticData)i_PageData;

            return newWallPage;
        }

        private Page createFriendPage(EnhancedUser i_PageUser, IPageData i_PageData)
        {
            Page returningPage = string.Equals(i_PageUser?.Id.ToLower(), LoggedUser.Id.ToLower()) 
                                ? createHomePage(i_PageData) : createWallPage(i_PageData);

            return returningPage;
        }

        private Page createWallPage(IPageData i_PageData)
        {
            WallPage newWallPage = new WallPage();
            
            newWallPage.PageData = (WallPageData)i_PageData;

            return newWallPage;
        }

        private Page createHomePage(IPageData i_PageData)
        {
            WallPage newWallPage = (WallPage)createWallPage(i_PageData);

            newWallPage.SetAsHomePage();

            return newWallPage;
        }

        private Page createAboutPage(IPageData i_PageData)
        {
            AboutMePage aboutPage = new AboutMePage();

            aboutPage.PageData = (AboutMePageData)i_PageData;

            return aboutPage;
        }

        private Page createPhotoPage(IPageData i_PageData)
        {
            PhotosPage photosPage = new PhotosPage();

            photosPage.PageData = (PhotoPageData)i_PageData;
            
            return photosPage;
        }
    }
}