using System.Collections.Generic;
using System.Threading.Tasks;
using Tweetbook.Models;

namespace WebApiPractice.Interfaces
{
    /// <summary>
    /// IAuthorRepository
    /// </summary>
    public interface IAuthorRepository
    {
        /// <summary>
        /// GetAllAuthor
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Author>> GetAllAuthor();

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        Task<Author> Add(Author author);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        Task<Author>Update(Author author);
    }
}