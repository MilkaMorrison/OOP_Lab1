using lab1_3;

Tree root = new Tree(0);

Tree child1 = new Tree(1);
Tree child2 = new Tree(2);
Tree grandchild1 = new Tree(3);
Tree grandchild2 = new Tree(4);

root.AddChild(child1);
root.AddChild(child2);
child1.AddChild(grandchild1);
child1.AddChild(grandchild2);

Console.WriteLine("Дерево:");
root.PrintChildren();