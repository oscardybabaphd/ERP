using CubebarnRepository.GenericRepository;
using IdentityModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubebarnRepository.SiteMapRep
{
    public class SiteMap : GenericFunctions<SiteMapParentNode>
    {
        public SiteMap()
        {
            
        }

        public IList<SiteMapParentNode> _getAll()
        {
            var _result = GetAll().ToList();
            return _result;
        }

    }
}
