using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace StackTest{

    public class MinStack {
        private int count;
        private Stack_Node top;

        /** initialize your data structure here. */
        public MinStack() {
            count = 0;
            top = null;
        }
        //Push element x onto stack.
        public void Push(int x) {
            Stack_Node temp = new Stack_Node(x,top);
            this.top = temp;
            count++;
        }
        //Removes the element on top of the stack.
        public void Pop() {
            Stack_Node temp = this.top;
            this.top = top.GetNext();
            temp.Dispose();
        }
        //Get the top element.
        public int Top() {
            return top.GetData();
        }
        //Retrieve the minimum element in the stack.
        public int GetMin() {
            int output = this.top.GetData();
            Stack_Node temp = this.top;
            while(temp != null){
                if(temp.GetData() < output) output = temp.GetData();
                temp = temp.GetNext();
            }
            return output;
        }
    }

    public class Stack_Node : IDisposable{
        private int data;
        private Stack_Node next;

        //Memory management helpers
        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public Stack_Node(int data, Stack_Node next){
            this.data = data;
            this.next = next;
        }

        public int GetData(){
            return this.data;
        }
        public Stack_Node GetNext(){
            return this.next;
        }


        //Memory management helpers
        public void Dispose(){
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing){
            if(disposed) return;
            if(disposing){
                handle.Dispose();
            }
            disposed = true;
        }



    }
}


