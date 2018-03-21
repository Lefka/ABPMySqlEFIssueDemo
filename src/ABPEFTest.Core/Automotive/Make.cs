using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;

namespace ABPEFTest.Automotive
{
    public class Make : FullAuditedEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}
