namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used to determine the layout of pages on a sheet when printing
/// multiple pages per sheet.
/// </para>
/// </summary>

[Flags]
public enum GtkNumberUpLayout
{
/// <summary>
/// <para>
/// ![](layout-lrtb.png)
/// </para>
/// </summary>

	GTK_NUMBER_UP_LAYOUT_LEFT_TO_RIGHT_TOP_TO_BOTTOM = 0,
/// <summary>
/// <para>
/// ![](layout-lrbt.png)
/// </para>
/// </summary>

	GTK_NUMBER_UP_LAYOUT_LEFT_TO_RIGHT_BOTTOM_TO_TOP = 1,
/// <summary>
/// <para>
/// ![](layout-rltb.png)
/// </para>
/// </summary>

	GTK_NUMBER_UP_LAYOUT_RIGHT_TO_LEFT_TOP_TO_BOTTOM = 2,
/// <summary>
/// <para>
/// ![](layout-rlbt.png)
/// </para>
/// </summary>

	GTK_NUMBER_UP_LAYOUT_RIGHT_TO_LEFT_BOTTOM_TO_TOP = 3,
/// <summary>
/// <para>
/// ![](layout-tblr.png)
/// </para>
/// </summary>

	GTK_NUMBER_UP_LAYOUT_TOP_TO_BOTTOM_LEFT_TO_RIGHT = 4,
/// <summary>
/// <para>
/// ![](layout-tbrl.png)
/// </para>
/// </summary>

	GTK_NUMBER_UP_LAYOUT_TOP_TO_BOTTOM_RIGHT_TO_LEFT = 5,
/// <summary>
/// <para>
/// ![](layout-btlr.png)
/// </para>
/// </summary>

	GTK_NUMBER_UP_LAYOUT_BOTTOM_TO_TOP_LEFT_TO_RIGHT = 6,
/// <summary>
/// <para>
/// ![](layout-btrl.png)
/// </para>
/// </summary>

	GTK_NUMBER_UP_LAYOUT_BOTTOM_TO_TOP_RIGHT_TO_LEFT = 7
}
