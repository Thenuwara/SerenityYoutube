
namespace SerenityApp.Market.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Market.Store")]
    [BasedOnRow(typeof(Entities.StoreRow), CheckNames = true)]
    public class StoreForm
    {
        public String Name { get; set; }
        public String Address { get; set; }
    }
}