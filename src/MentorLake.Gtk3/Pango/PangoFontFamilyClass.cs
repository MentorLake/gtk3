namespace MentorLake.Pango;

public class PangoFontFamilyClassHandle : BaseSafeHandle
{
}


public static class PangoFontFamilyClassExtensions
{

	public static PangoFontFamilyClass Dereference(this PangoFontFamilyClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFontFamilyClass>(x.DangerousGetHandle());
}
internal class PangoFontFamilyClassExterns
{
}

public struct PangoFontFamilyClass
{
	public GObjectClass parent_class;
	public IntPtr list_faces;
	public IntPtr get_name;
	public IntPtr is_monospace;
	public IntPtr is_variable;
	public IntPtr get_face;
	public IntPtr _pango_reserved2;
}
