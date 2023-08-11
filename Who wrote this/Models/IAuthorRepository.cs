namespace Who_wrote_this.Models
{
    public interface IAuthorsRepository
    {
        List<Author> GetAll();
        Author GetById(int id);

        void Add(Author author);
    }
}
