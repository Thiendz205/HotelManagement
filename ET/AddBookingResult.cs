using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public enum AddBookingResult
    {
        Success,                   // Đặt phòng thành công (khách đã tồn tại)
        CustomerAddedBookingAdded, // Thêm mới cả khách và booking
        DuplicateCustomerConflict, // Trùng thông tin khách nhưng khác dữ liệu
        RoomConflict,              // Phòng bị trùng giờ (cách < 1h)
        Error                      // Lỗi khác
    }
}
