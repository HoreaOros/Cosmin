using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lee
{
    struct Point
    {
        public int Col;
        public int Line;

        public Point(int startLine, int startCol) : this()
        {
            this.Line = startLine;
            this.Col = startCol;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int linii, coloane;
            string line;
            string[] tokens;
            char[] seps = {' ', '\n'};
            int[,] maze;
            int startLine, startCol, targetLine, targetCol;
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                line = sr.ReadLine();
                tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);
                linii = int.Parse(tokens[0]);
                coloane = int.Parse(tokens[1]);

                maze = new int[linii, coloane];
                for (int i = 0; i < linii; i++)
                {
                    line = sr.ReadLine();
                    tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < coloane; j++)
                    {
                        maze[i, j] = int.Parse(tokens[j]);
                    }
                }
                line = sr.ReadLine();
                tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);
                startLine = int.Parse(tokens[0]);
                startCol = int.Parse(tokens[1]);

                line = sr.ReadLine();
                tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);
                targetLine = int.Parse(tokens[0]);
                targetCol = int.Parse(tokens[1]);
            }
            AfisareMatrice(maze);
            Queue<Point> q = new Queue<Point>();

            q.Enqueue(new Point(startLine, startCol));
            maze[startLine, startCol] = 2;
            Point p;
            bool gasit = false;
            do
            {
                p = q.Dequeue();
                if (p.Line > 0 && maze[p.Line - 1, p.Col] == 0)
                {
                    maze[p.Line - 1, p.Col] = maze[p.Line, p.Col] + 1;
                    if (p.Line - 1 == targetLine && p.Col == targetCol)
                    {
                        gasit = true;
                        break;
                    }
                    q.Enqueue(new Point(p.Line - 1, p.Col));
                }
                if (p.Line < linii - 1 && maze[p.Line + 1, p.Col] == 0)
                {
                    maze[p.Line + 1, p.Col] = maze[p.Line, p.Col] + 1;
                    if (p.Line + 1 == targetLine && p.Col == targetCol)
                    {
                        gasit = true;
                        break;
                    }
                    q.Enqueue(new Point(p.Line + 1, p.Col));
                }
                if (p.Col > 0 && maze[p.Line, p.Col - 1] == 0)
                {
                    maze[p.Line, p.Col - 1] = maze[p.Line, p.Col] + 1;
                    if (p.Line == targetLine && p.Col - 1 == targetCol)
                    {
                        gasit = true;
                        break;
                    }
                    q.Enqueue(new Point(p.Line, p.Col - 1));
                }
                if (p.Col < coloane - 1 && maze[p.Line, p.Col + 1] == 0)
                {
                    maze[p.Line, p.Col + 1] = maze[p.Line, p.Col] + 1;
                    if (p.Line == targetLine && p.Col + 1 == targetCol)
                    {
                        gasit = true;
                        break;
                    }
                    q.Enqueue(new Point(p.Line, p.Col + 1));
                }
            } while (q.Count > 0);
            if (gasit)
            {
                AfisareMatrice(maze);
                Stack<Point> st = new Stack<Point>();

                p = new Point(targetLine, targetCol);
                st.Push(p);
                while (p.Line != startLine || p.Col != startCol)
                {
                    // cautam un vecin al lui p care este marcat cu o valoare cu 1 mai mica decat valoarrea cu care este marcat p
                    // punctul gasit se adauga in stiva 
                }

                // clearance = stergerea marcajelor facute in plus. 
            }
            else
                Console.WriteLine("target unreachable");
        }

        private static void AfisareMatrice(int[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    Console.Write("{0,3}", maze[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
