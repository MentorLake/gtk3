namespace MentorLake.Pango;

public class PangoFontMapClassHandle : BaseSafeHandle
{
}


public static class PangoFontMapClassExtensions
{

	public static PangoFontMapClass Dereference(this PangoFontMapClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFontMapClass>(x.DangerousGetHandle());
}
internal class PangoFontMapClassExterns
{
}

public struct PangoFontMapClass
{
	public GObjectClass parent_class;
	public IntPtr load_font;
	public IntPtr list_families;
	public IntPtr load_fontset;
	public string shape_engine_type;
	public IntPtr get_serial;
	public IntPtr changed;
	public IntPtr get_family;
	public IntPtr get_face;
}
