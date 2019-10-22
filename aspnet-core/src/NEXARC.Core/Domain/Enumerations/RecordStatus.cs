using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXARC.Domain.Enumerations
{
    public enum RecordStatus
    {
        ACTIVE = 200, //Accessible and visible to all permitted users
        INACTIVE = 400, //
        TRASHED = 404,
        LOCKED = 423,
        DEPROVISIONED = 401,
        ARCHIVED = 428,
    }
}
