namespace MentorLake.PangoFT2;

public class PangoFT2FontMapHandle : PangoFcFontMapHandle, GListModelHandle
{
	public static MentorLake.PangoFT2.PangoFT2FontMapHandle New()
	{
		return PangoFT2FontMapHandleExterns.pango_ft2_font_map_new();
	}

	public static MentorLake.Pango.PangoFontMapHandle ForDisplay()
	{
		return PangoFT2FontMapHandleExterns.pango_ft2_font_map_for_display();
	}

}

public static class PangoFT2FontMapHandleExtensions
{
	public static MentorLake.Pango.PangoContextHandle CreateContext(this MentorLake.PangoFT2.PangoFT2FontMapHandle fontmap)
	{
		if (fontmap.IsInvalid || fontmap.IsClosed) throw new Exception("Invalid or closed handle (PangoFT2FontMapHandle)");
		return PangoFT2FontMapHandleExterns.pango_ft2_font_map_create_context(fontmap);
	}

	public static T SetDefaultSubstitute<T>(this T fontmap, MentorLake.PangoFT2.PangoFT2SubstituteFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify) where T : PangoFT2FontMapHandle
	{
		if (fontmap.IsInvalid || fontmap.IsClosed) throw new Exception("Invalid or closed handle (PangoFT2FontMapHandle)");
		PangoFT2FontMapHandleExterns.pango_ft2_font_map_set_default_substitute(fontmap, func, data, notify);
		return fontmap;
	}

	public static T SetResolution<T>(this T fontmap, double dpi_x, double dpi_y) where T : PangoFT2FontMapHandle
	{
		if (fontmap.IsInvalid || fontmap.IsClosed) throw new Exception("Invalid or closed handle (PangoFT2FontMapHandle)");
		PangoFT2FontMapHandleExterns.pango_ft2_font_map_set_resolution(fontmap, dpi_x, dpi_y);
		return fontmap;
	}

	public static T SubstituteChanged<T>(this T fontmap) where T : PangoFT2FontMapHandle
	{
		if (fontmap.IsInvalid || fontmap.IsClosed) throw new Exception("Invalid or closed handle (PangoFT2FontMapHandle)");
		PangoFT2FontMapHandleExterns.pango_ft2_font_map_substitute_changed(fontmap);
		return fontmap;
	}

}

internal class PangoFT2FontMapHandleExterns
{
	[DllImport(PangoFT2Library.Name)]
	internal static extern MentorLake.PangoFT2.PangoFT2FontMapHandle pango_ft2_font_map_new();

	[DllImport(PangoFT2Library.Name)]
	internal static extern MentorLake.Pango.PangoContextHandle pango_ft2_font_map_create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFT2.PangoFT2FontMapHandle>))] MentorLake.PangoFT2.PangoFT2FontMapHandle fontmap);

	[DllImport(PangoFT2Library.Name)]
	internal static extern void pango_ft2_font_map_set_default_substitute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFT2.PangoFT2FontMapHandle>))] MentorLake.PangoFT2.PangoFT2FontMapHandle fontmap, MentorLake.PangoFT2.PangoFT2SubstituteFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(PangoFT2Library.Name)]
	internal static extern void pango_ft2_font_map_set_resolution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFT2.PangoFT2FontMapHandle>))] MentorLake.PangoFT2.PangoFT2FontMapHandle fontmap, double dpi_x, double dpi_y);

	[DllImport(PangoFT2Library.Name)]
	internal static extern void pango_ft2_font_map_substitute_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFT2.PangoFT2FontMapHandle>))] MentorLake.PangoFT2.PangoFT2FontMapHandle fontmap);

	[DllImport(PangoFT2Library.Name)]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_ft2_font_map_for_display();

}
