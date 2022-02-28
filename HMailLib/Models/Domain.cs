using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMailLib.Models
{
    public class Domain
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool Active { get; set; }
        //public Accounts Accounts { get; set; }
        //public Aliases Aliases { get; set; }
        //public DistributionLists DistributionLists { get; set; }
        public string Postmaster { get; set; }
        //public DomainAliases DomainAliases { get; set; }
        public string ADDomainName { get; set; }
        public int MaxMessageSize { get; set; }
        public bool PlusAddressingEnabled { get; set; }
        public string PlusAddressingCharacter { get; set; }
        public bool AntiSpamEnableGreylisting { get; set; }
        public int MaxSize { get; set; }
        public int Size { get; set; }
        public long AllocatedSize { get; set; }
        public bool SignatureEnabled { get; set; }
        //public eDomainSignatureMethod SignatureMethod { get; set; }
        public string SignaturePlainText { get; set; }
        public string SignatureHTML { get; set; }
        public bool AddSignaturesToReplies { get; set; }
        public bool AddSignaturesToLocalMail { get; set; }
        public int MaxNumberOfAccounts { get; set; }
        public int MaxNumberOfAliases { get; set; }
        public int MaxNumberOfDistributionLists { get; set; }
        public bool MaxNumberOfAccountsEnabled { get; set; }
        public bool MaxNumberOfAliasesEnabled { get; set; }
        public bool MaxNumberOfDistributionListsEnabled { get; set; }
        public int MaxAccountSize { get; set; }
        public bool DKIMSignEnabled { get; set; }
        public string DKIMSelector { get; set; }
        public string DKIMPrivateKeyFile { get; set; }
        //public eDKIMCanonicalizationMethod DKIMHeaderCanonicalizationMethod { get; set; }
        //public eDKIMCanonicalizationMethod DKIMBodyCanonicalizationMethod { get; set; }
        //public eDKIMAlgorithm DKIMSigningAlgorithm { get; set; }

    }
}
