using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePractice
{
	public interface IObservable<T>
	{
		public LinkedList<AObserver<T>> Observers { get; set; }
		public T State { get; set; }
		public void Attach(AObserver<T> observer);
		public void Detach(AObserver<T> observer);
		public void Announce();
	}
}
