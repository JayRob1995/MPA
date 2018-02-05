using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectDataLayer;

namespace MainProjectWeb
{
    public partial class DeckSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataConnector dc = new DataConnector(@"U:\\College\HND\MPA2\Weiss.accdb");
        }

        // bool SearchInput = false;

        protected void Button1_Click(object sender, EventArgs e)
        {
            String SQLSearch = "SELECT * FROM Tbl_Cards WHERE (";
            bool SearchInput = false;
            if (txtCardID.Text != "")
            {
                SQLSearch = SQLSearch + "Card_ID = '" + txtCardID.Text + "' and ";
                SearchInput = true;
            }
            if (txtCardName.Text != "")
            {
                SQLSearch = SQLSearch + "Card_Name = '" + txtCardName.Text + "' and ";
                SearchInput = true;
            }
            if (dpdnCardType.Text != "")
            {
                SQLSearch = SQLSearch + "Card_Type = '" + dpdnCardType.Text + "' and ";
                SearchInput = true;
            }
            if (dpdnLevel.Text != "")
            {
                SQLSearch = SQLSearch + "Level = '" + dpdnLevel.Text + "' and ";
                SearchInput = true;
            }
            if (txtCost.Text != "")
            {
                SQLSearch = SQLSearch + "Cost = '" + txtCost.Text + "' and ";
                SearchInput = true;
            }
            if (dpdnColor.Text != "")
            {
                SQLSearch = SQLSearch + "Color = '" + dpdnColor.Text + "' and ";
                SearchInput = true;
            }
            if (dpdnTrigger1.Text != "")
            {
                SQLSearch = SQLSearch + "Trigger_1'" + dpdnTrigger1.Text + "' and ";
                SearchInput = true;
            }
            if (dpdnTrigger2.Text != "")
            {
                SQLSearch = SQLSearch + "Trigger_2'" + dpdnTrigger2.Text + "' and ";
                SearchInput = true;
            }
            if (txtSoul.Text != "")
            {
                SQLSearch = SQLSearch + "Soul'" + txtSoul.Text + "' and ";
                SearchInput = true;
            }
            if (dpdnSide.Text != "")
            {
                SQLSearch = SQLSearch + "Side'" + dpdnSide.Text + "' and ";
                SearchInput = true;
            }
            if (dpdnFranchise.Text != "")
            {
                SQLSearch = SQLSearch + "Franchise'" + dpdnFranchise.Text + "' and ";
                SearchInput = true;
            }
            if (txtSpecialAttribute1.Text != "")
            {
                SQLSearch = SQLSearch + "Special_Attribute_1'" + txtSpecialAttribute1.Text + "' and ";
                SearchInput = true;
            }
            if (txtSpecialAttribute2.Text != "")
            {
                SQLSearch = SQLSearch + "Special_Attribute_2'" + txtSpecialAttribute2.Text + "' and ";
                SearchInput = true;
            }
            txtDebug.Text = SQLSearch;
            // if bool = true remove the "and" from end

            // adds end part of SQL

            DataConnector dc = new DataConnector(@"U:\\College\HND\MPA2\Weiss.accdb");
            //dc.DataSelect(SQLSearch);
        }
    }
}