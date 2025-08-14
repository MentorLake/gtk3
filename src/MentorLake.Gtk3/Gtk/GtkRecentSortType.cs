namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used to specify the sorting method to be applyed to the recently
/// used resource list.
/// </para>
/// </summary>

[Flags]
public enum GtkRecentSortType
{
/// <summary>
/// <para>
/// Do not sort the returned list of recently used
///   resources.
/// </para>
/// </summary>

	GTK_RECENT_SORT_NONE = 0,
/// <summary>
/// <para>
/// Sort the returned list with the most recently used
///   items first.
/// </para>
/// </summary>

	GTK_RECENT_SORT_MRU = 1,
/// <summary>
/// <para>
/// Sort the returned list with the least recently used
///   items first.
/// </para>
/// </summary>

	GTK_RECENT_SORT_LRU = 2,
/// <summary>
/// <para>
/// Sort the returned list using a custom sorting
///   function passed using gtk_recent_chooser_set_sort_func().
/// </para>
/// </summary>

	GTK_RECENT_SORT_CUSTOM = 3
}
