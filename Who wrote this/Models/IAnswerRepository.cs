namespace Who_wrote_this.Models
{
    public interface IAnswerRepository
    {
        IEnumerable<Answer> GetAll();
        Answer GetById(int id);
        void Add(Answer answer);
    }
}
