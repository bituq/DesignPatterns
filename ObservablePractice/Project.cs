namespace ObservablePractice
{
	public class Project : IObservable<int>
	{
		private int _state;

		public Project()
		{
		}

		public Project(int state)
		{
			_state = state;
		}

		public LinkedList<AObserver<int>> Observers { get; set; } = new LinkedList<AObserver<int>>();
		public int State
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
			Console.WriteLine("State of project changed");
			foreach (AObserver<int> observer in Observers)
				observer.Notify();
			Console.WriteLine("Notified " + Observers.Count + " experts");
		}

		public void Attach(AObserver<int> observer) => Observers.AddLast(observer);

		public void Detach(AObserver<int> observer) => Observers.Remove(observer);
	}
}
