using System;
using System.Collections.Generic;

namespace AddTwoLinkedLists
{
    class Program
    {
        /**
        * Definition for singly-linked list.
        * public class ListNode {
        *     public int val;
        *     public ListNode next;
        *     public ListNode(int x) { val = x; }
        * }


        You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

        You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        Example:

        Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        Output: 7 -> 0 -> 8
        Explanation: 342 + 465 = 807.

        */

         public class ListNode {
            public int val;
            public ListNode next;

            public ListNode(int x) {
                 val = x;
            }
         }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            //collection
            Queue<ListNode> output = new Queue<ListNode>();

            //loop while traversing nodes
            ListNode temp1 = l1;
            ListNode temp2 = l2;

            //carry other number
            int carryOver = 0;

            while(temp1 != null || carryOver == 1){
                //create new node for each calculation + calculate and make it its value
                ListNode newNode = new ListNode(0);
                newNode.next = null;

                //calculation logic
                if(temp1 == null && carryOver == 1){
                    newNode.val = 1;
                    carryOver = 0;
                }
                else {
                    if(temp1.val + temp2.val > 9){
                        newNode.val = (temp1.val + temp2.val + carryOver) - 10;
                        carryOver = 1;
                    }
                    else {
                        newNode.val = temp1.val + temp2.val + carryOver;
                        carryOver = 0;
                    }

                    //traverse further
                    temp1 = temp1.next;
                    temp2 = temp2.next;
                }

                
                //append to Queue
                output.Enqueue(newNode);

            }

            //set correct connection between nodes
            var output2 = output.ToArray();
            for(int i = 0 ; i < output2.Length ; i++){
                if(output2.Length <= i+1){
                    output2[i].next = null;
                }
                else{
                    output2[i].next = output2[i+1];
                }
                
            }
            
            //return one node thats properly connected to everything
            return output2[0];
        }


        static void Main(string[] args)
        {
            //list node 1
            // ListNode node3 = new ListNode(3);
            // node3.next = null;
            // ListNode node2 = new ListNode(4);
            // node2.next = node3;
            ListNode node1 = new ListNode(5);
            node1.next = null;
            // 342 in reverse (243)
            
            //list node 2
            // ListNode node3_2 = new ListNode(4);
            // node3_2.next = null;
            // ListNode node2_2 = new ListNode(6);
            // node2_2.next = node3_2;
            ListNode node1_2 = new ListNode(5);
            node1_2.next = null;
            // 465 in reverse (564)
            
            
            //out
            ListNode output = AddTwoNumbers(node1,node1_2);
            //traversal node
            ListNode temp = output;
            while(temp!=null){
                Console.Write(temp.val);
                temp = temp.next;
            }
            //expected 708 (reverse of 807)
        }
    }
}
