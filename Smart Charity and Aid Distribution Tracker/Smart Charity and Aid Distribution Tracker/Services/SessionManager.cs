using Smart_Charity_and_Aid_Distribution_Tracker.Models;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Services
{
    public static class SessionManager
    {
        private static User _currentUser;

        public static void SetCurrentUser(User user)
        {
            _currentUser = user;
        }


        public static User GetCurrentUser()
        {
            return _currentUser;
        }

        public static bool IsUserLoggedIn()
        {
            return _currentUser != null;
        }

        public static void Logout()
        {
            _currentUser = null;
        }
    }
}
