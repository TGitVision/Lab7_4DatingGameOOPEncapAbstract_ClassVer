﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_4DatingGameOOPEncapAbstract_ClassVer
{
    class Message
    {
        public DatingProfile sender { get; set; }
        public string messageTitle { get; set; }
        public string messageData { get; set; }
        private bool isRead { get; set; }
        public Message(DatingProfile sender, string messageTitle, string messageData)
        {
            this.sender = sender;
            this.messageTitle = messageTitle;
            this.messageData = messageData;
            this.isRead = false;
        }
    }
}
