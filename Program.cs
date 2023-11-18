using System;

class Node
{
    public int data;
    public Node next;
    public Node prev;
    public Node(int data)
    {
        this.data = data;
        this.next = null;
        this.prev = null;
    }
}

class DoublyLL
{
    private Node head;
    private int size;
    public DoublyLL()
    {
        this.head = null;
        this.size = 0;
    }
    public void add(Node node)
    {
        if(this.head ==null)
        {
            this.head=node;
        }
        else
        {
            node.next = this.head;
            this.head.prev = node;
            this.head = node;
        }
        this.size++;
    }
    public void delete() 
    {
        if(this.head == null)
        {
            Console.WriteLine("List is already empty!");
        }
        else 
        {
            Node current = this.head;
            while(current.next != null) 
            {
                current = current.next;
            }
            Node previous = current.prev;
            previous.next = null;
            current = null;
        }
        this.size--;
    }
    public void printList_from_head()
    {
        if(this.size == 0)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            Node n = this.head;
            while(n.next != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
            Console.WriteLine(n.data);
        }
    }
    public void printList_from_tail()
    {
        if (this.size == 0)
        {
            Console.WriteLine("List is empty");
        }
        Node n = this.head;
        while (n.next != null)//go to the tail
            n = n.next;
        while(n.prev != null)
        {
            Console.WriteLine(n.data);
            n = n.prev;
        }
        Console.WriteLine(n.data);

    }
}

class Hello
{
    static void Main()
    {
        DoublyLL doublyLL = new DoublyLL();
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
        foreach (var item in numbers)
        {
            doublyLL.add(new Node(item));
        }
        Console.WriteLine("List from head to tail");
        doublyLL.printList_from_head();
        Console.WriteLine("List from tail to head");
        doublyLL.printList_from_tail();
        Console.WriteLine("Delete operation");
        for(int i = 0; i < 3; i++) 
        {
            doublyLL.delete();
        }
        //to check delete operation is working or not
        //print list again
        doublyLL.printList_from_head();

    }
}