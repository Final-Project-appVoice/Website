﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppVoice
{
    public class Message
    {
        private string messageFrom, messageTo, messageText;
        private bool isRead;
        private DateTime date;
        private int messageId;

        public Message(string messageFrom, string messageTo, string messageText, DateTime date, bool isRead)
        {
            this.messageFrom = messageFrom;
            this.messageTo = messageTo;
            this.messageText = messageText;
            this.date = date;
            this.isRead = isRead;
        }

        public Message(int messageId, string messageFrom, string messageTo, string messageText, DateTime date, bool isRead) : this(messageFrom, messageTo, messageText, date, isRead)
        {
            this.messageId = messageId;
           
        }

        public int MessageId
        {
            set
            {
                messageId = value;
            }
            get
            {
                return messageId;
            }
        }
        public string MessageFrom
        {
            set
            {
                messageFrom = value;
            }
            get
            {
                return messageFrom;
            }
        }
        public string MessageTo
        {
            set
            {
                messageTo = value;
            }
            get
            {
                return messageTo;
            }
        }
        public string MessageText
        {
            set
            {
                messageText = value;
            }
            get
            {
                return messageText;
            }
        }
        public DateTime MessageDate
        {
            set
            {
                date = value;
            }
            get
            {
                return date;
            }
        }
        public bool IsRead
        {
            set
            {
                isRead = value;
            }
            get
            {
                return isRead;
            }
        }
    }
}