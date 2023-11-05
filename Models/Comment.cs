using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheWall.Models
{


public class Comment
    {
        [Key]
        public int CommentId {get;set;}
        public int MessageId {get;set;}
        public int UserId {get;set;}
        public string CommentText {get;set;}
        public Message Message {get;set;}
        public User CmntMaker {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}    