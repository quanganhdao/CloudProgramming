using System;
using System.Collections.Generic;

public class CtrucDulieu{

    public static void addNode(LinkedList<string> list) {
        list.AddLast("New card");
    } // end of addNode 
    public static void addNode(LinkedList<string> list,int index) {
        if(index<1 || index>list.Count){
            Console.WriteLine(">>>>ERROR: IndexOutOfBound<<<<<");
            Console.WriteLine("Adding Failed");
        } else if(index<2){
            list.AddFirst("New Card added by Index "+index);
        } else{
            LinkedListNode<string> node;
        node = list.First;
        for(int i = 1; i < index-1; i++){
            node = node.Next;
        }
        list.AddAfter(node, "New Card added by index "+index);
        }
    }// end of addNode

    public static void removeNode(LinkedList<string> list) {
        list.RemoveLast();
    }// end of removeNode

    public static void removeNode(LinkedList<string> list, int index) {
        if(index<1||index>list.Count){
            Console.WriteLine(">>>>ERROR: IndexOutOfBound<<<<<");
            Console.WriteLine("Removing Failed");
        } else if (index<2){
            list.RemoveFirst();
        } else {
        LinkedListNode<string> node;
        node = list.First;
        for(int i = 1; i < index; i++){
            node = node.Next;
        }
        list.Remove(node);
            
        }
    }

    public static void printList( LinkedList<string> list){
        Console.WriteLine("In ra danh sach lien ket:\n");
        int i=1;
        LinkedListNode<string> node = list.First;
        while (node != null) {
        Console.WriteLine($"{i} "+node.Value);
         node = node.Next;
         i++;
                    } // end of While
                    Console.WriteLine("------------------------");
    } // end of printList
        public static void Main(string[] args) {
            Console.WriteLine("---------------------------");

    // Khởi tạo LinkList có 3 phần tử đầu  tiên
        Console.WriteLine("KHOI TAO DANH SACH LIEN KET");
        LinkedList<string> list = new LinkedList<string>();
        list.AddLast("Card 1");
        list.AddLast("Card 2");
        list.AddLast("Card 3");
    

// In ra danh sách các phần từ trong LinkList
        printList( list);

// Thêm 1 phần tử 
        Console.WriteLine("THEM PHAN TU");
        addNode(list);
        addNode(list,3);
        printList(list);

// Xóa 1 phần tử
        Console.WriteLine("XOA MOT PHAN TU");
        removeNode(list,4);
        printList(list);
// thử thay đổi THÔNG TIN 1 node 
        // list.First= new LinkedListNode<string>("ok");

        } // end of Main
} // end of class CtrucDulieu