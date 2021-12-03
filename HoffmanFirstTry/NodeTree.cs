using System.Runtime.InteropServices;

namespace HoffmanFirstTry
{
    public class NodeTree
    {
        public readonly Node? Origin;

        public NodeTree(Node? left, Node? right)
        {
            Origin = new Node();
            if (left!.value < right!.value)
            {

                Origin.left = left;
                Origin.right = right;
            }
            else
            {
                Origin.right = left;
                Origin.left = right;
            }
        }
        
        //such den Tree nach dem Buchstaben anhand der gegeben zahlen 
        public static char search(string code, Node? node)
        {
            foreach (var direction in code)
            {
                if (direction == '0')
                    node = node!.left;
                else
                    node = node!.right;
            }
            return node!.letter;
        }
        
        public static string Encrypt(char letter, string code, Node? node)
        {
            if (node!.letter == letter)
                return code;
            else
            {
                string tmp;
                
                if (node.right != null)
                {
                    tmp = Encrypt(letter, code + '1', node.right);
                    if (tmp != code)
                    {
                        return tmp;
                    }

                }
                // ReSharper disable once InvertIf
                if (node.left != null)
                {
                    tmp = Encrypt(letter, code + '0', node.left);
                    if (tmp != code)
                    {
                        return tmp;
                    }
                }
                
                return code.Remove(code.Length - 1, 1);
            }
        }
    }
}
