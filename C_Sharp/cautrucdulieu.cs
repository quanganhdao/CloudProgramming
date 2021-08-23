using System.Xml.Xsl.Runtime;
using System;
using System.Collections.Generic;

public class CtrucDulieu
{

    public static void addNode(LinkedList<int> list)
    {
        list.AddLast(100);
    } // end of addNode 
    public static void addNode(LinkedList<int> list, int index)
    {
        if (index < 1 || index > list.Count)
        {
            Console.WriteLine(">>>>ERROR: IndexOutOfBound<<<<<");
            Console.WriteLine("Adding Failed");
        }
        else if (index < 2)
        {
            list.AddFirst(-1);
        }
        else
        {
            LinkedListNode<int> node;
            node = list.First;
            for (int i = 1; i < index - 1; i++)
            {
                node = node.Next;
            }
            list.AddAfter(node, 77);
        }
    }// end of addNode

    public static void removeNode(LinkedList<int> list)
    {
        list.RemoveLast();
    }// end of removeNode

    public static void removeNode(LinkedList<int> list, int index)
    {
        if (index < 1 || index > list.Count)
        {
            Console.WriteLine(">>>>ERROR: IndexOutOfBound<<<<<");
            Console.WriteLine("Removing Failed");
        }
        else if (index < 2)
        {
            list.RemoveFirst();
        }
        else
        {
            LinkedListNode<int> node;
            node = list.First;
            for (int i = 1; i < index; i++)
            {
                node = node.Next;
            }
            list.Remove(node);

        }
    }

    public static void printList(LinkedList<int> list)
    {
        Console.WriteLine("In ra danh sach lien ket:\n");
        int i = 1;
        LinkedListNode<int> node = list.First;
        while (node != null)
        {
            Console.WriteLine($"{i} " + node.Value);
            node = node.Next;
            i++;
        } // end of While
        Console.WriteLine("------------------------");
    } // end of printList

    public static void bubbleSort(LinkedList<int> list){
        int temp;
        for(int i=0; i<list.Count-2;i++){
            for(LinkedListNode<int> node = list.First;node.Next!=null;node=node.Next){
                if(node.Value >node.Next.Value){
                    temp= node.Value;
                    node.Value = node.Next.Value;
                    node.Next.Value =temp;
                }
            }
        }
    }


// Thuat toan tìm kiếm nhị phân

    static int binarySearch(LinkedList<int> list, int value){
        LinkedListNode<int> node= new LinkedListNode<int>(100);
        node =list.First;
        int tail = list.Count;
        int head =1;
        int tracker=head;
            while(head<=tail){
                int middle = (tail+head)/2;
                if(middle==tracker){
                    if(value>node.Value){
                        head=middle+1;
                        tracker= head;
                        node=node.Next;
                        continue;
                    } else if(value<node.Value){
                        tail= middle-1;
                        tracker= 1;
                        node = list.First;
                        continue;
                    } else return 1;
                }

                tracker ++;
                node = node.Next;

            }
            return 0; // không tìm thấy
    } // end of " binarySearch"

    
    static int binarySearch(int[] arr, int left, int right, int x) {
    int middle;
 
    while(left <= right) {
        // Lấy vị trí ở giữa left và right
        middle = (left + right) / 2;
 
        // Nếu phần từ ở giữa bằng x thì trả về
        // vị trí
        if (arr[middle] == x)
            return middle;
 
        // Nếu x lớn hơn phần tử ở giữa thì
        // chắc chắn nó nằm bên phải.
        // Chỉ định left phần từ ở giữa + 1
        if (x > arr[middle])
            left = middle + 1;
        else
            //Ngược lại
            right = middle - 1;
    }
 
    //Trả về -1 nếu không tìm thấy gía trị trong mảng.
    return 0;
}

// Copy LinkedList sang một mảng 1 chiều
    public static int[] copyToArray(LinkedList<int> list ){
        int []array =new int[list.Count];
        list.CopyTo(array,0);

     return array;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("---------------------------");

        // Khởi tạo LinkList có 3 phần tử đầu  tiên
        Console.WriteLine("KHOI TAO DANH SACH LIEN KET");
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);


        // In ra danh sách các phần từ trong LinkList
        printList(list);

        // Thêm 1 phần tử 
        Console.WriteLine("THEM PHAN TU");
        addNode(list);
        addNode(list, 3);
        printList(list);

        // Xóa 1 phần tử
        Console.WriteLine("XOA MOT PHAN TU");
        removeNode(list, 4);
        printList(list);
        // thử thay đổi THÔNG TIN 1 node 
        // Thêm 1 số phần tử vào cho việc sắp xếp
        list.AddLast(20);
        list.AddLast(6);
        list.AddFirst(76);
        list.AddLast(23);
        printList(list);
        // Sắp xếp
        Console.WriteLine("Thuật toán sắp xếp nổi bọt");
        bubbleSort(list);
        printList(list);

        // int [] array = copyToArray(list);
        // int k=binarySearch(array,0,list.Count-1, 24);
        int k= binarySearch(list,23);
        if(k ==0){
            Console.WriteLine("khong tim thay :(");
        } else Console.WriteLine("Tim thay roi!!!");

        
    } // end of Main
} // end of class CtrucDulieu