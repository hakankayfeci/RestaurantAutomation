using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public enum StaffState
    {
        UserNotExists = 0,//kullanıcı yok 
        PasswordWrong = 1,//Şifre Yanlış
        UsernameWrong = 2,//Kullanıcı adı Yanlış
        UserExists = 3//Kullanıcı var
          //asdADadADadA
    }
}
