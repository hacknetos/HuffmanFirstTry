namespace HoffmanFirstTry;
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
                nodes.Add(new NodeChar(c, 1));

        }
        
        nodes = QuikSort.Sort(nodes);

        foreach (var item in nodes)
            Console.WriteLine(item.letter + " " + item.value);

        while (nodes.Count>2)
        {
            Node one, two;
            one =nodes[0];
            two =nodes[1];
            NodeValue checkpointCharlie = new NodeValue(one.value+two.value);

            if (one.value>two.value)
            {
                checkpointCharlie.left = one;
                checkpointCharlie.right = two;
            }
            else
            {
                checkpointCharlie.right=one;
                checkpointCharlie.left=two;
            }

            nodes.RemoveAt(0);
            nodes.RemoveAt(1);
            nodes.Add(checkpointCharlie);
            nodes = QuikSort.Sort(nodes);
        }
        NodeTree yggdrasil = new NodeTree(nodes[0],nodes[1]);
        
        foreach (var item in input)
        {
            Console.WriteLine(yggdrasil.encrypt(item, "", yggdrasil.origin));
        }
    }
}
