/*See https://aka.ms/new-console-template for more information
using Basic_Programs;
using Basic_Programs.ExceptionMessages;

int num1, num2, ans;
Console.WriteLine("Let us add two numbers");
Console.WriteLine("Enter a number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter another number: ");
num2 = Convert.ToInt32(Console.ReadLine());
ans = num1 + num2;
Console.WriteLine("The sum is " + ans);

Console.WriteLine("Let us concatenate two strings");
string? s1, s2, s3;
Console.WriteLine("Enter a string: ");
s1 = Console.ReadLine();
Console.WriteLine("Enter another string: ");
s2 = Console.ReadLine();
s3 = s1 + " " + s2;
string[] s4 = s3.Split(' ');
Console.WriteLine("Here it is: " + s3);
Console.WriteLine(s3.Substring(3));
for (int i = 0; i < s4.Length; i++)
{
    Console.WriteLine(s4[i]);
}

using Basic_Programs;

Calculation calculation = new Calculation();
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
double sum=calculation.Add(num1,num2);
Console.WriteLine(sum);

//18-10-2023
using Basic_Programs;

int consumernumber = Convert.ToInt32(Console.ReadLine());
Electricity electricity1 = new(consumernumber, 5000, 5500, "Old");
Console.WriteLine(electricity1.consumername + "-" + electricity1.consumernumber + "-" + electricity1.CalculateBill());

Electricity electricity2 = new(2345, 4400, 5200, "New");
Console.WriteLine(electricity2.consumername + "-" + electricity1.consumernumber + "-" + electricity2.CalculateBill());

19 - 10 - 2023
using Basic_Programs;

Employee employee = new(123, "Deepak", "IT", 10000);
Console.WriteLine("Employee ID: {0}\nName: {1}\nDepartment: {2}\nBasic Pay: {3}\nSalary: {4}", employee.Eid, employee.Ename, employee.Dept, employee.Basicpay, employee.CalculateSalary());

ArrayExample arrayExample = new ArrayExample();
arrayExample.OneDim();
arrayExample.TwoDim();
arrayExample.JaggedArray();

20 - 10 - 2023

StudentMarks marks = new()/*new(1000, "AAA", "TRV", 98, 89, 95, 0, 0);
marks.RollNo = 1000;
marks.StudentName = "Deepak";
marks.City = "TVM";
marks.Mark1 = 1;
marks.Mark2 = 2;
marks.Mark3 = 3;
marks.DisplayStudentDetails();
Console.WriteLine("Total marks: " + marks.CalculateTotal());
Console.WriteLine("Average: " + marks.CalculateAverage());

StudentGrade studentGrade = new()
{
    RollNo = 1000,
    StudentName = "AAA",
    City = "TRV",
    Mark1 = 67,
    Mark2 = 78,
    Mark3 = 88
};
studentGrade.CalculateGrade();

Console.WriteLine("1.TS  2.NTS");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff ts = new();
        Console.Write("StaffId: ");
        ts.StaffId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Name: ");
        ts.StaffName = Console.ReadLine();
        Console.Write("Specializations: ");
        ts.Specializations = Console.ReadLine();
        Console.Write("Semester: ");
        ts.Sem = Convert.ToInt32(Console.ReadLine());
        ts.DisplayStaffDetails();
        break;
    case 2:
        NonTeachingStaff nts = new();
        Console.Write("StaffId: ");
        nts.StaffId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Name: ");
        nts.StaffName = Console.ReadLine();
        Console.Write("Responsibilities: ");
        nts.Responsibilities = Console.ReadLine();
        Console.Write("Experience: ");
        nts.Experience = Convert.ToInt32(Console.ReadLine());
        nts.DisplayNTStaffDetails();
        break;

}

EV ev = new()
{
    VehNum = 123,
    Brand = "ABC",
    Model = "bv12",
    Type = "4 wheeler"
};
ev.Disp();
Console.WriteLine(ev.setTypeForVeh());
PV pv = new()
{
    VehNum = 456,
    Brand = "XYZ",
    Model = "ab123",
    Type = "2 wheeler"
};
Console.WriteLine(pv.setTypeForVeh());
pv.Disp();

21 - 10 - 2023

Doctor doctor = new();
doctor.AddNewDoctor(1234, "ABC");
doctor.DisplayDoctorDetails();
doctor.ModifyDoctor(6789, "XYZ");
doctor.DisplayDoctorDetails();

doctor.BookApp(123, "new");
doctor.DelApp("new");


23 - 10 - 2023
Polymorphism - overloading
BankDetails details = new(123, 987654321L, "Deepak", "Active");
BankDetails details1 = new();
BankDetails details2 = new(456, 123456789L, "New");
BankDetailsNew newdetails = new(321, 567889997L, "BankDetailsNew", "Active");
details.WelcomeMessage();
newdetails.WelcomeMessage();//overriding
Console.WriteLine("1.Customer ID  2.Account No  3.Name");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Customer ID: ");
        details.GetAccountDetails(Convert.ToInt32(Console.ReadLine()));
        details1.GetAccountDetails(Convert.ToInt32(Console.ReadLine()));
        newdetails.GetAccountDetails(Convert.ToInt32(Console.ReadLine()));

        break;
    case 2:
        Console.WriteLine("Account No: ");
        details.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));
        details1.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));
        details2.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));

        break;
    case 3:
        Console.WriteLine("Name: ");
        details.GetAccountDetails(Console.ReadLine());
        details1.GetAccountDetails(Console.ReadLine());
        details2.GetAccountDetails(Console.ReadLine());

        break;
    default:
        Console.WriteLine("Enter between 1-3");
        break;
}

BankDetails.ExitMessage(); //static method
newdetails.ExitMessage();

25 - 10 - 2023

NGC nGC = new();
nGC.ArrayListHandling();
nGC.StackHandling();
Console.WriteLine("Queue");
nGC.QueueHandling();
Console.WriteLine("HashTable");
nGC.HashTableHandling();
Console.WriteLine("SortedList");
nGC.SortedListHandling();

Basic_Programs.GC gC = new();
gC.ListHandling();
gC.DictionaryHandling();

26 - 10 - 2023

ExceptionHandling handling = new(20, 104);
try
{
    handling.Divide();
}
catch (ArithmeticException ex)
{
    Console.WriteLine(MyExceptions.dmessagelist["Denominator"]);
    Console.WriteLine(MyExceptions.exmessagelist[0]);
    Console.WriteLine(ex.Message + " In " + ex.Source + ex.StackTrace);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(MyExceptions.dmessagelist["Range"]);
    Console.WriteLine(MyExceptions.exmessagelist[1]);
    Console.WriteLine(ex.Message + " In " + ex.Source + ex.StackTrace);
}
catch (Exception ex)
{
    Console.WriteLine(MyExceptions.dmessagelist["Unknown"]);
    Console.WriteLine(MyExceptions.exmessagelist[2]);
    Console.WriteLine(ex.Message + " In " + ex.Source + ex.StackTrace);
}
finally
{
    Console.WriteLine("Done");
}
try
{
    handling.NumCheck1();
}
catch (Number1Exception ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    handling.NumCheck2();
}
catch (Number2Exception ex)
{
    Console.WriteLine(ex.Message);
}

27 - 10 - 2023

FileOperations.CreateFile();
FileOperations.WriteData();
FileOperations.ReadData();
FileOperations.CopyMoveFile();
FileOperations.DeleteFile();
FileOperations.FileProperties();

30 - 10 - 2023

GenericsExample<int> g1 = new(10, 20);
Console.WriteLine(g1.Val1 + " " + g1.Val2);
GenericsExample<string> g2 = new("string1", "string2");
Console.WriteLine(g2.Val1 + " " + g2.Val2);
GenericsExample<double> g3 = new(10.02, 20.67);
Console.WriteLine(g3.Val1 + " " + g3.Val2);

GenericsExample<int> ga = new(new int[3] { 10, 20, 30 });
ga.Display();

int n1 = 10, n2 = 20;
char c1 = 'A', c2 = 'B';

GenericsExample<int>.Swap(ref n1, ref n2);
Console.WriteLine(n1 + " " + n2);
GenericsExample<char>.Swap(ref c1, ref c2);
Console.WriteLine(c1 + " " + c2);

31 - 10 - 2023

public delegate void Delegate1(string msg);//declare
public delegate void Delegate2(int num1, int num2);
public delegate int Delegate3(int num1, int num2);
class Program
{
    public static void DelegateCall()
    {
        Delegate1 delegate1 = DelegateExample.MethodA; //binding target
        delegate1("Hello");//Invoking delegate

        DelegateExample de = new();
        Delegate2 delegate2 = de.Add;
        Delegate2 delegate3 = de.Sub;
        delegate2(12, 34);//Single casting
        delegate3(34, 22);
        Delegate2 delegatecombined = delegate3 + delegate2;//multi-casting
        delegatecombined(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

        Delegate3 delegate4 = de.AddR;
        Console.WriteLine(delegate4(34, 22));
    }
    public static void Main(string[] args)
    {
        Delegate1 delegate1 = DelegateExample.MethodA;
        DelegateCall();


    }
}

03 - 11 - 2023

stack

using System;

class CustomStack<T>
{
    private T[] stackArray;
    private int top;
    private int maxSize;

    public CustomStack(int size)
    {
        maxSize = size;
        stackArray = new T[maxSize];
        top = -1;
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public bool IsFull()
    {
        return top == maxSize - 1;
    }

    public void Push(T item)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack is full. Cannot push.");
            return;
        }
        stackArray[++top] = item;
        Console.WriteLine($"Pushed: {item}");
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot pop.");
            return default(T);
        }
        T poppedItem = stackArray[top--];
        Console.WriteLine($"Popped: {poppedItem}");
        return poppedItem;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot peek.");
            return default(T);
        }
        return stackArray[top];
    }
}

class Program
{
    static void Main()
    {
        CustomStack<int> stack = new CustomStack<int>(5);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        var topItem = stack.Peek();
        Console.WriteLine($"Top item: {topItem}");

        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop(); // Trying to pop from an empty stack

        stack.Push(4);
    }
}

queue

using System;

class CustomQueue<T>
{
    private T[] queueArray;
    private int front;
    private int rear;
    private int maxSize;

    public CustomQueue(int size)
    {
        maxSize = size;
        queueArray = new T[maxSize];
        front = -1;
        rear = -1;
    }

    public bool IsEmpty()
    {
        return front == -1;
    }

    public bool IsFull()
    {
        return (rear == maxSize - 1 && front == 0) || (rear + 1 == front);
    }

    public void Enqueue(T item)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue is full. Cannot enqueue.");
            return;
        }
        if (rear == maxSize - 1)
        {
            rear = 0;
        }
        else
        {
            rear++;
        }
        queueArray[rear] = item;

        if (front == -1)
        {
            front = 0;
        }
        Console.WriteLine($"Enqueued: {item}");
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty. Cannot dequeue.");
            return default(T);
        }

        T dequeuedItem = queueArray[front];

        if (front == rear)
        {
            front = rear = -1;
        }
        else if (front == maxSize - 1)
        {
            front = 0;
        }
        else
        {
            front++;
        }
        Console.WriteLine($"Dequeued: {dequeuedItem}");
        return dequeuedItem;
    }
}

class Program
{
    static void Main()
    {
        CustomQueue<int> queue = new CustomQueue<int>(5);

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue(); // Trying to dequeue from an empty queue

        queue.Enqueue(4);
        queue.Enqueue(5);
    }
}

LL
using System;

class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

class CustomLinkedList<T>
{
    private Node<T> head;

    public CustomLinkedList()
    {
        head = null;
    }

    public bool IsEmpty()
    {
        return head == null;
    }

    public void AddNode(T data)
    {
        var newNode = new Node<T>(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        Console.WriteLine($"Added: {data}");
    }

    public bool RemoveNode(T data)
    {
        if (IsEmpty())
        {
            Console.WriteLine("List is empty. Cannot remove.");
            return false;
        }

        if (head.Data.Equals(data))
        {
            head = head.Next;
            Console.WriteLine($"Removed: {data}");
            return true;
        }

        var current = head;
        while (current.Next != null)
        {
            if (current.Next.Data.Equals(data))
            {
                current.Next = current.Next.Next;
                Console.WriteLine($"Removed: {data}");
                return true;
            }
            current = current.Next;
        }
        Console.WriteLine($"Data not found: {data}");
        return false;
    }

    public void DisplayList()
    {
        if (IsEmpty())
        {
            Console.WriteLine("List is empty.");
            return;
        }

        var current = head;
        Console.Write("List: ");
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        CustomLinkedList<int> linkedList = new CustomLinkedList<int>();

        linkedList.AddNode(1);
        linkedList.AddNode(2);
        linkedList.AddNode(3);

        linkedList.RemoveNode(2);
        linkedList.RemoveNode(4); // Trying to remove a non-existent node

        linkedList.DisplayList();
    }
}

BT

using System;

class Node<T>
{
    public T Data { get; set; }
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }

    public Node(T data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

class CustomBinaryTree<T> where T : IComparable<T>
{
    private Node<T> root;

    public CustomBinaryTree()
    {
        root = null;
    }

    public void Insert(T data)
    {
        root = InsertNode(root, data);
        Console.WriteLine($"Inserted: {data}");
    }

    private Node<T> InsertNode(Node<T> node, T data)
    {
        if (node == null)
        {
            return new Node<T>(data);
        }

        if (data.CompareTo(node.Data) < 0)
        {
            node.Left = InsertNode(node.Left, data);
        }
        else if (data.CompareTo(node.Data) > 0)
        {
            node.Right = InsertNode(node.Right, data);
        }

        return node;
    }

    public void InorderTraversal()
    {
        Console.Write("Inorder Traversal: ");
        Inorder(root);
        Console.WriteLine();
    }

    private void Inorder(Node<T> node)
    {
        if (node != null)
        {
            Inorder(node.Left);
            Console.Write(node.Data + " ");
            Inorder(node.Right);
        }
    }

    public bool Search(T data)
    {
        return SearchNode(root, data);
    }

    private bool SearchNode(Node<T> node, T data)
    {
        if (node == null)
        {
            return false;
        }

        if (data.CompareTo(node.Data) == 0)
        {
            return true;
        }

        if (data.CompareTo(node.Data) < 0)
        {
            return SearchNode(node.Left, data);
        }

        return SearchNode(node.Right, data);
    }
}

class Program
{
    static void Main()
    {
        CustomBinaryTree<int> binaryTree = new CustomBinaryTree<int>();

        binaryTree.Insert(10);
        binaryTree.Insert(5);
        binaryTree.Insert(15);
        binaryTree.Insert(3);

        binaryTree.InorderTraversal();

        bool found = binaryTree.Search(15);
        Console.WriteLine("Search for 15: " + found);

        found = binaryTree.Search(7);
        Console.WriteLine("Search for 7: " + found);
    }
}


Traversal

using System;

class Node
{
    public int Data { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

class BinaryTree
{
    public Node Root { get; private set; }

    public BinaryTree()
    {
        Root = null;
    }

    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
        {
            root = new Node(data);
            return root;
        }

        if (data < root.Data)
        {
            root.Left = InsertRec(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = InsertRec(root.Right, data);
        }

        return root;
    }

    public void InorderTraversal()
    {
        Console.Write("In-order Traversal: ");
        InorderRec(Root);
        Console.WriteLine();
    }

    private void InorderRec(Node root)
    {
        if (root != null)
        {
            InorderRec(root.Left);
            Console.Write(root.Data + " ");
            InorderRec(root.Right);
        }
    }

    public void PreorderTraversal()
    {
        Console.Write("Pre-order Traversal: ");
        PreorderRec(Root);
        Console.WriteLine();
    }

    private void PreorderRec(Node root)
    {
        if (root != null)
        {
            Console.Write(root.Data + " ");
            PreorderRec(root.Left);
            PreorderRec(root.Right);
        }
    }

    public void PostorderTraversal()
    {
        Console.Write("Post-order Traversal: ");
        PostorderRec(Root);
        Console.WriteLine();
    }

    private void PostorderRec(Node root)
    {
        if (root != null)
        {
            PostorderRec(root.Left);
            PostorderRec(root.Right);
            Console.Write(root.Data + " ");
        }
    }
}

class Program
{
    static void Main()
    {
        BinaryTree binaryTree = new BinaryTree();

        binaryTree.Insert(10);
        binaryTree.Insert(5);
        binaryTree.Insert(15);
        binaryTree.Insert(3);
        binaryTree.Insert(7);

        binaryTree.InorderTraversal();
        binaryTree.PreorderTraversal();
        binaryTree.PostorderTraversal();
    }
}

Linear Search

using System;

class LinearSearch
{
    public static int Search(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i; // Element found at index i
            }
        }
        return -1; // Element not found
    }
}

class Program
{
    static void Main()
    {
        int[] data = { 10, 25, 7, 42, 15, 30, 8, 50, 5 };

        int target = 42;
        int result = LinearSearch.Search(data, target);

        if (result != -1)
        {
            Console.WriteLine($"Element {target} found at index {result}.");
        }
        else
        {
            Console.WriteLine($"Element {target} not found in the array.");
        }
    }
}


Binary Search

using System;

class BinarySearch
{
    public static int Search(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                return mid; // Return the index of the target element if found
            }

            if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1; // Return -1 to indicate that the target element was not found
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int target = 6;

        int result = BinarySearch.Search(arr, target);

        if (result != -1)
        {
            Console.WriteLine($"Element {target} found at index {result}");
        }
        else
        {
            Console.WriteLine($"Element {target} not found in the array");
        }
    }
}


Bubble sort

using System;

class BubbleSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap arr[j] and arr[j + 1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 5, 1, 4, 2, 8 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        BubbleSort.Sort(arr);

        Console.WriteLine("Sorted Array:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}


Insertion sort

using System;

class InsertionSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 5, 1, 4, 2, 8 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        InsertionSort.Sort(arr);

        Console.WriteLine("Sorted Array:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}


Merge sort

using System;

class MergeSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        if (n > 1)
        {
            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }

            for (int i = mid; i < n; i++)
            {
                right[i - mid] = arr[i];
            }

            Sort(left);
            Sort(right);
            Merge(arr, left, right);
        }
    }

    private static void Merge(int[] arr, int[] left, int[] right)
    {
        int nL = left.Length;
        int nR = right.Length;
        int i = 0, j = 0, k = 0;

        while (i < nL && j < nR)
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }

        while (i < nL)
        {
            arr[k] = left[i];
            i++;
            k++;
        }

        while (j < nR)
        {
            arr[k] = right[j];
            j++;
            k++;
        }
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 38, 27, 43, 3, 9, 82, 10 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        MergeSort.Sort(arr);

        Console.WriteLine("Sorted Array:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}*/







