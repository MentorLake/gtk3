namespace MentorLake.Pango;


public class PangoFontFaceClassHandle : BaseSafeHandle
{
}


public static class PangoFontFaceClassExtensions
{

	public static PangoFontFaceClass Dereference(this PangoFontFaceClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFontFaceClass>(x.DangerousGetHandle());
}
internal class PangoFontFaceClassExterns
{
}


public struct PangoFontFaceClass
{
	
public GObjectClass parent_class;
	
public IntPtr get_face_name;
	
public IntPtr describe;
	
public IntPtr list_sizes;
	
public IntPtr is_synthesized;
	
public IntPtr get_family;
	
public IntPtr _pango_reserved3;
	
public IntPtr _pango_reserved4;
}
