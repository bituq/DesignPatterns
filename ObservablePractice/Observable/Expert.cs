using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ObservablePractice
{
	public class Expert : AObserver<ProjectState>
	{
		public Expert(Project project) : base(project)
		{
			Console.WriteLine($"Expert {GetHashCode()} created and added to project {project.State.Name}");
		}

		public override void Notify()
		{
			State = _observable.State;
			Console.WriteLine($"Expert {GetHashCode()} got notified");
		}
	}
}
