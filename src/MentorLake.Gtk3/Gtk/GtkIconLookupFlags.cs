namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used to specify options for gtk_icon_theme_lookup_icon()
/// </para>
/// </summary>

[Flags]
public enum GtkIconLookupFlags : uint
{
/// <summary>
/// <para>
/// Never get SVG icons, even if gdk-pixbuf
///   supports them. Cannot be used together with %GTK_ICON_LOOKUP_FORCE_SVG.
/// </para>
/// </summary>

	GTK_ICON_LOOKUP_NO_SVG = 1,
/// <summary>
/// <para>
/// Get SVG icons, even if gdk-pixbuf
///   doesn’t support them.
///   Cannot be used together with %GTK_ICON_LOOKUP_NO_SVG.
/// </para>
/// </summary>

	GTK_ICON_LOOKUP_FORCE_SVG = 2,
/// <summary>
/// <para>
/// When passed to
///   gtk_icon_theme_lookup_icon() includes builtin icons
///   as well as files. For a builtin icon, gtk_icon_info_get_filename()
///   is %NULL and you need to call gtk_icon_info_get_builtin_pixbuf().
/// </para>
/// </summary>

	GTK_ICON_LOOKUP_USE_BUILTIN = 4,
/// <summary>
/// <para>
/// Try to shorten icon name at &apos;-&apos;
///   characters before looking at inherited themes. This flag is only
///   supported in functions that take a single icon name. For more general
///   fallback, see gtk_icon_theme_choose_icon(). Since 2.12.
/// </para>
/// </summary>

	GTK_ICON_LOOKUP_GENERIC_FALLBACK = 8,
/// <summary>
/// <para>
/// Always get the icon scaled to the
///   requested size. Since 2.14.
/// </para>
/// </summary>

	GTK_ICON_LOOKUP_FORCE_SIZE = 16,
/// <summary>
/// <para>
/// Try to always load regular icons, even
///   when symbolic icon names are given. Since 3.14.
/// </para>
/// </summary>

	GTK_ICON_LOOKUP_FORCE_REGULAR = 32,
/// <summary>
/// <para>
/// Try to always load symbolic icons, even
///   when regular icon names are given. Since 3.14.
/// </para>
/// </summary>

	GTK_ICON_LOOKUP_FORCE_SYMBOLIC = 64,
/// <summary>
/// <para>
/// Try to load a variant of the icon for left-to-right
///   text direction. Since 3.14.
/// </para>
/// </summary>

	GTK_ICON_LOOKUP_DIR_LTR = 128,
/// <summary>
/// <para>
/// Try to load a variant of the icon for right-to-left
///   text direction. Since 3.14.
/// </para>
/// </summary>

	GTK_ICON_LOOKUP_DIR_RTL = 256
}
