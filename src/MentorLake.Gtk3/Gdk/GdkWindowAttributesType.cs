namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Used to indicate which fields in the #GdkWindowAttr struct should be honored.
/// For example, if you filled in the “cursor” and “x” fields of #GdkWindowAttr,
/// pass “@GDK_WA_X | @GDK_WA_CURSOR” to gdk_window_new(). Fields in
/// #GdkWindowAttr not covered by a bit in this enum are required; for example,
/// the @width/@height, @wclass, and @window_type fields are required, they have
/// no corresponding flag in #GdkWindowAttributesType.
/// </para>
/// </summary>

[Flags]
public enum GdkWindowAttributesType : uint
{
/// <summary>
/// <para>
/// Honor the title field
/// </para>
/// </summary>

	GDK_WA_TITLE = 2,
/// <summary>
/// <para>
/// Honor the X coordinate field
/// </para>
/// </summary>

	GDK_WA_X = 4,
/// <summary>
/// <para>
/// Honor the Y coordinate field
/// </para>
/// </summary>

	GDK_WA_Y = 8,
/// <summary>
/// <para>
/// Honor the cursor field
/// </para>
/// </summary>

	GDK_WA_CURSOR = 16,
/// <summary>
/// <para>
/// Honor the visual field
/// </para>
/// </summary>

	GDK_WA_VISUAL = 32,
/// <summary>
/// <para>
/// Honor the wmclass_class and wmclass_name fields
/// </para>
/// </summary>

	GDK_WA_WMCLASS = 64,
/// <summary>
/// <para>
/// Honor the override_redirect field
/// </para>
/// </summary>

	GDK_WA_NOREDIR = 128,
/// <summary>
/// <para>
/// Honor the type_hint field
/// </para>
/// </summary>

	GDK_WA_TYPE_HINT = 256
}
