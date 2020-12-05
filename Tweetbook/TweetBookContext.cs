using Microsoft.EntityFrameworkCore;
using Tweetbook.Models;

namespace Tweetbook
{
    /// <summary>
    /// TweetBookContext
    /// </summary>
    public class TweetBookContext : DbContext
    {
        /// <summary>
        /// TweetBookContext
        /// </summary>
        /// <param name="options"></param>
        public TweetBookContext(DbContextOptions<TweetBookContext> options) : base(options)
        {
        }
        
        /// <summary>
        /// Authors
        /// </summary>
        public virtual DbSet<Author>Authors { get; set; }
    }
}