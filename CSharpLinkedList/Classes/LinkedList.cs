namespace CSharpLinkedList.Classes
{
    using System;

    public class LinkedList
    {
        private Node head;
        private int size;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedList"/> class.
        /// </summary>
        public LinkedList()
        {
            this.head = null;
            this.size = 0;
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref="LinkedList"/> is empty.
        /// </summary>
        public bool Empty
        {
            get
            {
                return this.size == 0;
            }
        }

        /// <summary>
        /// Gets a value indicating how large the <see cref="LinkedList"/> is.
        /// </summary>
        public int Size
        {
            get
            {
                return this.size;
            }
        }

        /// <summary>
        /// Inserts a new <see cref="Node"/> into the <see cref="LinkedList"/>.
        /// </summary>
        /// <param name="input">The data to be inserted into the <see cref="Node"/>.</param>
        /// <returns>The current <see cref="LinkedList"/>.</returns>
        public LinkedList Insert(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                int index = this.size;
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException("Index: " + index);
                }

                Node current = this.head;

                if (this.Empty || index == 0)
                {
                    this.head = new Node(input, this.head);
                }
                else
                {
                    // Navigates to the end of the list.
                    for (int count = 0; count < index - 1; count++)
                    {
                        current = current.Next;
                    }

                    current.Next = new Node(input, current.Next);
                }

                this.size++;

                return this;
            }
            else
            {
                var outcomeOfInput = input == null ? "null" : "empty";
                Console.WriteLine($"String was {outcomeOfInput}");

                return this;
            }
        }

        /// <summary>
        /// Deletes a <see cref="Node"/> from the <see cref="LinkedList"/>.
        /// </summary>
        /// <param name="input">The data to find the <see cref="Node"/> to delete.</param>
        /// <returns>The current <see cref="LinkedList"/>.</returns>
        public LinkedList Delete(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                Node current = this.head;

                if (current.Data == input)
                {
                    this.head = current.Next;
                }
                else
                {
                    for (int count = 0; count < this.Size; count++)
                    {
                        if (current.Next.Data == input)
                        {
                            current.Next = current.Next.Next;
                            this.size--;
                        }
                        else
                        {
                            current = current.Next;
                        }
                    }
                }

                return this;
            }
            else
            {
                var outcomeOfInput = input == null ? "null" : "empty";
                Console.WriteLine($"String was {outcomeOfInput}");

                return this;
            }
        }

        /// <summary>
        /// Prints all data in the <see cref="LinkedList"/>.
        /// </summary>
        public void PrintAll()
        {
            if (this.head != null)
            {
                int count = 1;
                Node current = this.head;
                Console.WriteLine("Node" + count + ":" + current.Data);

                while (current.Next != null)
                {
                    count++;
                    current = current.Next;
                    Console.WriteLine("Node" + count + ":" + current.Data);
                }
            }
            else
            {
                Console.WriteLine($"The LinkedList's head was null.");
            }
        }
    }
}