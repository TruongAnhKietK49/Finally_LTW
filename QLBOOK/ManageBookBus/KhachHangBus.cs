using ManageBookDTO;
using MangeBookDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookBus
{
    public class KhachHangBus
    {
        public static bool AddCustomer(KhachHangDTO cus)
        {
            try
            {
                KhachHangDAO.AddCustomer(cus);
                return true;
            }
            catch { return false; }
        }
        public static bool SignInCustomer(KhachHangDTO cus)
        {
            try
            {
                string result = KhachHangDAO.SignIn(cus);
                if(result != null) return true;
                else return false;
            }
            catch { return false; }
        }
    }
}
