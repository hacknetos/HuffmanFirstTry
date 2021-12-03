using System;
using System.Collections.Generic;
using System.Linq;

namespace HoffmanFirstTry
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            List<Node?> nodes = new List<Node?>();
            
            var input = Console.ReadLine();
            if (input == null) return;
            
            foreach (var c in input)
            {
                var success = false;

                foreach (var item in nodes.Where(item => item!.letter == c))
                {
                    item!.value++;
                    success = true;
                    break;
                }

                if (!success)
                    nodes.Add(new Node(c, 1));
            }
            
            nodes = QuikSort.Sort(nodes);

            foreach (var item in nodes)
                Console.WriteLine(item!.letter + " " + item.value);

            while (nodes.Count > 2)
            {
                var one = nodes[0];
                var two = nodes[1];
                var checkpointCharlie = new Node(one!.value + two!.value);

                if (one.value > two.value)
                {
                    checkpointCharlie.left = one;
                    checkpointCharlie.right = two;
                }
                else
                {
                    checkpointCharlie.right = one;
                    checkpointCharlie.left = two;
                }

                nodes.Remove(one);
                nodes.Remove(two);
                nodes.Add(checkpointCharlie);
                nodes = QuikSort.Sort(nodes);
            }

            NodeTree yggdrasil = new NodeTree(nodes[0], nodes[1]);
            if (yggdrasil.Origin == null) return;
            {
                Console.WriteLine("\n" + yggdrasil.Origin.value + "\n");

                foreach (var item in input)
                    Console.WriteLine(NodeTree.Encrypt(item, "", yggdrasil.Origin));
            }
        }
    }
}