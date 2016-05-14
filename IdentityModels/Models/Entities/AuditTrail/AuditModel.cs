using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IdentityModels.Models.Entities.AuditModel
{
    public class AuditModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AuditID { get; set; }
        /// <summary>
        /// The type of Action that occured. It could either be create, update or delete.
        /// </summary>
        public CubebarnRepository.Enums.EnumiratedData.Action Action { get; set; }
        public string SessionID { get; set; }
        /// <summary>
        /// The IP Address of the machine this action was performed on.
        /// </summary>
        public string IPAddress { get; set; }
        /// <summary>
        /// The User Name of the person that performed this action. 
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// The URL 
        /// </summary>
        public string URLAccessed { get; set; }
        /// <summary>
        /// The Date this Action happened.
        /// </summary>
        public DateTime ActionDate { get; set; }
        /// <summary>
        /// The Data that was accessed in JSON
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// The name of the current application.
        /// </summary>
        public virtual string ApplicationName { get; set; }

        public AuditModel() { }
    }
}