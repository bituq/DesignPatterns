using ObservablePractice;

Project p1 = new Project(1);
Project p2 = new Project(2);

Expert e1 = new Expert(p1);
Expert e2 = new Expert(p1);
Expert e3 = new Expert(p2);

p1.State = 5;
p1.State = 2;
p2.State = 3;