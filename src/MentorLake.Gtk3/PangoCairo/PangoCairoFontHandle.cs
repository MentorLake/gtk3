namespace MentorLake.PangoCairo;

/// <summary>
/// <para>
/// `PangoCairoFont` is an interface exported by fonts for
/// use with Cairo.
/// </para>
/// <para>
/// The actual type of the font will depend on the particular
/// font technology Cairo was compiled to use.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Gets the `cairo_scaled_font_t` used by @font.
/// The scaled font can be referenced and kept using
/// cairo_scaled_font_reference().
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont` from a `PangoCairoFontMap`
/// </param>
/// <return>
/// the `cairo_scaled_font_t`
///   used by @font
/// </return>

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
