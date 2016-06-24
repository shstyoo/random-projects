"""
Node is defined as
self.left (the left child of the node)
self.right (the right child of the node)
self.data (the value of the node)
"""
def preOrder(root):
    # set value current to the root node
    current = root

    # check if value of node exists, if not pass
    if current:

        # print the current value of the node
        print(current.data, end=" ")

        # recursively call the left node
        preOrder(current.left)

        # recursively call the right node
        preOrder(current.right)

'''
INSTRUCTIONS

Complete the preOrder function in your editor below, which has  parameter: a pointer to the root of a binary tree. It must print the values in the tree's preorder traversal as a single line of space-separated values.

Input Format

Our hidden tester code passes the root node of a binary tree to your preOrder function.

Output Format

Print the tree's preorder traversal as a single line of space-separated values.
'''
