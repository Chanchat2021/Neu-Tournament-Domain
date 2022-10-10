using NeuTournament.Domain.Entities.Interfaces;

namespace NeuTournament.Domain.Entities
{
    public class Registration : IBaseEntity
    {
        public int Id { get; set; }
        public string EmailId { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }

    }

}
