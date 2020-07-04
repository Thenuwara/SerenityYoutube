
namespace SerenityApp.Market.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Market.Visit")]
    [BasedOnRow(typeof(Entities.VisitRow), CheckNames = true)]
    public class VisitColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 VisitId { get; set; }
        [EditLink]
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime VisitedAt { get; set; }
        public String Phone { get; set; }
        public String StoreName { get; set; }
    }
}