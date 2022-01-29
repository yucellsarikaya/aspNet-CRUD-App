using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordErrror = "Şifre hatalı";

        public static string SuccessfulLogin = "Sisteme giriş başarılı";

        public static string UserAlreadyExists = "Bu kullanıcı mevcut";

        public static string UerRegistered = "Kullanıcı başarıyla kaydedildi";

        public static string AccessTokenCreated = "Token başarıyla oluşturuldu";
    }
}
