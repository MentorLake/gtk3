namespace MentorLake.Gio;


public class GFilenameCompleterClassHandle : BaseSafeHandle
{
}


public static class GFilenameCompleterClassExtensions
{

	public static GFilenameCompleterClass Dereference(this GFilenameCompleterClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFilenameCompleterClass>(x.DangerousGetHandle());
}
internal class GFilenameCompleterClassExterns
{
}


public struct GFilenameCompleterClass
{
	
public GObjectClass parent_class;
	
public IntPtr got_completion_data;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
}
