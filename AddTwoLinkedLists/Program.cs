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

            while(temp1 != null || temp2 != null || carryOver == 1){
                //create new node for each calculation + calculate and make it its value
                ListNode newNode = new ListNode(0);
                newNode.next = null;

                //calculation logic
                if(temp1 == null && temp2 == null && carryOver == 1){
                    newNode.val = 1;
                    carryOver = 0;
                }
                else {
                    if(temp1 != null && temp2!= null){
                        if(temp1.val + temp2.val > 9){
                            newNode.val = (temp1.val + temp2.val + carryOver) - 10;
                            carryOver = 1;
                        }
                        else {
                            if(temp1.val + temp2.val + carryOver > 9){
                                newNode.val = temp1.val + temp2.val + carryOver - 10;
                                carryOver = 1;
                            }
                            else {
                                newNode.val = temp1.val + temp2.val + carryOver;
                                carryOver = 0;
                            }

                        }

                        //traverse further
                        temp1 = temp1.next;
                        temp2 = temp2.next;
                    }
                    //one is null ( had less arguments )
                    else{
                        if(temp1 == null){
                            //incase carry over 9+1 is 10
                            if(temp2.val + carryOver > 9){
                                newNode.val = temp2.val +carryOver - 10;
                                carryOver = 1;
                            }
                            else {
                                newNode.val = temp2.val + carryOver;
                                carryOver = 0;
                            }
                            temp2 = temp2.next;
                        }
                        else {
                            if(temp1.val + carryOver > 9){
                                newNode.val = temp1.val + carryOver - 10;
                                carryOver = 1;                                    
                            }
                            else{
                                newNode.val = temp1.val + carryOver;
                                carryOver = 0;
                            }
                            temp1 = temp1.next;
                        }
                    }

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
            ListNode node2 = new ListNode(7);
            node2.next = null;
            ListNode node1 = new ListNode(3);
            node1.next = node2;
            // 342 in reverse (243)
            
            //list node 2
            // ListNode node3_2 = new ListNode(4);
            // node3_2.next = null;
            ListNode node2_2 = new ListNode(2);
            node2_2.next = null;
            ListNode node1_2 = new ListNode(9);
            node1_2.next = node2_2;
            // 465 in reverse (564)
            
            
            //out
            ListNode output = AddTwoNumbers(node1_2,node1);
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
