using NeuTournament.Domain.Entities.Enum;
using NeuTournament.Domain.Entities.Interfaces;

namespace NeuTournament.Domain.Entities
{
    public class Event : IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public EventType EventType { get; set; }
        public Location Location { get; set; }
        public byte[]? Banner { get; set; }
        public string Rules { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public FeeType FeeType { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<Team> Teams { get; set; }

    }
}
