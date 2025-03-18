using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3
{
    class Tree
    {
        int value;  // значение узла
        List<Tree> children;    //список потомков
        int level;

        public Tree(int val)
        {
            value = val;
            children = new List<Tree>();
        }
        public void AddChild(Tree child)
        {
            children.Add(child);
            child.level = level + 1;
        }
        public void PrintChildren()
        {
            var indent = new string(' ', level * 2);
            Console.WriteLine($"{indent}- level: {level}, value: {value}");
            for (int i = 0; i < children.Count; i++)
            {
                Tree child = children[i];
                child.PrintChildren();
            }
        }
    }
}
