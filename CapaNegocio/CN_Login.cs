using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Login
    {
        public bool Login(string usuario, string password)
        {
            CD_Login login = new CD_Login();
            return login.Login(usuario, password);
        }
    }
}
