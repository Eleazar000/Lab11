﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class ShoppingCartViewModel
    {  
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal;
    }
}