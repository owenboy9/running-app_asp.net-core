using RunApp.Data;
using RunApp.Interfaces;
using RunApp.Models;

namespace RunApp.Repository
{
    public class ClubRepository : IClubRepository
    {
        private readonly ApplicationDbContext _context;

        public ClubRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Club club)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Club club)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Club>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Club> GetByIcAcync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Club>> GetClubByCity(string city)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Club club)
        {
            throw new NotImplementedException();
        }
    }
}