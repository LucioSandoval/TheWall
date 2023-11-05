using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheWall.Models
{

    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        [Display(Name = "First Name")]
        public string First_Name {get;set;}
        [Required]
        [Display(Name = "Last Name")]
        public string Last_Name {get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [DataType(DataType.Password)]
        public string Password {get;set;}
        public List<Message> PostedMessages {get;set;}
        public List<Comment> PostedComments {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }

}