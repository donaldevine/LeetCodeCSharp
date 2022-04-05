using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class TrieNode
    {
        //Links to children nodes
        private TrieNode[] links;

        private const int R = 26;
                
        public bool IsEnd { get; set; }

        public TrieNode()
        {
            links = new TrieNode[R];
        }

        public Boolean ContainsKey(char c)
        {
            return links[c - 'a'] != null;
        }

        public TrieNode Get(char ch)
        {
            return links[ch - 'a'];
        }

        public void Put(char ch, TrieNode node)
        {
            links[ch - 'a'] = node;
        }

    }
}
