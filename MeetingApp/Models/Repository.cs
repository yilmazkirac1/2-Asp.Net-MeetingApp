namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users=new();

        static Repository(){
            _users.Add(new UserInfo(){Name="Ali",Email="Ali@gmail.com",Phone="123123",WillAttend=true, Id=1});
            _users.Add(new UserInfo(){Name="Ayse",Email="Ayse@gmail.com",Phone="545433",WillAttend=true, Id=2});
            _users.Add(new UserInfo(){Name="Ahmet",Email="Ahmet@gmail.com",Phone="12451241",WillAttend=false, Id=3});
        }
        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user){
            user.Id=Users.Count+1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id){
            return _users.FirstOrDefault(user =>user.Id==id);
        }
    }
}