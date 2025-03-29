namespace MentorLake.PangoXft;

public class PangoXftFontHandle : PangoFcFontHandle
{
	public static MentorLake.xft.XftFontHandle GetFont(MentorLake.Pango.PangoFontHandle font)
	{
		return PangoXftFontHandleExterns.pango_xft_font_get_font(font);
	}

}

public static class PangoXftFontHandleExtensions
{
	public static MentorLake.xlib.DisplayHandle GetDisplay(this MentorLake.PangoXft.PangoXftFontHandle font)
	{
		if (font.IsInvalid || font.IsClosed) throw new Exception("Invalid or closed handle (PangoXftFontHandle)");
		return PangoXftFontHandleExterns.pango_xft_font_get_display(font);
	}

	public static uint GetGlyph(this MentorLake.PangoXft.PangoXftFontHandle font, char wc)
	{
		if (font.IsInvalid || font.IsClosed) throw new Exception("Invalid or closed handle (PangoXftFontHandle)");
		return PangoXftFontHandleExterns.pango_xft_font_get_glyph(font, wc);
	}

	public static MentorLake.Pango.PangoGlyph GetUnknownGlyph(this MentorLake.PangoXft.PangoXftFontHandle font, char wc)
	{
		if (font.IsInvalid || font.IsClosed) throw new Exception("Invalid or closed handle (PangoXftFontHandle)");
		return PangoXftFontHandleExterns.pango_xft_font_get_unknown_glyph(font, wc);
	}

	public static bool HasChar(this MentorLake.PangoXft.PangoXftFontHandle font, char wc)
	{
		if (font.IsInvalid || font.IsClosed) throw new Exception("Invalid or closed handle (PangoXftFontHandle)");
		return PangoXftFontHandleExterns.pango_xft_font_has_char(font, wc);
	}

	public static MentorLake.freetype2.FT_Face LockFace(this MentorLake.PangoXft.PangoXftFontHandle font)
	{
		if (font.IsInvalid || font.IsClosed) throw new Exception("Invalid or closed handle (PangoXftFontHandle)");
		return PangoXftFontHandleExterns.pango_xft_font_lock_face(font);
	}

	public static T UnlockFace<T>(this T font) where T : PangoXftFontHandle
	{
		if (font.IsInvalid || font.IsClosed) throw new Exception("Invalid or closed handle (PangoXftFontHandle)");
		PangoXftFontHandleExterns.pango_xft_font_unlock_face(font);
		return font;
	}

}

internal class PangoXftFontHandleExterns
{
	[DllImport(PangoXftLibrary.Name)]
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
	internal static extern MentorLake.xft.XftFontHandle pango_xft_font_get_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

}
