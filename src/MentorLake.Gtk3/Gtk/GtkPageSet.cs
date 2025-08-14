namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// See also gtk_print_job_set_page_set().
/// </para>
/// </summary>

[Flags]
public enum GtkPageSet
{
/// <summary>
/// <para>
/// All pages.
/// </para>
/// </summary>

	GTK_PAGE_SET_ALL = 0,
/// <summary>
/// <para>
/// Even pages.
/// </para>
/// </summary>

	GTK_PAGE_SET_EVEN = 1,
/// <summary>
/// <para>
/// Odd pages.
/// </para>
/// </summary>

	GTK_PAGE_SET_ODD = 2
}
