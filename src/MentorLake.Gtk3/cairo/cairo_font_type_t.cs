namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_font_type_t is used to describe the type of a given font
/// face or scaled font. The font types are also known as &quot;font
/// backends&quot; within cairo.
/// </para>
/// <para>
/// The type of a font face is determined by the function used to
/// create it, which will generally be of the form
/// &amp;lt;function&amp;gt;cairo_&amp;lt;emphasis&amp;gt;type&amp;lt;/emphasis&amp;gt;_font_face_create(&amp;lt;!-- --&amp;gt;)&amp;lt;/function&amp;gt;.
/// The font face type can be queried with cairo_font_face_get_type()
/// </para>
/// <para>
/// The various #cairo_font_face_t functions can be used with a font face
/// of any type.
/// </para>
/// <para>
/// The type of a scaled font is determined by the type of the font
/// face passed to cairo_scaled_font_create(). The scaled font type can
/// be queried with cairo_scaled_font_get_type()
/// </para>
/// <para>
/// The various #cairo_scaled_font_t functions can be used with scaled
/// fonts of any type, but some font backends also provide
/// type-specific functions that must only be called with a scaled font
/// of the appropriate type. These functions have names that begin with
/// &amp;lt;function&amp;gt;cairo_&amp;lt;emphasis&amp;gt;type&amp;lt;/emphasis&amp;gt;_scaled_font(&amp;lt;!-- --&amp;gt;)&amp;lt;/function&amp;gt;
/// such as cairo_ft_scaled_font_lock_face().
/// </para>
/// <para>
/// The behavior of calling a type-specific function with a scaled font
/// of the wrong type is undefined.
/// </para>
/// <para>
/// New entries may be added in future versions.
/// </para>
/// </summary>

[Flags]
public enum cairo_font_type_t
{
/// <summary>
/// <para>
/// The font was created using cairo&apos;s toy font api (Since: 1.2)
/// </para>
/// </summary>

	CAIRO_FONT_TYPE_TOY = 0,
/// <summary>
/// <para>
/// The font is of type FreeType (Since: 1.2)
/// </para>
/// </summary>

	CAIRO_FONT_TYPE_FT = 1,
/// <summary>
/// <para>
/// The font is of type Win32 (Since: 1.2)
/// </para>
/// </summary>

	CAIRO_FONT_TYPE_WIN32 = 2,
/// <summary>
/// <para>
/// The font is of type Quartz (Since: 1.6, in 1.2 and
/// 1.4 it was named CAIRO_FONT_TYPE_ATSUI)
/// </para>
/// </summary>

	CAIRO_FONT_TYPE_QUARTZ = 3,
/// <summary>
/// <para>
/// The font was create using cairo&apos;s user font api (Since: 1.8)
/// </para>
/// </summary>

	CAIRO_FONT_TYPE_USER = 4
}
