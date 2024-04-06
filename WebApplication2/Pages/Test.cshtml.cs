using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class TestModel : PageModel
    {
        public string SelectedTab { get; set; } = "past-day"; // Default selected tab
        public string TabTitle { get; set; } = "Past day"; // Default tab title

        public List<TableRow> TableContent { get; set; } = new List<TableRow>();

        public void OnGet(string tab)
        {
            if (!string.IsNullOrEmpty(tab) && (tab == "past-day" || tab == "past-week" || tab == "past-month" || tab == "past-year"))
            {
                SelectedTab = tab;
                SetTabContent();
            }
        }

        private void SetTabContent()
        {
            // Clear previous content
            TableContent.Clear();

            // Set content based on selected tab
            if (SelectedTab == "past-day")
            {
                TabTitle = "Past day";
                TableContent.Add(new TableRow { CaseManager = "David Francis", CasesOpened = 3, CasesClosed = 0 });
                TableContent.Add(new TableRow { CaseManager = "Paul Farmer", CasesOpened = 1, CasesClosed = 0 });
                TableContent.Add(new TableRow { CaseManager = "Rita Patel", CasesOpened = 2, CasesClosed = 0 });
            }
            else if (SelectedTab == "past-week")
            {
                TabTitle = "Past week";
                TableContent.Add(new TableRow { CaseManager = "David Francis", CasesOpened = 24, CasesClosed = 18 });
                TableContent.Add(new TableRow { CaseManager = "Paul Farmer", CasesOpened = 16, CasesClosed = 20 });
                TableContent.Add(new TableRow { CaseManager = "Rita Patel", CasesOpened = 24, CasesClosed = 27 });
            }
            else if (SelectedTab == "past-month")
            {
                TabTitle = "Past month";
                TableContent.Add(new TableRow { CaseManager = "David Francis", CasesOpened = 98, CasesClosed = 95 });
                TableContent.Add(new TableRow { CaseManager = "Paul Farmer", CasesOpened = 122, CasesClosed = 131 });
                TableContent.Add(new TableRow { CaseManager = "Rita Patel", CasesOpened = 126, CasesClosed = 142 });
            }
            else if (SelectedTab == "past-year")
            {
                TabTitle = "Past year";
                TableContent.Add(new TableRow { CaseManager = "David Francis", CasesOpened = 1380, CasesClosed = 1472 });
                TableContent.Add(new TableRow { CaseManager = "Paul Farmer", CasesOpened = 1129, CasesClosed = 1083 });
                TableContent.Add(new TableRow { CaseManager = "Rita Patel", CasesOpened = 1539, CasesClosed = 1265 });
            }
        }
    }

    public class TableRow
    {
        public string CaseManager { get; set; }
        public int CasesOpened { get; set; }
        public int CasesClosed { get; set; }
    }
}
