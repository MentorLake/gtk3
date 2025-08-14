namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoFontMetrics` structure holds the overall metric information
/// for a font.
/// </para>
/// <para>
/// The information in a `PangoFontMetrics` structure may be restricted
/// to a script. The fields of this structure are private to implementations
/// of a font backend. See the documentation of the corresponding getters
/// for documentation of their meaning.
/// </para>
/// <para>
/// For an overview of the most important metrics, see:
/// </para>
/// <para>
/// <picture>
///   <source srcset="fontmetrics-dark.png" media="(prefers-color-scheme: dark)">
///   <img alt="Font metrics" src="fontmetrics-light.png">
/// </picture>
/// </para>
/// </summary>

public class PangoFontMetricsHandle : BaseSafeHandle
{
}


public static class PangoFontMetricsExtensions
{
/// <summary>
/// <para>
/// Gets the approximate character width for a font metrics structure.
/// </para>
/// <para>
/// This is merely a representative value useful, for example, for
/// determining the initial size for a window. Actual characters in
/// text will be wider and narrower than this.
/// </para>
/// </summary>

/// <param name="metrics">
/// a `PangoFontMetrics` structure
/// </param>
/// <return>
/// the character width, in Pango units.
/// </return>

	public static int GetApproximateCharWidth(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_approximate_char_width(metrics);
	}

/// <summary>
/// <para>
/// Gets the approximate digit width for a font metrics structure.
/// </para>
/// <para>
/// This is merely a representative value useful, for example, for
/// determining the initial size for a window. Actual digits in
/// text can be wider or narrower than this, though this value
/// is generally somewhat more accurate than the result of
/// pango_font_metrics_get_approximate_char_width() for digits.
/// </para>
/// </summary>

/// <param name="metrics">
/// a `PangoFontMetrics` structure
/// </param>
/// <return>
/// the digit width, in Pango units.
/// </return>

	public static int GetApproximateDigitWidth(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_approximate_digit_width(metrics);
	}

/// <summary>
/// <para>
/// Gets the ascent from a font metrics structure.
/// </para>
/// <para>
/// The ascent is the distance from the baseline to the logical top
/// of a line of text. (The logical top may be above or below the top
/// of the actual drawn ink. It is necessary to lay out the text to
/// figure where the ink will be.)
/// </para>
/// </summary>

/// <param name="metrics">
/// a `PangoFontMetrics` structure
/// </param>
/// <return>
/// the ascent, in Pango units.
/// </return>

	public static int GetAscent(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_ascent(metrics);
	}

/// <summary>
/// <para>
/// Gets the descent from a font metrics structure.
/// </para>
/// <para>
/// The descent is the distance from the baseline to the logical bottom
/// of a line of text. (The logical bottom may be above or below the
/// bottom of the actual drawn ink. It is necessary to lay out the text
/// to figure where the ink will be.)
/// </para>
/// </summary>

/// <param name="metrics">
/// a `PangoFontMetrics` structure
/// </param>
/// <return>
/// the descent, in Pango units.
/// </return>

	public static int GetDescent(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_descent(metrics);
	}

/// <summary>
/// <para>
/// Gets the line height from a font metrics structure.
/// </para>
/// <para>
/// The line height is the recommended distance between successive
/// baselines in wrapped text using this font.
/// </para>
/// <para>
/// If the line height is not available, 0 is returned.
/// </para>
/// </summary>

/// <param name="metrics">
/// a `PangoFontMetrics` structure
/// </param>
/// <return>
/// the height, in Pango units
/// </return>

	public static int GetHeight(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_height(metrics);
	}

/// <summary>
/// <para>
/// Gets the suggested position to draw the strikethrough.
/// </para>
/// <para>
/// The value returned is the distance *above* the
/// baseline of the top of the strikethrough.
/// </para>
/// </summary>

/// <param name="metrics">
/// a `PangoFontMetrics` structure
/// </param>
/// <return>
/// the suggested strikethrough position, in Pango units.
/// </return>

	public static int GetStrikethroughPosition(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_strikethrough_position(metrics);
	}

/// <summary>
/// <para>
/// Gets the suggested thickness to draw for the strikethrough.
/// </para>
/// </summary>

/// <param name="metrics">
/// a `PangoFontMetrics` structure
/// </param>
/// <return>
/// the suggested strikethrough thickness, in Pango units.
/// </return>

	public static int GetStrikethroughThickness(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_strikethrough_thickness(metrics);
	}

/// <summary>
/// <para>
/// Gets the suggested position to draw the underline.
/// </para>
/// <para>
/// The value returned is the distance *above* the baseline of the top
/// of the underline. Since most fonts have underline positions beneath
/// the baseline, this value is typically negative.
/// </para>
/// </summary>

/// <param name="metrics">
/// a `PangoFontMetrics` structure
/// </param>
/// <return>
/// the suggested underline position, in Pango units.
/// </return>

	public static int GetUnderlinePosition(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_underline_position(metrics);
	}

/// <summary>
/// <para>
/// Gets the suggested thickness to draw for the underline.
/// </para>
/// </summary>

/// <param name="metrics">
/// a `PangoFontMetrics` structure
/// </param>
/// <return>
/// the suggested underline thickness, in Pango units.
/// </return>

	public static int GetUnderlineThickness(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_underline_thickness(metrics);
	}

/// <summary>
/// <para>
/// Increase the reference count of a font metrics structure by one.
/// </para>
/// </summary>

/// <param name="metrics">
/// a `PangoFontMetrics` structure, may be %NULL
/// </param>
/// <return>
/// @metrics
/// </return>

	public static MentorLake.Pango.PangoFontMetricsHandle Ref(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_ref(metrics);
	}

/// <summary>
/// <para>
/// Decrease the reference count of a font metrics structure by one.
/// </para>
/// <para>
/// If the result is zero, frees the structure and any associated memory.
/// </para>
/// </summary>

/// <param name="metrics">
/// a `PangoFontMetrics` structure, may be %NULL
/// </param>

	public static void Unref(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		PangoFontMetricsExterns.pango_font_metrics_unref(metrics);
	}


	public static PangoFontMetrics Dereference(this PangoFontMetricsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFontMetrics>(x.DangerousGetHandle());
}
internal class PangoFontMetricsExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_font_metrics_get_approximate_char_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))] MentorLake.Pango.PangoFontMetricsHandle metrics);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_font_metrics_get_approximate_digit_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))] MentorLake.Pango.PangoFontMetricsHandle metrics);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_font_metrics_get_ascent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))] MentorLake.Pango.PangoFontMetricsHandle metrics);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_font_metrics_get_descent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))] MentorLake.Pango.PangoFontMetricsHandle metrics);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_font_metrics_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))] MentorLake.Pango.PangoFontMetricsHandle metrics);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_font_metrics_get_strikethrough_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))] MentorLake.Pango.PangoFontMetricsHandle metrics);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_font_metrics_get_strikethrough_thickness([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))] MentorLake.Pango.PangoFontMetricsHandle metrics);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_font_metrics_get_underline_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))] MentorLake.Pango.PangoFontMetricsHandle metrics);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_font_metrics_get_underline_thickness([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))] MentorLake.Pango.PangoFontMetricsHandle metrics);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))]
	internal static extern MentorLake.Pango.PangoFontMetricsHandle pango_font_metrics_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))] MentorLake.Pango.PangoFontMetricsHandle metrics);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_metrics_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))] MentorLake.Pango.PangoFontMetricsHandle metrics);

}

/// <summary>
/// <para>
/// A `PangoFontMetrics` structure holds the overall metric information
/// for a font.
/// </para>
/// <para>
/// The information in a `PangoFontMetrics` structure may be restricted
/// to a script. The fields of this structure are private to implementations
/// of a font backend. See the documentation of the corresponding getters
/// for documentation of their meaning.
/// </para>
/// <para>
/// For an overview of the most important metrics, see:
/// </para>
/// <para>
/// <picture>
///   <source srcset="fontmetrics-dark.png" media="(prefers-color-scheme: dark)">
///   <img alt="Font metrics" src="fontmetrics-light.png">
/// </picture>
/// </para>
/// </summary>

public struct PangoFontMetrics
{
}
