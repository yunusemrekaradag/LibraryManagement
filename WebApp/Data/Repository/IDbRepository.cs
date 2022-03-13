using WebApp.Data.Domain;

namespace WebApp.Data.Repository
{
    public partial interface IDbRepository
    {
        #region Books Methods
        Task<List<Book>> GetAllBooksAsync();
        Task<List<Book>> GetBooksByIdAsync(int bookId);
        Task<List<Book>> GetBooksByCategoryIdAsync(int categoryId);
        Task<List<Book>> GetBooksByWriterIdAsync(int writerId);
        Task<Book> InsertBookAsync(Book book);
        Task<Book> DeleteBookAsync(Book book);
        Task<Book> UpdateBookAsync(Book book);

        #endregion

        #region Writers Methods
        Task<List<Writer>> GetAllWriterAsync();
        Task<Writer> InsertWriterAsync(Writer writer);
        Task<Writer> DeleteWriterAsync(Writer writer);
        Task<Writer> UpdateWriterAsync(Writer writer);
        #endregion

        #region Categories Methods
        Task<List<Category>> GetAllCategoryAsync();
        Task<Category> InsertCategoryrAsync(Category category);
        Task<Category> DeleteCategoryAsync(Category category);
        Task<Category> UpdateCategoryAsync(Category category);
        #endregion

        #region Users Books
        Task<List<UserBook>> GetBookByUserBook(int userBookId);
        #endregion

        #region Users Methods
        Task<List<User>> GetAllUserAsync();
        Task<User> InsertUserAsync(User user);
        Task<User> DeleteUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        #endregion
    }
}
