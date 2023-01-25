using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ReizTechTasks
{
 class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.FindAngle();
            //p.FindDepth();
        }

        #region FindAngle
        //public void FindAngle()
        //{
        //    int hours, minutes, angle;

        //    Console.WriteLine("Enter the number between 0-12 that stands for hours:");
        //    hours = Convert.ToInt32(Console.ReadLine());

        //    if (hours > 12 || hours < 0)
        //    {
        //        Console.WriteLine("Hours is not in correct format!");
        //        return;
        //    }


        //    Console.WriteLine("Enter the number between 0-60 that stands for minutes:");
        //    minutes = Convert.ToInt32(Console.ReadLine());

        //    if (minutes > 59 || minutes < 0)
        //    {
        //        Console.WriteLine("Minutes is not in correct format!");
        //        return;
        //    }

        //    angle = (int)Math.Abs(5 * ((6 * hours) - (1.1 * minutes)));

        //    Console.WriteLine("Angle between hours and minutes arrow equals: {0}", angle);
        //}
        #endregion

        #region FindDepth
        //public void FindDepth()
        //{
        //    Branch main = new();
        //    Branch branch11 = new();
        //    Branch branch12 = new();

        //    Branch branch21 = new();
        //    Branch branch22 = new();
        //    Branch branch23 = new();
        //    Branch branch24 = new();

        //    Branch branch31 = new();
        //    Branch branch32 = new();
        //    Branch branch33 = new();

        //    Branch branch41 = new();
        //    main.Branches = new List<Branch> { branch11, branch12 };
        //    branch11.Branches = new List<Branch> { branch21 };
        //    branch12.Branches = new List<Branch> { branch22, branch23, branch24 };

        //    branch22.Branches = new List<Branch> { branch31 };
        //    branch23.Branches = new List<Branch> { branch32, branch33 };

        //    branch32.Branches = new List<Branch> { branch41 };


        //    int depth = FindDepth(main, 1);
        //    Console.WriteLine("The depth of provided structure equals: {0}",depth);
        //}

        //public int FindDepth(Branch n, int depth)
        //{
        //    if (n == null || n.Branches == null)
        //    {
        //        return depth;
        //    }

        //    int maxDepth = 0;
        //    for (int i = 0; i < n.Branches.Count; i++)
        //    {
        //        int d = FindDepth(n.Branches[i], depth + 1);
        //        if (d > maxDepth)
        //        {
        //            maxDepth = d;
        //        }
        //    }

        //    return maxDepth;
        //}
        #endregion
    }

    class Branch
    {
        public List<Branch>? Branches;
    }

}




