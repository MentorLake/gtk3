namespace MentorLake.PangoXft;

/// <summary>
/// <para>
/// `PangoXftFont` is an implementation of `PangoFcFont` using the Xft
/// library for rendering.  It is used in conjunction with `PangoXftFontMap`.
/// </para>
/// </summary>

public class PangoXftFontHandle : PangoFcFontHandle
{
/// <summary>
/// <para>
/// Returns the `XftFont` of a font.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <return>
/// the `XftFont` associated to @font
/// </return>

	public static MentorLake.xft.XftFontHandle GetFont(MentorLake.Pango.PangoFontHandle font)
	{
		return PangoXftFontHandleExterns.pango_xft_font_get_font(font);
	}

}

public static class PangoXftFontHandleExtensions
{
/// <summary>
/// <para>
/// Returns the X display of the `XftFont` of a font.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <return>
/// the X display of the XftFont associated to @font.
/// </return>

	public static MentorLake.xlib.DisplayHandle GetDisplay(this MentorLake.PangoXft.PangoXftFontHandle font)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoXftFontHandle)");
		return PangoXftFontHandleExterns.pango_xft_font_get_display(font);
	}

/// <summary>
/// <para>
/// Gets the glyph index for a given Unicode character
/// for @font.
/// </para>
/// <para>
/// If you only want to determine whether the font has
/// the glyph, use pango_xft_font_has_char().
/// </para>
/// <para>
/// Use pango_fc_font_get_glyph() instead.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont` for the Xft backend
/// </param>
/// <param name="wc">
/// Unicode codepoint to look up
/// </param>
/// <return>
/// the glyph index, or 0, if the Unicode
///  character does not exist in the font.
/// </return>

	public static uint GetGlyph(this MentorLake.PangoXft.PangoXftFontHandle font, char wc)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoXftFontHandle)");
		return PangoXftFontHandleExterns.pango_xft_font_get_glyph(font, wc);
	}

/// <summary>
/// <para>
/// Returns the index of a glyph suitable for drawing @wc as an
/// unknown character.
/// </para>
/// <para>
/// Use PANGO_GET_UNKNOWN_GLYPH() instead.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <param name="wc">
/// the Unicode character for which a glyph is needed.
/// </param>
/// <return>
/// a glyph index into @font.
/// </return>

	public static MentorLake.Pango.PangoGlyph GetUnknownGlyph(this MentorLake.PangoXft.PangoXftFontHandle font, char wc)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoXftFontHandle)");
		return PangoXftFontHandleExterns.pango_xft_font_get_unknown_glyph(font, wc);
	}

/// <summary>
/// <para>
/// Determines whether @font has a glyph for the codepoint @wc.
/// </para>
/// <para>
/// Use pango_fc_font_has_char() instead.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont` for the Xft backend
/// </param>
/// <param name="wc">
/// Unicode codepoint to look up
/// </param>
/// <return>
/// %TRUE if @font has the requested codepoint.
/// </return>

	public static bool HasChar(this MentorLake.PangoXft.PangoXftFontHandle font, char wc)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoXftFontHandle)");
		return PangoXftFontHandleExterns.pango_xft_font_has_char(font, wc);
	}

/// <summary>
/// <para>
/// Gets the FreeType `FT_Face` associated with a font.
/// </para>
/// <para>
/// This face will be kept around until you call pango_xft_font_unlock_face().
/// </para>
/// <para>
/// Use pango_fc_font_lock_face() instead.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <return>
/// the FreeType `FT_Face` associated with @font.
/// </return>

	public static MentorLake.freetype2.FT_Face LockFace(this MentorLake.PangoXft.PangoXftFontHandle font)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoXftFontHandle)");
		return PangoXftFontHandleExterns.pango_xft_font_lock_face(font);
	}

/// <summary>
/// <para>
/// Releases a font previously obtained with
/// pango_xft_font_lock_face().
/// </para>
/// <para>
/// Use pango_fc_font_unlock_face() instead.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>

	public static T UnlockFace<T>(this T font) where T : PangoXftFontHandle
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoXftFontHandle)");
		PangoXftFontHandleExterns.pango_xft_font_unlock_face(font);
		return font;
	}

}

internal class PangoXftFontHandleExterns
{
	[DllImport(PangoXftLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.DisplayHandle>))]
	internal static extern MentorLake.xlib.DisplayHandle pango_xft_font_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoXft.PangoXftFontHandle>))] MentorLake.PangoXft.PangoXftFontHandle font);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern uint pango_xft_font_get_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoXft.PangoXftFontHandle>))] MentorLake.PangoXft.PangoXftFontHandle font, char wc);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGlyph pango_xft_font_get_unknown_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoXft.PangoXftFontHandle>))] MentorLake.PangoXft.PangoXftFontHandle font, char wc);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern bool pango_xft_font_has_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoXft.PangoXftFontHandle>))] MentorLake.PangoXft.PangoXftFontHandle font, char wc);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern MentorLake.freetype2.FT_Face pango_xft_font_lock_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoXft.PangoXftFontHandle>))] MentorLake.PangoXft.PangoXftFontHandle font);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern void pango_xft_font_unlock_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoXft.PangoXftFontHandle>))] MentorLake.PangoXft.PangoXftFontHandle font);

	[DllImport(PangoXftLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xft.XftFontHandle>))]
	internal static extern MentorLake.xft.XftFontHandle pango_xft_font_get_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

}
