//Demo on using string in switch statement

    using System;

    class SwitchTest
    {
        public static void Main()
        {
            string myInput;
            
            Console.Write("Enter country : ");
            myInput = Console.ReadLine();

            // switch with string type
          switch (myInput)
            {
                case "india":
                    Console.WriteLine("Capital : NewDelhi");
	break;
                case "america":
                    Console.WriteLine("Capital : Washington DC");
                    break;
                case "england":
                    Console.WriteLine("Capital : London");
                    break;
                default:
       Console.WriteLine("Sorry no information available for {0}", myInput);
	break;
          }
      
}
}