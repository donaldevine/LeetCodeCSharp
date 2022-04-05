using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class Trie
    {
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            var node = root;

            foreach (var c in word)
            {
                if (!node.ContainsKey(c))
                {
                    node.Put(c, new TrieNode());
                }
                node = node.Get(c);
            }

            node.IsEnd = true;

        }

        private TrieNode SearchPrefix(string word)
        {
            var node = root;

            foreach (var c in word)
            {
                if (node.ContainsKey(c))
                {
                    node = node.Get(c);
                }
                else
                {
                    return null;
                }                
            }

            return node;
        }

        public bool Search(String word)
        {
            TrieNode node = SearchPrefix(word);
            return node != null && node.IsEnd;
        }

        public bool startsWith(String prefix)
        {
            TrieNode node = SearchPrefix(prefix);
            return node != null;
        }
    }
}
