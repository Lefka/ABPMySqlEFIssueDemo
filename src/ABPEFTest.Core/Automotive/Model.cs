using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;

namespace ABPEFTest.Automotive
{
    public class Model : FullAuditedEntity
    {
        public string Name { get; set; }
        public int MakeId { get; set; }
        public virtual Make Make { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
