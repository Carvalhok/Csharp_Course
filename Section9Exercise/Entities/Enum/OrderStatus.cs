using System;
using System.Collections.Generic;
using System.Text;

namespace Section9Exercise.Entities.Enum
{
    enum OrderStatus : int
    {
        PendingPeyment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
