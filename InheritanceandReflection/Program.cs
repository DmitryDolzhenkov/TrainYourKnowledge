using System;
using System.Reflection;

namespace InheritanceandReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpeClassExample();

            Console.ReadKey();
        }

        private static void SimpeClassExample()
        {
            MemberInfo[] members = GetMembersInfoFromClass(typeof(SimpleClass));

            PrintMembersInfo(members);
            //Type SimpleClass has 9 members:
            //GetType (Method):  Public, Declared by System.Object
            //MemberwiseClone (Method):  Protected, Declared by System.Object
            //Finalize (Method):  Protected, Declared by System.Object
            //ToString (Method):  Public, Declared by System.Object
            //Equals (Method):  Public, Declared by System.Object
            //Equals (Method):  Public Static, Declared by System.Object
            //ReferenceEquals (Method):  Public Static, Declared by System.Object
            //GetHashCode (Method):  Public, Declared by System.Object
            //.ctor (Constructor):  Public, Declared by InheritanceandReflection.SimpleClass
            
        }

        private static void PrintMembersInfo(MemberInfo[] members)
        {
            foreach (var member in members)
            {
                string access = "";
                string stat = "";
                var method = member as MethodBase;
                if (method != null)
                {
                    if (method.IsPublic)
                        access = " Public";
                    else if (method.IsPrivate)
                        access = " Private";
                    else if (method.IsFamily)
                        access = " Protected";
                    else if (method.IsAssembly)
                        access = " Internal";
                    else if (method.IsFamilyOrAssembly)
                        access = " Protected Internal ";
                    if (method.IsStatic)
                        stat = " Static";
                }
                var output = $"{member.Name} ({member.MemberType}): {access}{stat}, Declared by {member.DeclaringType}";
                Console.WriteLine(output);
            }
        }

        private static MemberInfo[] GetMembersInfoFromClass(object simpleClass)
        {
            throw new NotImplementedException();
        }
        private static MemberInfo[] GetMembersInfoFromClass(Type clazz)
        {
            //object theobject = Activator.CreateInstance(clazz);
            //Type t = typeof(theobject);
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public |
                             BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
            MemberInfo[] members = clazz.GetMembers(flags);
            Console.WriteLine($"Type {clazz.Name} has {members.Length} members: ");
            return members;
        }
    }
}
