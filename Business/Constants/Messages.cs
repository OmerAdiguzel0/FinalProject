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
        public static string ProductAdded = "Ürün Eklendi!";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz!";
        public static string MaintenanceTime = "Bakım Zamanı";
        public static string ProductsListed= "Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir Kategoride En Fazla 10 Ürün Olabilir!";
        public static string ProductNameAlreadyExists = "Ürün Adı Zaten Mevcut!";
        public static string CategoryLimitExceded="Kategori Limiti Aşıldı!";
    }
}
