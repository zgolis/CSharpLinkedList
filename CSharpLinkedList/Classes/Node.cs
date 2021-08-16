namespace CSharpLinkedList.Classes
{
    public class Node
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="data">The data to set for the <see cref="Node"/>.</param>
        /// <param name="next">The following <see cref="Node"/> to set for the current <see cref="Node"/>.</param>
        public Node(string data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }

        /// <summary>
        /// Gets or sets the <see cref="Node"/>'s Data value.
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Node"/>'s following <see cref="Node"/>.
        /// </summary>
        public Node Next { get; set; }
    }
}