using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class Session
    {
        public static int SessionId;
        public static string SessionUsername;
        public static string SessionPassword;
        public static string SessionRole;
        public static byte SessionInicio;
        public static byte foto;

        public static string Username()
        {
            return "Usuario: " + SessionUsername + ", Rol: " + SessionRole;
        }

    }
}
