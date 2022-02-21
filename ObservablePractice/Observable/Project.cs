namespace ObservablePractice
{
	public class Project : AObservable<ProjectState>
	{
		public Project() : base()
		{
			Console.WriteLine("Project created");
		}

		public Project(ProjectState state) : base(state)
		{
			Console.WriteLine($"Project {state.Name} created");
		}

		protected override void Announce()
		{
			Console.WriteLine("State of project changed");
			base.Announce();
			Console.WriteLine("Notified " + Observers.Count + " experts");
		}
	}
}
