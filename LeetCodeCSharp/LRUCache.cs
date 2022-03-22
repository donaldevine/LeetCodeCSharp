using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.
/// Implement the LRUCache class:
/// LRUCache(int capacity) Initialize the LRU cache with positive size capacity.
/// int get(int key) Return the value of the key if the key exists, otherwise return -1.
/// void put(int key, int value) Update the value of the key if the key exists.Otherwise, add the key-value pair to the cache.If the number of keys exceeds the capacity from this operation, evict the least recently used key.
/// The functions get and put must each run in O(1) average time complexity.
/// </summary>

namespace LeetCodeCSharp
{
    public class LRUCache
    {
        private readonly int capacity = 0;
        private Dictionary<int, DLinkedNode> cache = new Dictionary<int, DLinkedNode>();
        private int size = 0;
        private DLinkedNode head;
        private DLinkedNode tail;

        private class DLinkedNode
        {
            public int key;
            public int value;
            public DLinkedNode prev;
            public DLinkedNode next;
        }

        public LRUCache(int capacity)
        {
            this.capacity = capacity;

            head = new DLinkedNode();
            tail = new DLinkedNode();
            head.next = tail;
            tail.prev = head;
        }

        private void addNode(DLinkedNode node)
        {
            /**
             * Always add the new node right after head.
             */
            node.prev = head;
            node.next = head.next;

            head.next.prev = node;
            head.next = node;
        }

        private void removeNode(DLinkedNode node)
        {
            /**
             * Remove an existing node from the linked list.
             */
            DLinkedNode prev = node.prev;
            DLinkedNode next = node.next;

            prev.next = next;
            next.prev = prev;
        }

        private void moveToHead(DLinkedNode node)
        {
            /**
             * Move certain node in between to the head.
             */
            removeNode(node);
            addNode(node);
        }

        private DLinkedNode popTail()
        {
            /**
             * Pop the current tail.
             */
            DLinkedNode res = tail.prev;
            removeNode(res);
            return res;
        }

        public int Get(int key)
        {
            if (!cache.ContainsKey(key)) return -1;

            DLinkedNode node = cache[key];

            // move the accessed node to the head;
            moveToHead(node);

            return node.value;
        }

        public void Put(int key, int value)
        {


            if (!cache.ContainsKey(key))
            {
                var newNode = new DLinkedNode();
                newNode.key = key;
                newNode.value = value;

                cache.Add(key, newNode);

                addNode(newNode);

                size++;

                if (size > capacity)
                {
                    // pop the tail
                    DLinkedNode tail = popTail();
                    cache.Remove(tail.key);
                    size--;
                }
            }
            else
            {
                DLinkedNode node = cache[key];
                node.value = value;
                moveToHead(node);
            }
        }
    }
}
