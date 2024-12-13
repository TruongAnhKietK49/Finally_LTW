using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageBookDTO;
using MangeBookDAO;

namespace ManageBookBus
{
    public class NhanVienBus
    {
        public static bool SignInEmployee(NhanVienDTO emp)
        {
            try
            {
                string result = NhanVienDAO.SignInEmployee(emp);
                if(result != null) return true;
                else return false;
            }
            catch { return false; }
        }
    }
}
