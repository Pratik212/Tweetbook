using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiPractice.Interfaces;
using Tweetbook;
using Tweetbook.Models;

namespace WebApiPractice.Providers
{
    /// <summary>
    /// AuthorRepository
    /// </summary>
    public class AuthorRepository : IAuthorRepository
    {
        private readonly TweetBookContext _context;

        /// <summary>
        /// AuthorRepository
        /// </summary>
        /// <param name="context"></param>
        public AuthorRepository(TweetBookContext context)
        {
            _context = context;
        }
        
        /// <summary>
        /// GetAllAuthor
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Author>> GetAllAuthor()
        {
            return await _context.Authors.ToListAsync();
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        public async Task<Author> Add(Author author)
        {
            var result = await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Author> Update(Author author)
        {
            var result = await _context.Authors.FirstOrDefaultAsync(x => x.Id == author.Id);

            if (result != null)
            {
                result.Name = author.Name;
                
                await _context.SaveChangesAsync();
                return result;
            }

            return null;
        }
    }
}