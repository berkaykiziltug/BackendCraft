using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //degisken olmasina ragmen buyuk harfle yazdik cunku public. Publicler pascal case yazilir. Bu bir field.
        public static string ProductAdded = "Urun Eklendi.";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string ProductsListed = "Urunler Listelendi";
        public static string MaintenanceTime = "Maintenance";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 urun olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten baska bir urun var";
        public static string CategoryLimitExceeded = "Kategori limiti asildi";
        public static string AuthorizationDenied="Yetkiniz yok.";
    }
}
