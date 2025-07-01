using System;
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

        // ❌ KHÔNG mã hóa nữa – dùng đúng mật khẩu gõ từ bàn phím
        public User Login(string TenDN, string MatKhau)
        {
            if (string.IsNullOrEmpty(TenDN) || string.IsNullOrEmpty(MatKhau))
                return null;

            return userDAL.loginUser(TenDN, MatKhau);
        }
    }
}
