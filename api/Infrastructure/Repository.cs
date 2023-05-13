using tspuWeb.Models;

namespace tspuWeb.Infrastructure
{
    public static class Repository
    {
        private static List<User> Users { get; set; } = new List<User>(); //список пользователей

        public static List<User> GetData() //Массив пользователей
        {
            return Users;
        }

        public static User? GetData(int id) //Получение пользователя по Id
        {
            return Users.FirstOrDefault(u => u.Id == id); //проверка на наличие пользователя с таким Id
        }

        public static void Add(User user) //Метод добавления пользователя
        {
            user.Id = Users.Count + 1;
            Users.Add(user);
        }

        public static void Delete(int id) //Метод удаления пользователя
        {
            var user = GetData(id);
            if (user != null)
            {
                Users.Remove(user);
            }
        }

        public static void Edit(User user) //Метод изменения пользователя по ID
        {
            var existingUser = GetData(user.Id);
            if (existingUser != null)  //Проверка на наличие пользователя с таким Id
            {
                //редактировать можно только UserName и Login
                existingUser.UserName = user.UserName;
                existingUser.Login = user.Login;
            }
        }



    }
}
