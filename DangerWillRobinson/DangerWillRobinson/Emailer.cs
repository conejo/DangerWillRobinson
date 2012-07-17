namespace DangerWillRobinson
{
	using System.Configuration;

	using FluentEmail;

	public class Emailer
	{
		#region Constants and Fields

		private readonly string failCount;

		private readonly string serviceName;

		#endregion

		#region Constructors and Destructors

		public Emailer(string serviceName, string failCount)
		{
			this.serviceName = serviceName;
			this.failCount = failCount;
		}

		#endregion

		#region Public Methods and Operators

		public void FlapArmsWildly()
		{
			string from = ConfigurationManager.AppSettings["from"];
			string to = ConfigurationManager.AppSettings["notificationList"];

			Email email = Email.From(from)
				.To(to).Subject(string.Format("{0} failure", this.serviceName))
				.Body(string.Format("{0} failed to restart. FailCount: {1}", this.serviceName, this.failCount), false);

			email.Send();
		}

		#endregion
	}
}