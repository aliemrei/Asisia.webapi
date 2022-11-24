namespace Asisia.webapi.JWT;

public class LoginUserModel
    {
        public int CorpId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class LogedUserModel 
    {
        public string username { get; set; }
        public string fullName { get; set; }
        public long? tel { get; set; }
        public string email { get; set; }
    }