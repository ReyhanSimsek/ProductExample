using System;
using System.Collections.Generic;
using System.Text;

namespace EMutfakWebApi.Models
{
    public class Products
    {
        /*
         TCKN (Number/11 haneli regex validation) 
         - İsim Soyisim (OnlyText) 
         - Şifre ve Yeniden Şifre (şifreler eşleşiyor mu kontrolü / masked Text | Hazır bir yapı kullanılmaması için ekledik) 
         - Fiyat (decimal) 
         - Dolar/Euro/TL (Dropdown) 
         - CalculatedValue (Fiyat*Döviz Kuru: Kuru 
         */
        public int ID { get; set; }
        public int TCKN { get; set; }
        public string NameSurname { get; set; }
        public string Password { get; set; }
        public string PasswordReply { get; set; }
        public decimal Price { get; set; }
        public string Rate { get; set; }
        public decimal CalculatedValue { get; set; }
    }
}
