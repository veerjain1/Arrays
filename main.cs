using System;

class Program {
  public static void Main (string[] args) {
    string[] sentence = new string[5];
    string h = "had", m = "mary", a = "a", l = "cow", i = "little";
   string[] sentence2 = new string[6];

// Fill in the strings and indices that go in each array location to create the sentence 
// "mary had a little lamb"

// sentence = { "mary"    , “had” , “a” , “little” , “lamb” }

// index    =      0        , 1 ,    2 ,      3 ,       4

// Now fill in the appropriate assignment of string variables h,m,a, l, i.

  sentence[0] = m;

  sentence[1] = h;

  sentence[2] = a;

  sentence[3] = i;

  sentence[4] = l;

    
  sentence2[0] = "its";

  sentence2[1] = "fleece";

  sentence2[2] = "was";

  sentence2[3] = "white";

  sentence2[4] = "as";
  sentence2[5] = "snow";

    

// Create the following output:
// mary 
// little
// had
// a
// lamb
// by using the sentence array, not the individual string variables
for(int x = 0; x<10; x++){
  Console.WriteLine( sentence[0]+ " ");

  Console.Write( sentence[1]+ " ");

  Console.Write( sentence[2] +" ");

  Console.Write( sentence[3]+" " );

  Console.Write( sentence[4] +" ");
    
  Console.Write( sentence[3]+" " );

  Console.Write( sentence[4]+" " );
  Console.Write( sentence[3] +" ");

  Console.Write( sentence[4] +" ");
  Console.WriteLine( sentence[0] +" ");

  Console.Write( sentence[1] +" ");

  Console.Write( sentence[2] +" ");

  Console.Write( sentence[3]+" " );

  Console.Write( sentence[4] +" ");

  Console.WriteLine( sentence2[0]+ " ");

  Console.Write( sentence2[1]+" " );

  Console.Write( sentence2[2] +" ");

  Console.Write( sentence2[3]+" " );

  Console.Write( sentence2[4] +" ");
  Console.Write(sentence2[5]+" ");
}
    

    

  }
}