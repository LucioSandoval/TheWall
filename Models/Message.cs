
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheWall.Models
{


public class Message
    {
        [Key]
        public int MessageId {get;set;}
        public int UserId {get;set;}
        public string MessageText {get;set;}
        public User MsgMaker {get;set;}
        public List<Comment> RelatedComments {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}