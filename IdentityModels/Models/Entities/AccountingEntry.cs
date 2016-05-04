using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityModels.Models.Entities
{
    public class AccountingEntry
    {
        public AccountingEntry()
        {

        }

        public int AccountingEntryID { get; set; }
        public string AccountNo { get; set; }
    }
}
