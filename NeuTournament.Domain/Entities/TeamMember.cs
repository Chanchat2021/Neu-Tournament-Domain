using NeuTournament.Domain.Entities.Interfaces;

namespace NeuTournament.Domain.Entities
{
    public class TeamMember : IBaseEntity
    {
        public TeamMember(int teamId, string emailId)
        {
            TeamId = teamId;
            EmailId = emailId;
        }
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string EmailId { get; set; }

        public virtual Team Team { get; set; }
    }
}
