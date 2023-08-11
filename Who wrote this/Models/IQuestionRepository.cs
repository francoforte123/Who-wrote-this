namespace Who_wrote_this.Models
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetAll();
        Question GetById(int id);
        void Add(Question question);
    }
}
