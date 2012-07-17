
namespace DangerWillRobinson
{

	public class Program
	{
		#region Methods

		private static void Main(string[] args)
		{
			string serviceName = "Default Service Name";
			string failCount = "Default failCount";

			if (args.Length >= 2)
			{
				serviceName = args[0];
				failCount = args[1];
			}

			Emailer emailer = new Emailer(serviceName, failCount);
			emailer.FlapArmsWildly();
		}

		#endregion
	}
}