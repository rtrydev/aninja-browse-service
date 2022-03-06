using aninja_anime_service.Models;

namespace aninja_anime_service.Repositories;

public interface IAnimeRepository
{
    Task<bool> SaveChangesAsync();

    Task<IEnumerable<Anime>> GetAll();
    Task<Anime?> GetById(int id);
    Task<Anime> Create(Anime anime);
    Task Update(Anime anime);
    Task Delete(Anime anime);
}