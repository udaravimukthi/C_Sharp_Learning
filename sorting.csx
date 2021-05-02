// sort int array
int[] intArray = new int[5] { 8, 10, 2, 6, 3 };
Array.Sort(intArray);
// write array
foreach (int i in intArray) Console.Write(i + " ");  // output: 2 3 6 8 10

// sort string array
string[] stringArray = new string[5] { "X", "B", "Z", "Y", "A" };
Array.Sort(stringArray);
// write array
foreach (string str in stringArray) Console.Write(str + " "); // output: A B X Y Z