namespace MentorLake.Gio;


public class GConverterInputStreamClassHandle : BaseSafeHandle
{
}


public static class GConverterInputStreamClassExtensions
{

	public static GConverterInputStreamClass Dereference(this GConverterInputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GConverterInputStreamClass>(x.DangerousGetHandle());
}
internal class GConverterInputStreamClassExterns
{
}


public struct GConverterInputStreamClass
{
	
public GFilterInputStreamClass parent_class;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
	
public IntPtr _g_reserved4;
	
public IntPtr _g_reserved5;
}
