using ManageBookDAO;
using ManageBookDTO;
using ManageStuDAO;
using System.Data;
using System.Data.SqlClient;

namespace ManageBookBus
{
    public class SachBus
    {
        public static List<SachDTO> layDSSach()
        {
            return SachDAO.layDSSach();
        }
        public static List<SachDTO> timTheoTenSach(string ten)
        {

            return SachDAO.timTheoTenSach(ten);
        }
    }
}
