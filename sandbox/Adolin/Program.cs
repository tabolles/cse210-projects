namespace Adolin;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
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
    
                            
    */