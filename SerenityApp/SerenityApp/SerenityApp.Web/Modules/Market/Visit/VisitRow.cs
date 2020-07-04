
namespace SerenityApp.Market.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Market"), Module("Market"), TableName("[dbo].[visit]")]
    [DisplayName("Visit"), InstanceName("Visit")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class VisitRow : Row, IIdRow, INameRow
    {
        [DisplayName("Visit Id"), Column("visit_id"), Identity]
        public Int32? VisitId
        {
            get { return Fields.VisitId[this]; }
            set { Fields.VisitId[this] = value; }
        }

        [DisplayName("First Name"), Column("first_name"), Size(50), NotNull, QuickSearch]
        public String FirstName
        {
            get { return Fields.FirstName[this]; }
            set { Fields.FirstName[this] = value; }
        }

        [DisplayName("Last Name"), Column("last_name"), Size(50), NotNull]
        public String LastName
        {
            get { return Fields.LastName[this]; }
            set { Fields.LastName[this] = value; }
        }

        [DisplayName("Visited At"), Column("visited_at")]
        public DateTime? VisitedAt
        {
            get { return Fields.VisitedAt[this]; }
            set { Fields.VisitedAt[this] = value; }
        }

        [DisplayName("Phone"), Column("phone"), Size(20)]
        public String Phone
        {
            get { return Fields.Phone[this]; }
            set { Fields.Phone[this] = value; }
        }

        [DisplayName("Store"), Column("store_id"), NotNull, ForeignKey("[dbo].[store]", "store_id"), LeftJoin("jStore"), TextualField("StoreName")]
        public Int32? StoreId
        {
            get { return Fields.StoreId[this]; }
            set { Fields.StoreId[this] = value; }
        }

        [DisplayName("Store Name"), Expression("jStore.[store_name]")]
        public String StoreName
        {
            get { return Fields.StoreName[this]; }
            set { Fields.StoreName[this] = value; }
        }

        [DisplayName("Store Address"), Expression("jStore.[store_address]")]
        public String StoreAddress
        {
            get { return Fields.StoreAddress[this]; }
            set { Fields.StoreAddress[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.VisitId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.FirstName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VisitRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field VisitId;
            public StringField FirstName;
            public StringField LastName;
            public DateTimeField VisitedAt;
            public StringField Phone;
            public Int32Field StoreId;

            public StringField StoreName;
            public StringField StoreAddress;
        }
    }
}
