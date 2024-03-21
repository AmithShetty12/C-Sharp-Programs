using System;

class p8{
    public static void Main(string[] args){
        char choice;
        Console.WriteLine("Enter the MAX Stack limit");
        int size= Convert.ToInt32(Console.ReadLine());
        Stack stack = new Stack(size);
        try{
          do{    
            Console.WriteLine("1.Push\n2.Pop\n3.Exit");
            int op = Convert.ToInt32(Console.ReadLine());
            switch(op){
            case 1:{
                Console.WriteLine("Enter the Elements to Push");
                int data = Convert.ToInt32(Console.ReadLine());
                stack.Push(data);
                break;
            }
            case 2:{
                stack.Pop();
                break;
            }
            case 3:{
                Environment.Exit(0);
                break;
            }
            default:
                Console.WriteLine("Wrong Option!");
                break;               
        }
        Console.WriteLine("Click y to continue or Click any key to exit...");
        choice = Convert.ToChar(Console.ReadLine());
        }while(choice == 'y' || choice == 'Y');
        }
        catch(Exception){
            Environment.Exit(0);
        }
        
    }
}

class Stack{
    private int[] StackArray;
    private int top;
    private int maxSize;
    public Stack(int size){
        maxSize = size;
        StackArray = new int[maxSize];
        top = -1;
    }
    public bool IsEmpty(){
        return(top == -1);
    }
    public bool IsFull(){
        return(top == maxSize-1);
    }
    public void Push(int value){
        if(IsFull()){
            Console.WriteLine("Stack Overflow! Cannot Push!");
        }
        else{
            StackArray[++top] = value;
            Console.WriteLine("The Element "+value+" is Pushed...");
        }

    }
    public void Pop(){
        if(IsEmpty()){
            Console.WriteLine("Stack Underflow! Cannot Pop!");
        }
        else{
            int var = StackArray[top--];
            Console.WriteLine("The top element "+var+" is Popped...");
        }

    }
}
