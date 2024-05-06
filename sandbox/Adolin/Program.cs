namespace Adolin;


    
    /*
    Class 3 notes:
    Python vs C#            int x = 0;
    if  x==0:               if (x==0){ 
        print("tmit")           Console.WriteLine("tmit");
                            } 
    loops
    while x <3:             while (x<3){
        print("tmit")           Console.WriteLine("tmit");
        x+=1                    x+=1; or x++;
        x-=1                    x-=1; or x--;
        x*=1                    x*=1; or x=x*1;
        x/=1                    x/=1; or x=x/1;
        x%=1                    x%=1; or x=x%1;
                            }
                            or
                            do{
                                Console.WriteLine("tmit");
                                x+=1;
                            }while (x<3);

                                initialize; test; increment
    for x in range(3):      for (int x=0; x<3; x++){
        print("tmit")           Console.WriteLine("tmit");
                            } (or)
                            foreach (int x in new int[]{0,1,2}){
                                Console.WriteLine("tmit");
                            }
    
    Class 4 notes:
    blur_pull = []          List<int> blur_pull = new(); or List<int> blur_pull = new List<int>();
    blur_pull.append(42)    blur_pull.Add(42);
                            

    Class 5 notes 5/6/24:
    UML - Unified Modeling Language
    ------------------------------
    | Name Course                |
    ------------------------------
    | Course Code                |
    | Class name                 |
    | NumberOfCredits            |
    | Color                      |
    ------------------------------
    | Behaviors - methods        |
    | display                    |
    ------------------------------
   */

class Program
{
    static void Main(string[] args)
    {   
        Course course = new Course();
        course._className = "Programming with Classes";
        course._color = "green";
        course._courseCode = "CSE 210";
        course._numberOfCredits = 2;
        course.Display();
    }           
}
