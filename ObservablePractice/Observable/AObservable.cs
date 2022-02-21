using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePractice
{
	public abstract class AObservable<T>
	{
		private T _state;
		private List<AObserver<T>> _observers { get; set; } = new List<AObserver<T>>();

		public AObservable()
		{
		}

		public AObservable(T state)
		{
			_state = state;
		}

		protected IReadOnlyList<AObserver<T>> Observers => _observers;
		public T State
		{
			get => _state;
			set
			{
				_state = value;
				Announce();
			}
		}
		public virtual void Attach(AObserver<T> observer) => _observers.Add(observer);
		public virtual void Detach(AObserver<T> observer) => _observers.Remove(observer);
		protected virtual void Announce() => _observers.ForEach(o => o.Notify());
	}
}