namespace HoffmanFirstTry
{
    public class Node
    {
        public int value;
        public char letter = '\0';
        public Node left, right;

        public Node(char letter, int value)
        {
            this.value = value;
            this.letter = letter;
        }

        public Node(int value)
        {
            this.value = value;
        }
        public Node() { }

    }
}
