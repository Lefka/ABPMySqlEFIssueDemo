using Abp.Domain.Entities.Auditing;

namespace ABPEFTest.Automotive
{
    public class Car : FullAuditedEntity
    {
        public string Name { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
    }
}
