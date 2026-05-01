using System.Reflection;

Assembly? myApp = Assembly.GetEntryAssembly();

if (myApp is null) return;

foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);
    // Declare a variable to count the number of methods.
    int methodCount = 0;
    // Loop through all the types in the assembly.
    foreach (TypeInfo t in a.DefinedTypes)
    {
    // Add up the counts of all the methods.
    methodCount += t.GetMethods().Length;
    }
    // Output the count of types and their methods.
    Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
    arg0: a.DefinedTypes.Count(),
    arg1: methodCount,
    arg2: name.Name);
}