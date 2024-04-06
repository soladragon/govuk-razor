using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WebApplication2.Pages
{


    public class TestModel : PageModel
    {
        public List<Tab> Tabs { get; set; }

        public void OnGet()
        {
            Tabs = new List<Tab>
            {
                new Tab
                {
                    Id = "past-day",
                    Title = "Past day",
                    Headers = new List<string> { "Case manager", "Cases opened", "Cases closed" },
                    Rows = new List<Row>
                    {
                        new Row { Cells = new List<string> { "David Francis", "3", "0" } },
                        new Row { Cells = new List<string> { "Paul Farmer", "1", "0" } },
                        new Row { Cells = new List<string> { "Rita Patel", "2", "0" } },
                        new Row { Cells = new List<string> { "David Francis", "3", "0" } },
                        new Row { Cells = new List<string> { "Paul Farmer", "1", "0" } },
                        new Row { Cells = new List<string> { "Rita Patel", "2", "0" } }
                    }
                },
                new Tab
                {
                    Id = "past-week",
                    Title = "Past week",
                    Headers = new List<string> { "Case manager", "Cases opened", "Cases closed" },
                    Rows = new List<Row>
                    {
                        new Row { Cells = new List<string> { "David Francis", "24", "18" } },
                        new Row { Cells = new List<string> { "Paul Farmer", "16", "20" } },
                        new Row { Cells = new List<string> { "Rita Patel", "24", "27" } }
                    }
                },
                // Add more tabs as needed
            };
        }
    }

    public class Tab
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<string> Headers { get; set; }
        public List<Row> Rows { get; set; }
    }

    public class Row
    {
        public List<string> Cells { get; set; }
    }
}



//{
//    "Tabs": [
//      {
//        "Id": "past-day",
//      "Title": "Past day",
//      "Headers": ["Case manager", "Cases opened", "Cases closed"],
//      "Rows": [
//        { "Cells": ["David Francis", "3", "0"] },
//        { "Cells": ["Paul Farmer", "1", "0"] },
//        { "Cells": ["Rita Patel", "2", "0"] }
//      ]
//    },
//    {
//        "Id": "past-week",
//      "Title": "Past week",
//      "Headers": ["Case manager", "Cases opened", "Cases closed"],
//      "Rows": [
//        { "Cells": ["David Francis", "24", "18"] },
//        { "Cells": ["Paul Farmer", "16", "20"] },
//        { "Cells": ["Rita Patel", "24", "27"] }
//      ]
//    }
//  ]
//}


//using Microsoft.AspNetCore.Mvc.RazorPages;

//namespace WebApplication2.Pages
//{
//    public class TestModel : PageModel
//    {
//        public void OnGet()
//        {
//            var headers = new string[] { "Case ID", "Case manager", "Cases opened", "Cases closed" };

//            var rows = new object[]
//            {
//                new { Cells = new string[] { "1", "David Francis", "3", "0" } },
//                new { Cells = new string[] { "2", "Paul Farmer", "1", "0" } },
//                new { Cells = new string[] { "3", "Rita Patel", "2", "0" } }
//            };

//            var tabTitles = new[] { "Cases", "Tasks", "Incidents" };

//            // Assigning data to the model
//            Headers = headers;
//            Rows = rows;
//            TabTitles = tabTitles;
//        }

//        public string[] Headers { get; private set; }
//        public object[] Rows { get; private set; }
//        public string[] TabTitles { get; private set; }
//    }
//}
