namespace BSTassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.InserData(56);
            tree.InserData(30);
            tree.InserData(70);

            Console.WriteLine("pre-transversal : root-left-right ");
            tree.Display(tree.ReturnRoot());
            Console.WriteLine("post-transversal : left-right-root");
            tree.Post(tree.ReturnRoot());
            Console.WriteLine("in order : left-right-root");
            tree.Inorder(tree.ReturnRoot());
        }
    }
}