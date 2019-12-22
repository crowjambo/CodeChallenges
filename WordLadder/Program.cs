using System;
using System.Collections.Generic;

namespace WordLadder
{
    class Program
    {
        /* 
        
        Given two words (beginWord and endWord), and a dictionary's word list, find the length of shortest transformation sequence from beginWord to endWord, such that:

        Only one letter can be changed at a time.
        Each transformed word must exist in the word list. Note that beginWord is not a transformed word.
        
        */

        //breadth first search
        public static int LadderLength(string beginWord, string endWord, IList<string> wordList) {
            HashSet<string> test = new HashSet<string>();
            foreach(string x in wordList){
                test.Add(x);
            }
            if(!test.Contains(endWord)){
                return 0;
            }
    

            Queue<string> queue = new Queue<string>();
            queue.Enqueue(beginWord);
            int level = 1;

            while(queue.Count != 0){
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    string current_word = queue.Dequeue();
                    var word_chars = current_word.ToCharArray();
                    for (int j = 0; j < word_chars.Length; j++)
                    {
                        char original_char = word_chars[j];
                        for(char c='a'; c <'z'; c++){
                            if(word_chars[j] == c) continue;
                            word_chars[j] = c;
                            string new_word = new string(word_chars);
                            if(String.Equals(new_word,endWord)) return level+1;
                            if(test.Contains(new_word)){
                                queue.Enqueue(new_word);
                                test.Remove(new_word);
                            }
                        }
                        word_chars[j] = original_char;
                    }

                }
                
                level++;
            }

            return 0;
        }

        static void Main(string[] args)
        {
            string beginWord = "hit";
            string endWord = "cog";
            List<string> wordList = new List<string>(){"hot","dot","dog","lot","log","cog"};

            System.Console.WriteLine(LadderLength(beginWord,endWord,wordList));
        }
    }
}
