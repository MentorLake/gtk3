namespace MentorLake.Pango;

public class PangoFontClassHandle : BaseSafeHandle
{
}


public static class PangoFontClassExtensions
{

	public static PangoFontClass Dereference(this PangoFontClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFontClass>(x.DangerousGetHandle());
}
internal class PangoFontClassExterns
{
}

public struct PangoFontClass
{
	public GObjectClass parent_class;
	public IntPtr describe;
	public IntPtr get_coverage;
	public IntPtr get_glyph_extents;
	public IntPtr get_metrics;
	public IntPtr get_font_map;
	public IntPtr describe_absolute;
	public IntPtr get_features;
	public IntPtr create_hb_font;
}
