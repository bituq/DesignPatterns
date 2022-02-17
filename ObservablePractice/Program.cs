using ObservablePractice;

Project[] projects = new Project[4];
List<Expert> experts = new List<Expert>();

for (int i = 0; i < projects.Length; i++)
	projects[i] = new Project(Convert.ToChar(65 + i % 26).ToString());

foreach (Project project in projects)
{
	for (int i = 0; i < new Random().Next(4); i++)
		experts.Add(new(project));
}

projects[0].State = Convert.ToChar(65 + new Random().Next(26)).ToString();