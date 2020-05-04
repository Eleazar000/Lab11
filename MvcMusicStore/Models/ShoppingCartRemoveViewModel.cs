using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class ShoppingCartRemoveViewModel
    {
        public int DeleteId;

        public decimal CartTotal;

        public int CountItem;

        public string Message;
    }
}