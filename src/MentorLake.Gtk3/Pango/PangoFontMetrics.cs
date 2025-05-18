namespace MentorLake.Pango;

public class PangoFontMetricsHandle : BaseSafeHandle
{
}


public static class PangoFontMetricsExtensions
{
	public static int GetApproximateCharWidth(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_approximate_char_width(metrics);
	}

	public static int GetApproximateDigitWidth(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_approximate_digit_width(metrics);
	}

	public static int GetAscent(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_ascent(metrics);
	}

	public static int GetDescent(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_descent(metrics);
	}

	public static int GetHeight(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_height(metrics);
	}

	public static int GetStrikethroughPosition(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_strikethrough_position(metrics);
	}

	public static int GetStrikethroughThickness(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_strikethrough_thickness(metrics);
	}

	public static int GetUnderlinePosition(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_underline_position(metrics);
	}

	public static int GetUnderlineThickness(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_get_underline_thickness(metrics);
	}

	public static MentorLake.Pango.PangoFontMetricsHandle Ref(this MentorLake.Pango.PangoFontMetricsHandle metrics)
	{
		if (metrics.IsInvalid) throw new Exception("Invalid handle (PangoFontMetrics)");
		return PangoFontMetricsExterns.pango_font_metrics_ref(metrics);
	}

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

public struct PangoFontMetrics
{
}
