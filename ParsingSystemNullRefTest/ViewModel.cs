using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParsingSystemNullRefTest
{
	public class ViewModel
	{
		public Func<CancellationToken, Task> LoadPackagesAsyncTask;
	}
}

