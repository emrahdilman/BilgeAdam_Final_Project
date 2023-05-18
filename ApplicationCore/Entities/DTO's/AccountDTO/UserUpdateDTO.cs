using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities.Concrete;

namespace ApplicationCore.Entities.DTO_s.AccountDTO
{
    public class UserUpdateDTO
    {
        [Required(ErrorMessage = "Kullanıcı adı zorunludur")]
        [DisplayName("Kullanıcı Adı")]
        [MinLength(3, ErrorMessage = "En az 3 karakter girmelisiniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email zorunludur")]
        [DisplayName("E-Mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email adresinizi doğru formatta giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur")]
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public UserUpdateDTO()
        {
            
        }

        public UserUpdateDTO(ApplicationUser user)
        {
            UserName = user.UserName;
            Password = user.PasswordHash;
            Email = user.Email;
        }
    }
}
