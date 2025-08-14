namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Flags affecting how a search is done.
/// </para>
/// <para>
/// If neither #GTK_TEXT_SEARCH_VISIBLE_ONLY nor #GTK_TEXT_SEARCH_TEXT_ONLY are
/// enabled, the match must be exact; the special 0xFFFC character will match
/// embedded pixbufs or child widgets.
/// </para>
/// </summary>

[Flags]
public enum GtkTextSearchFlags : uint
{
/// <summary>
/// <para>
/// Search only visible data. A search match may
/// have invisible text interspersed.
/// </para>
/// </summary>

	GTK_TEXT_SEARCH_VISIBLE_ONLY = 1,
/// <summary>
/// <para>
/// Search only text. A match may have pixbufs or
/// child widgets mixed inside the matched range.
/// </para>
/// </summary>

	GTK_TEXT_SEARCH_TEXT_ONLY = 2,
/// <summary>
/// <para>
/// The text will be matched regardless of
/// what case it is in.
/// </para>
/// </summary>

	GTK_TEXT_SEARCH_CASE_INSENSITIVE = 4
}
