

namespace SurveyBasket.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PollsController(IPollService pollService) : ControllerBase
	{
		private readonly IPollService _pollService = pollService;

		[HttpGet]
		public IActionResult GetAll()
		{
			var polls = _pollService.GetAll();
			return Ok(polls);
		}

		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			var poll = _pollService.Get(id);
			if (poll is null)
				return NotFound();
			return Ok(poll);
		}

		[HttpPost]
		public IActionResult Add(Poll poll)
		{
			var createdPoll = _pollService.Add(poll);
			return CreatedAtAction(nameof(Get), new { id = createdPoll.Id }, createdPoll);
		}

		[HttpPut("{id}")]
		public IActionResult Update(int id, Poll poll)
		{
			if (id != poll.Id)
				return BadRequest();
			var updated = _pollService.Update(id, poll);
			if (!updated)
				return NotFound();
			return NoContent();
		}
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var deleted = _pollService.Delete(id);
			if (!deleted)
				return NotFound();
			return NoContent();
		}

	}
}
