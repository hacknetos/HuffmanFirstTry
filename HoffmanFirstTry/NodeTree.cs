namespace HoffmanFirstTry
{
    public class NodeTree
    {
        public Node origin;

        public NodeTree(Node left, Node right)
        {
            origin = new Node();
            if (left.value < right.value)
            {

                origin.left = left;
                origin.right = right;
            }
            else
            {
                origin.right = left;
                origin.left = right;
            }
        }
        //such den Tree nach dem Buch staben anhand der gegeben zahlen 
        public char search(string code)
        {
            Node node = origin;
            foreach (char direction in code)
            {
                if (direction == '0')
                    node = node.left;
                else
                    node = node.right;
            }
            return node.letter;
        }
        public string encrypt(char letter, string code, Node node)
        {
            if (node.letter == letter)
                return code;
            else
            {
                string tmp = "";
                if (node.right != null)
                {
                    tmp = encrypt(letter, code + '1', node.right);
                    if (tmp != code)
                    {
                        return tmp;
                    }

                }
                if (node.left != null)
                {
                    tmp = encrypt(letter, code + '0', node.left);
                    if (tmp != code)
                    {
                        return tmp;
                    }
                }
                return code = code.Remove(code.Length - 1, 1);
            }





        }
    }
}
