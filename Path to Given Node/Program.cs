/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */

List<TreeNodeWithRoot> nodes = new List<TreeNodeWithRoot>();

List<int> result = new List<int>();

bool found = false;

TreeNode A = new TreeNode(1);

int B = 1;

search(A, A, B);

TreeNodeWithRoot tail = nodes.Where(p => p.node.val == B).First();

while (tail.node != A)
{
    result.Add(tail.node.val);

    tail = nodes.Where(p => p.node.val == tail.root.val).First();
}

result.Add(A.val);

result.Reverse();

return 1;

void search(TreeNode node, TreeNode root, int B)
{
    if (found || node == null)
    {
        return;
    }

    if (node.val == B)
    {
        nodes.Add(new TreeNodeWithRoot(node, root));

        found = true;

        return;
    }

    nodes.Add(new TreeNodeWithRoot(node, root));

    search(node.left, node, B);

    search(node.right, node, B);
}

class TreeNodeWithRoot
{
    public TreeNode node { get; set; }

    public TreeNode root { get; set; }

    public TreeNodeWithRoot(TreeNode _node, TreeNode _root)
    {
        node = _node;

        root = _root;
    }
}


