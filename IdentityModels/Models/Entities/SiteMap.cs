using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityModels.Models.Entities
{
    public class SiteMapParentNode
    {
        public SiteMapParentNode()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SiteMapParentNodeID { get; set; }
        [StringLength(100)]
        public string ParentRootName { get; set; }
        public virtual IList<SiteMapSubParentNode> SiteMapSubParentNode { get; set; }

    }

    public class SiteMapSubParentNode
    {
        public SiteMapSubParentNode()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SiteMapSubParentNodeID { get; set; }
        [StringLength(100)]
        public string SubParentRootName { get; set; }
        public virtual IList<SiteMapUrlLabel> SiteMapUrlLabel { get; set; }
        public int? SiteMapParentNodeID { get; set; }
        [ForeignKey("SiteMapParentNodeID")]
        public virtual SiteMapParentNode SiteMapParentNode { get; set; }
    }

    public class SiteMapUrlLabel
    {
        public SiteMapUrlLabel()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SiteMapUrlLabelID { get; set; }
        [StringLength(100)]
        public string Url { get; set; }
        [StringLength(100)]
        public string Label { get; set; }
        public int? SiteMapSubParentNodeID { get; set; }
        [ForeignKey("SiteMapSubParentNodeID")]
        public virtual SiteMapSubParentNode SiteMapSubParentNode { get; set; }
    }


}
