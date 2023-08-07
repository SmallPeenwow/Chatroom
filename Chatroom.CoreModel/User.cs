﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatroom.CoreModel
{
    public class User
    {
        public Guid UserId { get; set; }

        [Required]
        public string? FirstName { get; set; }   

        public string? LastName { get; set; }

        [Required]
        public string? UniqueName { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? Email { get; set; }

        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        public DateTime? LastUpdatedAt { get; set; } = DateTime.Now;

        public ICollection<Message>? Message { get; set; }

        public ICollection<UserConversation>? UserConversations { get; set; }

        public ContactList? ContactList { get; set; }

    }
}
