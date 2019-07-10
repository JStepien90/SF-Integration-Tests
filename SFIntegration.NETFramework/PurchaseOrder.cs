using Salesforce.Common;
using Salesforce.Common.Models.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFIntegration.NETFramework
{
    public class PurchaseOrder : IAttributedObject
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public ObjectAttributes Attributes { get; set; } = new ObjectAttributes
        {
            Type = "Purchase_Order__c",
            ReferenceId = Guid.NewGuid().ToString()
        };
    }
}
