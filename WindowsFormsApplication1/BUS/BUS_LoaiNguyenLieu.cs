using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.BUS
{
    class BUS_LoaiNguyenLieu
    {
        private DAL_LoaiNguyenLieu dalLoaiNguyenLieu = new DAL_LoaiNguyenLieu();

        // Phương thức để lấy tất cả loại nguyên liệu
        public List<LoaiNguyenLieuDTO> GetAllLoaiNguyenLieu()
        {
            return dalLoaiNguyenLieu.GetAllLoaiNguyenLieu();
        }
    }
}
