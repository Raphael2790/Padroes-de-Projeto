using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Design_patterns.Composite
{
    public class Message : IMessage , IEnumerable<IMessage>
    {
        private readonly List<IMessage> _messageList = new List<IMessage>();
        public string Description { get; set; }

        public Message(string description)
        {
            Description = description;
        }

        public IEnumerator<IMessage> GetEnumerator()
        {
           return ((IEnumerable<IMessage>)_messageList).GetEnumerator();
        }

        public void AddChild(IMessage message)
        {
            _messageList.Add(message);
        }

        public void RemoveChild(IMessage message)
        {
            _messageList.Remove(message);
        }

        public IMessage GetChild(int index)
        {
            return _messageList[index];
        }

        public IMessage GetChild(string description)
        {
            return _messageList.First(x => x.Description == description);
        }

        public IEnumerable<IMessage> GetMessages()
        {
            return _messageList;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<IMessage>)_messageList).GetEnumerator();
        }

        public void ShowMessages(int sub)
        {
            Console.WriteLine(new string('-', sub) + Description);

            foreach (var message in _messageList)
            {
                message.ShowMessages(sub + 2);
            }
        }
    }
}