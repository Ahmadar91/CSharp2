using Model.Models;

namespace Controller
{
	public interface IMapper
	{
		Invoice Map(string[] content);
	}
}