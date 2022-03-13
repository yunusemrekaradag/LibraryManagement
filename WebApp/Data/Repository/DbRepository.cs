using Microsoft.EntityFrameworkCore;
using WebApp.Data.Domain;

namespace WebApp.Data.Repository
{
    public class DbRepository : IDbRepository
    {
        private readonly MyDbContext _context;

        public DbRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Book> DeleteBookAsync(Book book)
        {
            _context.Books.Remove(book); 
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<Category> DeleteCategoryAsync(Category category)
        {
           _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<User> DeleteUserAsync(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<Writer> DeleteWriterAsync(Writer writer)
        {
            _context.Writers.Remove(writer);
            await _context.SaveChangesAsync();
            return writer;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.Books.OrderBy(p => p.BookName).ToListAsync();
        }

        public async Task<List<Category>> GetAllCategoryAsync()
        {
            return await _context.Categories.OrderBy(p => p.CategoryName).ToListAsync();
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            return await _context.Users.OrderBy(p => p.FirstName).ToListAsync();
        }

        public async Task<List<Writer>> GetAllWriterAsync()
        {
            return await _context.Writers.OrderBy(p => p.WriterName).ToListAsync();
        }

        public async Task<List<UserBook>> GetBookByUserBook(int userBookId)
        {
            return await _context.UserBooks.Where(p =>p.Id== userBookId).ToListAsync();
        }

        public async Task<List<Book>> GetBooksByCategoryIdAsync(int categoryId)
        {
            return await _context.Books.Where(p=>p.Category.Id== categoryId).ToListAsync();
        }

        public async Task<List<Book>> GetBooksByIdAsync(int bookId)
        {
          return await _context.Books.Where(p=>p.Id==bookId).ToListAsync();
        }

        public async Task<List<Book>> GetBooksByWriterIdAsync(int writerId)
        {
            return await _context.Books.Where(p=>p.Id==writerId).ToListAsync();
        }

        public async Task<Book> InsertBookAsync(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<Category> InsertCategoryrAsync(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<User> InsertUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<Writer> InsertWriterAsync(Writer writer)
        {
            _context.Writers.Add(writer);
            await _context.SaveChangesAsync();
            return writer;
        }

        public async Task<Book> UpdateBookAsync(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<Category> UpdateCategoryAsync(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<Writer> UpdateWriterAsync(Writer writer)
        {
            _context.Writers.Update(writer);
            await _context.SaveChangesAsync();
            return writer;
        }
    }
}
