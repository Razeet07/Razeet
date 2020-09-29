using System;//class wrap garxa namespace le
class  SelectionStatement
{
    public void LearnIfElse()
    {
        //byte age = 78;//&&conditional,logica//&->bitwise//ctrlkc/ctrl uc
        Console.WriteLine("Enter your age:");
        string ageString = Console.ReadLine();
        byte age = byte.Parse(ageString);
        if (age > 60 && age < 80)
        {
            Console.WriteLine("You are eligible for pension");
        }
        else if(age > 50)
        {
            Console.WriteLine("You are about to eligible for pension.");
        }
        else
        {
            Console.WriteLine("You are not eligible for pension.");
            
        }
    }
        public void LearnSwitchCases()
        {
            Console.Write("Enter your hobby:");
            string hobby = Console.ReadLine();
            switch (hobby)
            {
                case "books":
                Console.WriteLine("You are very good at comedian");
                break;
                case "badminton":
                Console.WriteLine("You are very good at badminton");
                break;
                case "swimming":
                Console.WriteLine("Good for your health");
                break;
                case "driving":
                Console.WriteLine("That's goof but be careful");
                break; 
                default:
                Console.WriteLine("That's intersting");
                break;
            }
        }    
}