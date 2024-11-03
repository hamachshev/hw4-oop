using System;
using System.Collections.Generic;

namespace HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // testing problem 2
            Tree<int> tree1 = new Tree<int>(10);
            tree1.left = new Tree<int>(5);
            tree1.right = new Tree<int>(15);
            tree1.left.left = new Tree<int>(3);
            tree1.left.right = new Tree<int>(7);
            
            Tree<int> tree2 = new Tree<int>(20);
            tree2.left = new Tree<int>(18);
            tree2.right = new Tree<int>(25);
            tree2.right.left = new Tree<int>(22);
            
            // Create a linked list of trees
            LinkedList<Tree<int>> trees = new LinkedList<Tree<int>>();
            trees.AddLast(tree1);
            trees.AddLast(tree2);
            
            // Search for values in the linked trees
            Console.WriteLine(SearchLinkedTrees<int>.search(trees, 7)); //  True
            Console.WriteLine(SearchLinkedTrees<int>.search(trees, 18)); //  True
            Console.WriteLine(SearchLinkedTrees<int>.search(trees, 30)); //  False


            //problem 3 testing
            CircularLinkedListNode<int> node1 = new CircularLinkedListNode<int>(1);
            CircularLinkedListNode<int> node2 = new CircularLinkedListNode<int>(2);
            CircularLinkedListNode<int> node3 = new CircularLinkedListNode<int>(3);
            CircularLinkedListNode<int> node4 = new CircularLinkedListNode<int>(4);
            CircularLinkedListNode<int> node5 = new CircularLinkedListNode<int>(5);
            
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node1;
            
            Console.WriteLine(CircularLinkedListSize<int>.size(node1, null));
            
            //testing the shell sort
            int[] array = { 2, 60, 5, 8, 9, 99,44, 1, 3, 17, 88 };
            Shellsort<int>.sort(array);
            Console.WriteLine(string.Join(" ", array));
        }
    }
}


