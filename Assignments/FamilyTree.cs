using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class FamilyTree
    {
        public FamilyMember Root { get; set; }

        public FamilyTree(FamilyMember root)
        {
            Root = root;
        }

        public void AddFamilyMember(FamilyMember parent, FamilyMember child)
        {
            if (parent != null)
            {
                parent.Children.Add(child);
            }
            else
            {
                Root = child;
            }
        }

        public static void DisplayFamilyTree(FamilyMember member, string indent = "")
        {
            if (member != null)
            {
                Console.WriteLine($"{indent}{member.Name} (Age: {member.Age})");

                foreach (var child in member.Children)
                {
                    DisplayFamilyTree(child, indent + "  ");
                }
            }
        }
    }
}
