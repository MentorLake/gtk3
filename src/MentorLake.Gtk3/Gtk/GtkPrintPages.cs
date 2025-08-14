namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// See also gtk_print_job_set_pages()
/// </para>
/// </summary>

[Flags]
public enum GtkPrintPages
{
/// <summary>
/// <para>
/// All pages.
/// </para>
/// </summary>

	GTK_PRINT_PAGES_ALL = 0,
/// <summary>
/// <para>
/// Current page.
/// </para>
/// </summary>

	GTK_PRINT_PAGES_CURRENT = 1,
/// <summary>
/// <para>
/// Range of pages.
/// </para>
/// </summary>

	GTK_PRINT_PAGES_RANGES = 2,
/// <summary>
/// <para>
/// Selected pages.
/// </para>
/// </summary>

	GTK_PRINT_PAGES_SELECTION = 3
}
