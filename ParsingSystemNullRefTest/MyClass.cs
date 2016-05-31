using System;
using System.Threading.Tasks;

namespace ParsingSystemNullRefTest
{
	public class MyClass
	{
		ViewModel viewModel;

		public MyClass ()
		{
			viewModel = new ViewModel ();
		}

		public void Run ()
		{
			viewModel.LoadPackagesAsyncTask = (token) => {
				return Task.Run	(() => throw new Exception ("Error"));
			};
		}
	}
}

