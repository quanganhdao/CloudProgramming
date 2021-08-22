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
        printList(list);
        // Sắp xếp
        Console.WriteLine("Sắp xếp nổi bọt");
        bubbleSort(list);
        printList(list);
        

    } // end of Main
} // end of class CtrucDulieu