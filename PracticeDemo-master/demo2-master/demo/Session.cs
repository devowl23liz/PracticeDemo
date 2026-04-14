using demo.Models;

namespace demo
{
    public static class Session
    {
        public static Employee CurrentUser { get; set; }

        public static bool IsAuthenticated => CurrentUser != null;
        public static bool IsAdmin => CurrentUser?.Role?.ToLower() == "admin" || CurrentUser?.Role?.ToLower() == "администратор";
        public static bool IsManager => CurrentUser?.Role?.ToLower() == "manager" || CurrentUser?.Role?.ToLower() == "менеджер";
        public static bool IsClient => CurrentUser?.Role?.ToLower() == "client" || CurrentUser?.Role?.ToLower() == "клиент";
    }
}