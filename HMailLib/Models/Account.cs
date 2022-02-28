using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMailLib.Models
{
    public class Account
    {
        public bool? Active { get; set; }
        public string? ADDomain { get; set; }
        public string? Address { get; set; }
        public int? DomainID { get; set; }
        public int? ID { get; set; }
        public bool? IsAD { get; set; }
        public string? Password { get; set; }
        public float? Size { get; set; }
        public string? ADUsername { get; set; }
        public int? MaxSize { get; set; }
        public bool? VacationMessageIsOn { get; set; }
        public string? VacationMessage { get; set; }
        public string? VacationSubject { get; set; }
        public int? QuotaUsed { get; set; }
        public bool? ForwardEnabled { get; set; }
        public string? ForwardAddress { get; set; }
        public bool? ForwardKeepOriginal { get; set; }
        public bool? SignatureEnabled { get; set; }
        public string? SignaturePlainText { get; set; }
        public string? SignatureHTML { get; set; }
        //public object LastLogonTime { get; set; }
        //public bool VacationMessageExpires { get; set; }
        //public string VacationMessageExpiresDate { get; set; }
        public string? PersonFirstName { get; set; }
        public string? PersonLastName { get; set; }

        // public virtual Messages Messages { get; set; }
        // public virtual FetchAccounts FetchAccounts { get; set; }
        // public virtual eAdminLevel AdminLevel { get; set; }
        // public virtual Rules Rules { get; set; }
        // public virtual IMAPFolders IMAPFolders { get; set; }
    }
}
