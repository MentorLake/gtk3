namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoFontset` represents a set of `PangoFont` to use when rendering text.
/// </para>
/// <para>
/// A `PangoFontset` is the result of resolving a `PangoFontDescription`
/// against a particular `PangoContext`. It has operations for finding the
/// component font for a particular Unicode character, and for finding a
/// composite set of metrics for the entire fontset.
/// </para>
/// </summary>

public class PangoFontsetHandle : GObjectHandle
{
}

public static class PangoFontsetHandleExtensions
{
/// <summary>
/// <para>
/// Iterates through all the fonts in a fontset, calling @func for
/// each one.
/// </para>
/// <para>
/// If @func returns %TRUE, that stops the iteration.
/// </para>
/// </summary>

/// <param name="fontset">
/// a `PangoFontset`
/// </param>
/// <param name="func">
/// Callback function
/// </param>
/// <param name="data">
/// data to pass to the callback function
/// </param>

	public static T Foreach<T>(this T fontset, MentorLake.Pango.PangoFontsetForeachFunc func, IntPtr data) where T : PangoFontsetHandle
	{
		if (fontset.IsInvalid) throw new Exception("Invalid handle (PangoFontsetHandle)");
		PangoFontsetHandleExterns.pango_fontset_foreach(fontset, func, data);
		return fontset;
	}

/// <summary>
/// <para>
/// Returns the font in the fontset that contains the best
/// glyph for a Unicode character.
/// </para>
/// </summary>

/// <param name="fontset">
/// a `PangoFontset`
/// </param>
/// <param name="wc">
/// a Unicode character
/// </param>
/// <return>
/// a `PangoFont`
/// </return>

	public static MentorLake.Pango.PangoFontHandle GetFont(this MentorLake.Pango.PangoFontsetHandle fontset, uint wc)
	{
		if (fontset.IsInvalid) throw new Exception("Invalid handle (PangoFontsetHandle)");
		return PangoFontsetHandleExterns.pango_fontset_get_font(fontset, wc);
	}

/// <summary>
/// <para>
/// Get overall metric information for the fonts in the fontset.
/// </para>
/// </summary>

/// <param name="fontset">
/// a `PangoFontset`
/// </param>
/// <return>
/// a `PangoFontMetrics` object
/// </return>

	public static MentorLake.Pango.PangoFontMetricsHandle GetMetrics(this MentorLake.Pango.PangoFontsetHandle fontset)
	{
		if (fontset.IsInvalid) throw new Exception("Invalid handle (PangoFontsetHandle)");
		return PangoFontsetHandleExterns.pango_fontset_get_metrics(fontset);
	}

}

internal class PangoFontsetHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_fontset_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontsetHandle>))] MentorLake.Pango.PangoFontsetHandle fontset, MentorLake.Pango.PangoFontsetForeachFunc func, IntPtr data);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))]
	internal static extern MentorLake.Pango.PangoFontHandle pango_fontset_get_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontsetHandle>))] MentorLake.Pango.PangoFontsetHandle fontset, uint wc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))]
	internal static extern MentorLake.Pango.PangoFontMetricsHandle pango_fontset_get_metrics([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontsetHandle>))] MentorLake.Pango.PangoFontsetHandle fontset);

}
