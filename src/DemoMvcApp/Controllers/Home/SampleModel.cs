using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DemoMvcApp.Controllers.Home
{
    public class SampleModel
    {
        public static SampleModel Create()
        {
            return new SampleModel
            {
                Boolean = true,
                EmailAddress = "admin@contoso.com",
                Decimal = 21.1234M,
                Int = 42,
                UInt = 48,
                Byte = 100,
                SByte = 3,
                Long = 12344,
                ULong = 12312,
                Float = 3.2143234234F,
                Hidden = "Uneditable",
                HiddenAndInvisible = "Also uneditable",
                Html = "This is <b>HTML</b> enabled",
                MultilineText = "This\r\nhas\r\nmultiple\r\nlines",
                NullableBoolean = null,
                Password = "supersecret",
                String = "A simple string",
                EmptyString = "",
                NullString = null,
                Text = "Some text",
                Url = "http://www.microsoft.com/",
                NullUrl = null,
                PhoneNumber = "07774 123456",
                Date = new DateTime(2013, 1, 1),
                DateTime = new DateTime(2013, 1, 1, 12, 30, 0),
                Time = new DateTime(2012, 1, 1, 12, 33, 34)
            };
        }

        public bool Boolean { get; set; }
        
        public decimal Decimal { get; set; }

        [HiddenInput]
        public string Hidden { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string HiddenAndInvisible { get; set; }

        [DataType(DataType.Html)]
        public string Html { get; set; }

        [Required]
        [Range(10, 100)]
        public int Int { get; set; }

        [Required]
        [Range(10, 100)]
        public uint UInt { get; set; }

        public byte Byte { get; set; }

        public sbyte SByte { get; set; }

        public long Long { get; set; }

        public ulong ULong { get; set; }

        public float Float { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string MultilineText { get; set; }

        public bool? NullableBoolean { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string String { get; set; }

        public string EmptyString { get; set; }

        public string NullString { get; set; }

        [DataType(DataType.Text)]
        public string Text { get; set; }

        [DataType(DataType.Url)]
        public string Url { get; set; }

        [DataType(DataType.Url)]
        [DisplayFormat(NullDisplayText = "(no url set)")]
        public string NullUrl { get; set; }
        
        [DisplayFormat(NullDisplayText = "(null value)")]
        public ChildModel ChildModel { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
    }
}