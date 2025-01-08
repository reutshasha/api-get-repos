using Shared.Models;

namespace BL.Interfaces
{
    public interface IFavoriteService
    {
        Task AddFavoriteAsync(GitHubRepository favorite);
        Task<List<GitHubRepository>> GetFavoriteByIdAsync(string userId);
        Task<List<GitHubRepository>> GetFavoritesAsync();

    }
}