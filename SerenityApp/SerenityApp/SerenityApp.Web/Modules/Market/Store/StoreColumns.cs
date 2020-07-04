
namespace SerenityApp.Market.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Market.Store")]
    [BasedOnRow(typeof(Entities.StoreRow), CheckNames = true)]
    public class StoreColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String Name { get; set; }
        public String Address { get; set; }
    }
}