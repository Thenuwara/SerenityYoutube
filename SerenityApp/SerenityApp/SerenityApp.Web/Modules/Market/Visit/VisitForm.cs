
namespace SerenityApp.Market.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Market.Visit")]
    [BasedOnRow(typeof(Entities.VisitRow), CheckNames = true)]
    public class VisitForm
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime VisitedAt { get; set; }
        public String Phone { get; set; }
        public Int32 StoreId { get; set; }
    }
}