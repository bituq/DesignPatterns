namespace ObservablePractice
{
	public class Project : IObservable<string>
	{
		private string _state;

		public Project()
		{
		}

		public Project(string state)
		{
			_state = state;
		}

		public LinkedList<AObserver<string>> Observers { get; set; } = new LinkedList<AObserver<string>>();
		public string State
		{
			get => _state;
			set
			{
				_state = value;
				Announce();
			}
		}

		public void Announce()
		{
			Console.WriteLine("State of project changed to " + State);
			foreach (AObserver<string> observer in Observers)
				observer.Notify();
			Console.WriteLine("Notified " + Observers.Count + " experts");
		}

		public void Attach(AObserver<string> observer) => Observers.AddLast(observer);

		public void Detach(AObserver<string> observer) => Observers.Remove(observer);
	}
}
