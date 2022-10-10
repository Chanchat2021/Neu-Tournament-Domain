using NeuTournament.Domain.Entities.Interfaces;

namespace NeuTournament.Domain.Entities
{
    public class Team : IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EventId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<TeamMember> TeamMembers { get; set; }
        public virtual Event Event { get; set; }

    }
}
