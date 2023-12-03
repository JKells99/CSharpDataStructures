public class LinkedList
{

    private Node head;

    private Node current; // this will  have latest node

    public int count;

    public LinkedList()
    {
        head = new Node();
        current = head;
    }

    public void AddAtLast(object data)
    {
        Node newNode = new Node();
        newNode.Value = data;
        current.Next = newNode;
        current = newNode;
    }

    public void AddAtStart(object data)
    {
        Node newNode = new Node() {Value = data};
        newNode.Next = head.Next;
        head.Next = newNode;
        count++;
    
    }

    public void RemoveFromStart()
    {
        if(count > 0)
        {
            head.Next = head.Next.Next;
            count--;
        }
        else
        {

            Console.WriteLine("No Elleys in Linked Listy");
    
        }
    }

    public void PrintAllNodes()
    {
        Console.Write("Head ->");
        Node curr = head;
        while(curr.Next != null)
        {
            curr = curr.Next;
            Console.Write(curr.Value);
            Console.Write("->");
        }

        Console.Write("NULL");
    }
    
}