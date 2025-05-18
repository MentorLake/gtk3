namespace MentorLake.PangoCairo;

public interface PangoCairoFontHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class PangoCairoFontHandleImpl : BaseSafeHandle, PangoCairoFontHandle
{
}

public static class PangoCairoFontHandleExtensions
{
	public static MentorLake.cairo.cairo_scaled_font_tHandle GetScaledFont(this MentorLake.PangoCairo.PangoCairoFontHandle font)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoCairoFontHandle)");
		return PangoCairoFontHandleExterns.pango_cairo_font_get_scaled_font(font);
	}

}

internal class PangoCairoFontHandleExterns
{
	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))]
	internal static extern MentorLake.cairo.cairo_scaled_font_tHandle pango_cairo_font_get_scaled_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoCairo.PangoCairoFontHandleImpl>))] MentorLake.PangoCairo.PangoCairoFontHandle font);

}
