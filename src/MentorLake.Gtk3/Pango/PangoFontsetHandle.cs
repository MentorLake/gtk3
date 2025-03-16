namespace MentorLake.Pango;

public class PangoFontsetHandle : GObjectHandle
{
}

public static class PangoFontsetHandleExtensions
{
	public static T Foreach<T>(this T fontset, MentorLake.Pango.PangoFontsetForeachFunc func, IntPtr data) where T : PangoFontsetHandle
	{
		PangoFontsetHandleExterns.pango_fontset_foreach(fontset, func, data);
		return fontset;
	}

	public static MentorLake.Pango.PangoFontHandle GetFont(this MentorLake.Pango.PangoFontsetHandle fontset, uint wc)
	{
		return PangoFontsetHandleExterns.pango_fontset_get_font(fontset, wc);
	}

	public static MentorLake.Pango.PangoFontMetricsHandle GetMetrics(this MentorLake.Pango.PangoFontsetHandle fontset)
	{
		return PangoFontsetHandleExterns.pango_fontset_get_metrics(fontset);
	}

}

internal class PangoFontsetHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_fontset_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontsetHandle>))] MentorLake.Pango.PangoFontsetHandle fontset, MentorLake.Pango.PangoFontsetForeachFunc func, IntPtr data);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontHandle pango_fontset_get_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontsetHandle>))] MentorLake.Pango.PangoFontsetHandle fontset, uint wc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontMetricsHandle pango_fontset_get_metrics([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontsetHandle>))] MentorLake.Pango.PangoFontsetHandle fontset);

}
