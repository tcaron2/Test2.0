using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
#region Additional Namespaces
using eRestaurantSystem.BLL;
using eRestaurantSystem.Entities;
using  EatIn.UI;
#endregion

public partial class DemoPages_WaiterCRUD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HiredDate.Text = DateTime.Today.ToShortDateString();
    }

    protected void FetchWaiter_Click(object sender, EventArgs e)
    {

    }
    public void GetWaiterInfo()
    {

    }
    protected void HiredDateCalendarButton_Click(object sender, ImageClickEventArgs e)
    {
        HiredCalendar.Visible = true;
        HiredCalendar.SelectedDate = DateTime.Today;
    }
    protected void ReleaseDateCalendarButton_Click(object sender, ImageClickEventArgs e)
    {
        ReleaseCalendar.Visible = true;
        if (string.IsNullOrEmpty(ReleaseDate.Text))
        {
            ReleaseCalendar.SelectedDate = DateTime.Today;
        }
        else
        {
            ReleaseCalendar.SelectedDate = DateTime.Parse(ReleaseDate.Text);
        }
    }
    protected void HiredCalendar_SelectionChanged(object sender, EventArgs e)
    {
        HiredDate.Text = HiredCalendar.SelectedDate.ToShortDateString();
        HiredCalendar.Visible = false;
    }
    protected void ReleaseCalendar_SelectionChanged(object sender, EventArgs e)
    {
        ReleaseDate.Text = ReleaseCalendar.SelectedDate.ToShortDateString();
        ReleaseCalendar.Visible = false;
    }
    protected void InsertWaiter_Click(object sender, EventArgs e)
    {

    }
    public void InsertWaiterInfo()
    {

    }
    protected void UpdateWaiter_Click(object sender, EventArgs e)
    {

    }
}