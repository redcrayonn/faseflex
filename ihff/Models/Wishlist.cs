﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ihff.Models
{
    public class Wishlist
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Voor uw email in a.u.b.")]
        [EmailAddress]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Geef a.u.b. een correct e-mail adres op.")]
        [Display(Name = "E-mail adres")]
        public string email { get; set; }
        public bool paid { get; set; }

        public List<WishlistItem> wishlistItems = new List<WishlistItem>();

        public Wishlist()
        {

        }

        public Wishlist(string email, bool paid)
        {
            
            this.email = email;
            this.paid = paid;
        }
    }
}