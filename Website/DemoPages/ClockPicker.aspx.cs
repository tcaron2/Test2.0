using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additional Namespaces
using eRestaurantSystem;
#endregion

public partial class DemoPages_ClockPicker : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void MockLastBillingDateTime_Click(object sender, EventArgs e)
    {
        MessageUserControl.TryRun(SetMockLastBillingDateTime);
    }

    protected void SetMockLastBillingDateTime()
    {
        var controller = new eRestaurantSystem.BLL.eRestaurantController();
        var info = controller.GetLastBillDateTime();
        SearchDate.Text = info.ToString("yyyy-MM-dd");
        SearchTime.Text = info.ToString("HH:mm:ss");

    }
}