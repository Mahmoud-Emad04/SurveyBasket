

namespace SurveyBasket.Api.Services
{
	public class PollService : IPollService
	{
		private static readonly List<Poll> _Polls = [
			new Poll { Id = 1, Title = "Customer Satisfaction", Description = "Survey to measure customer satisfaction levels." },
			new Poll { Id = 2, Title = "Product Feedback", Description = "Gather feedback on our latest product." },
			new Poll { Id = 3, Title = "Employee Engagement", Description = "Assess employee engagement and workplace satisfaction." }
			];

		public IEnumerable<Poll> GetAll()
		{
			return _Polls;
		}
		public Poll? Get(int id)
		{
			return _Polls.FirstOrDefault(p => p.Id == id);
		}


		public Poll Add(Poll poll)
		{
			poll.Id = _Polls.Count + 1;
			_Polls.Add(poll);
			return poll;
		}
		public bool Update(int id, Poll poll)
		{
			Poll? existingPoll = Get(id);
			if(existingPoll is null)
				return false;
			existingPoll.Title = poll.Title;
			existingPoll.Description = poll.Description;
			return true;
		}
		public bool Delete(int id)
		{
			Poll? poll = Get(id);
			if(poll is null)
				return false;
			_Polls.Remove(poll);
			return true;
		}
	}
}
