using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public enum UpdateResult
    {
        Success,
        NotFound,
        InvalidStatus,
        RoomNotAvailable,
        RoomConflict
    }
}
