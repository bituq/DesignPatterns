using ObservablePractice;

Project p1 = new Project("Project A");
Project p2 = new Project("Project B");

Expert e1 = new Expert(p1);
Expert e2 = new Expert(p1);
Expert e3 = new Expert(p2);

p1.State = "Project C";
p1.State = "Project D";
p2.State = "Project E";