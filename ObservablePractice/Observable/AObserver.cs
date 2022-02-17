using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePractice
{
	public abstract class AObserver<T>
	{
		protected AObservable<T> _observable;

		public AObserver(AObservable<T> observable)
		{
			_observable = observable;
			_observable.Attach(this);
		}

		public T State { get; set; }
		public abstract void Notify();
	}
}
