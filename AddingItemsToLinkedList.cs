using system;

public class Program
{
    public static void Main()
    {
        AddHead();        
    }

    Public AddHead(int value)
    {
        DoublyLinkedListNode<int> adding = new DoublyLinkedListNode <int>(value, null, head);

        if (head != null)
        {
            head.Previous = adding;
        }

        head = adding;

        if (tail == null)
        {
            tail = head;
        }

        count += 1;
    }
}