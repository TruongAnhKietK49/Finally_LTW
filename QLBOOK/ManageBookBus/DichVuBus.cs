using ManageBookDAO;
using ManageBookDTO;
using MangeBookDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookBus
{
    public class DichVuBus
    {
        public static List<DichVuDTO> GetListDV()
        {
            return DichVuDAO.GetListDV();
        }
        public static bool themDV(DichVuDTO dvDTO)
        {
            try
            {
                DichVuDAO.themDV(dvDTO);

                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool suaDV(DichVuDTO dvDTO)
        {
            try
            {
                DichVuDAO.suaDV(dvDTO);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool xoaDV(DichVuDTO dvDTO)
        {
            try
            {
                DichVuDAO.xoaDV(dvDTO);

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
