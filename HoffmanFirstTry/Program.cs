//using System.Collections.Generic;
//using HoffmanFirstTry;

using System;
using System.Collections.Generic;

namespace HoffmanFirstTry
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Node> nodes = new List<Node>();
            string input = Console.ReadLine();

            foreach (char c in input)
            {
                bool success = false;

                foreach (Node item in nodes)
                    if (item.letter == c)
                    {
                        item.value++;
                        success = true;
                        break;
                    }

                if (!success)
                    nodes.Add(new Node(c, 1)); //hallo

            }


            nodes = QuikSort.Sort(nodes);

            foreach (var item in nodes)
                Console.WriteLine(item.letter + " " + item.value);

            while (nodes.Count > 2)
            {
                Node one, two;
                one = nodes[0];
                two = nodes[1];
                Node checkpointCharlie = new Node(one.value + two.value);

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
            Console.WriteLine("\n" + yggdrasil.origin.value + "\n");
            foreach (var item in input)
            {
                Console.WriteLine(yggdrasil.encrypt(item, "", yggdrasil.origin));
            }
        }
    }
}