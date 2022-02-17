namespace ObservablePractice
{
	public class Project : AObservable<string>
	{
		public Project() : base()
		{
			Console.WriteLine("Project created");
		}

		public Project(string state) : base(state)
		{
			Console.WriteLine($"Project {state} created");
		}

		protected override void Announce()
		{
			Console.WriteLine("State of project changed to " + State);
			base.Announce();
			Console.WriteLine("Notified " + Observers.Count + " experts");
		}
	}
}
