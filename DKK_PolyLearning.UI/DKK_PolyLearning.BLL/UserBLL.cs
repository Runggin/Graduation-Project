using System;
using System.Security.Cryptography;
using System.Text;
using DKK_PolyLearning.DAL;
using DKK_PolyLearning.DTO;

namespace DKK_PolyLearning.BLL
{
    public class UserBLL
    {
        private readonly UserDAL userDAL;

        public UserBLL()
        {
            userDAL = new UserDAL();
        }

        private string HashPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public bool RegisterUser(User user)
        {
            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
                throw new Exception("Username và Password không được để trống!");
            user.Password = HashPassword(user.Password);
            return userDAL.RegisterUser(user);
        }
    }
}