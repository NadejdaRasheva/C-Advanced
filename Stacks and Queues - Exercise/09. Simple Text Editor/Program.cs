using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string text = String.Empty;
            Stack<string> changes = new Stack<string> ();

            for (int i = 0; i < n; i++)
            {
                string[] commInfo = Console.ReadLine().Split();

                int comm = int.Parse(commInfo[0]);
                switch (comm)
                {
                    case 1:
                        changes.Push(text);
                        string addition = commInfo[1];
                        text += addition;
                        break;
                    case 2:
                        changes.Push(text);
                        int count = int.Parse(commInfo[1]);
                        text = text.Remove(text.Length - count);
                        break;
                    case 3:
                        int index = int.Parse(commInfo[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case 4:
                        text = changes.Pop();
                        break;
                }
            }
        }
    }
}
