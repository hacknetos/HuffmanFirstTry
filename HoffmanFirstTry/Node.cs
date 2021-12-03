namespace HoffmanFirstTry
{
    public class Node
    {
        public int value;
        public readonly char letter = '\0';
        public Node? left;
        public Node? right;

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
