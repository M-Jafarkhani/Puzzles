/*
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { this.val = x; this.next = null; }
}
*/

ListNode A, B;

var list_A = ListNodeToNumberList(A);

var list_B = ListNodeToNumberList(B);

var result = SumOfTwoNumbers(list_A, list_B);

return 1;

List<int> ListNodeToNumberList(ListNode list)
{
    List<int> result = new List<int>();

    ListNode current = list;

    while (current != null)
    {
        result.Add(current.val);

        current = current.next;
    }

    return result;
}

ListNode SumOfTwoNumbers(List<int> num1, List<int> num2)
{
    int carry = 0;

    int sum = num1[0] + num2[0];

    carry = sum / 10;

    ListNode head = new ListNode(sum % 10);

    ListNode current = head;

    int i = 1, j = 1;

    for (; i < num1.Count && j < num2.Count; i++, j++)
    {
        sum = num1[i] + num2[j] + carry;

        var newNode = new ListNode(sum % 10);

        carry = sum / 10;

        current.next = newNode;

        current = newNode;
    }

    while (i < num1.Count)
    {
        sum = num1[i] + carry;

        var newNode = new ListNode(sum % 10);

        carry = sum / 10;

        current.next = newNode;

        current = newNode;

        i++;
    }

    while (j < num2.Count)
    {
        sum = num2[j] + carry;

        var newNode = new ListNode(sum % 10);

        carry = sum / 10;

        current.next = newNode;

        current = newNode;

        j++;
    }

    if (carry != 0)
    {
        var newNode = new ListNode(carry);

        current.next = newNode;
    }

    return head;
}

