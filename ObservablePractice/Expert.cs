using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ObservablePractice
{
	public class Expert : AObserver<int>
	{
		public Expert(IObservable<int> observable) : base(observable)
		{
			Console.WriteLine($"Expert {GetHashCode()} created.");
		}

		public override void Notify()
		{
			State = _observable.State;
			Console.WriteLine($"Expert {GetHashCode()} got notified.");
		}
	}
}
