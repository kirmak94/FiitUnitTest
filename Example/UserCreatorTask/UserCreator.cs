using System.Text.RegularExpressions;

namespace UserCreatorTask
{
    public class UserCreator
    {
        public void CreateNewUser(User newUser)
        {
            //Проверяем имя
            var nameRegex = new Regex(@"^[a-zA-Z]+ [a-zA-Z]+$");
            if (!nameRegex.Match(newUser.Name).Success)
            {
                throw new InvalidUserException("InvalidName");
            }

            //Проверяем email
            var emailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            if (!emailRegex.Match(newUser.Email).Success)
                throw new InvalidUserException("InvalidEmail");

            //Проверяем пароль
            var passwordRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            if (!passwordRegex.Match(newUser.Password).Success)
                throw new InvalidUserException("InvalidPassword");

            //Проверяем есть ли такой пользователь
            var usersRepository = new UsersRepository();
            var user = usersRepository.GetUser(newUser.Email);
            if (user != null)
                throw new InvalidUserException("UserAlreadyExists");

            //Сохраняем в бд
            usersRepository.SaveUserToDatabase(newUser);
        }
    }
}