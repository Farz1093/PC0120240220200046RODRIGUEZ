using PC0120240220200046RODRIGUEZ.DOMAIN.Core.Entities;

namespace PC0120240220200046RODRIGUEZ.DOMAIN.Core.Interfaces
{
    public interface IAttendeesRepository
    {
        Task<IEnumerable<Attendees>> GetAttendes();
        Task<int> Insert(Attendees attendees);
    }
}