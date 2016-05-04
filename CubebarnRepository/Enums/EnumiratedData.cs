using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubebarnRepository.Enums
{
    public class EnumiratedData
    {
        public EnumiratedData()
        {

        }

        public enum Status
        {
            None = 0,
            Successful = 1,
            Failed = 2
        }

        public enum Action
        {
            Save = 1,
            Update = 2,
            Delete = 3,
        }
    }
}
