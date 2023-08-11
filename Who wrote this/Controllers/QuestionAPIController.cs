using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Who_wrote_this.Models;

namespace Who_wrote_this.Controllers
{
    [Route("controller")]
    [ApiController]
    public class QuestionAPIController : ControllerBase
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionAPIController(IQuestionRepository questionRepository)
        {
            this._questionRepository = questionRepository;
        }
        [HttpGet(Name = "GetAll")]
        public IEnumerable<Question> GetAll()
        {
            return _questionRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetById")]
        public ActionResult GetById(int id)
        {
            var question = this._questionRepository.GetById(id);
            return new JsonResult(question);
        }
    }
}
