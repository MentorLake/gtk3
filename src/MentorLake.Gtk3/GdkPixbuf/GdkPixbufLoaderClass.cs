namespace MentorLake.GdkPixbuf;


public class GdkPixbufLoaderClassHandle : BaseSafeHandle
{
}


public static class GdkPixbufLoaderClassExtensions
{

	public static GdkPixbufLoaderClass Dereference(this GdkPixbufLoaderClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkPixbufLoaderClass>(x.DangerousGetHandle());
}
internal class GdkPixbufLoaderClassExterns
{
}


public struct GdkPixbufLoaderClass
{
	
public GObjectClass parent_class;
	
public IntPtr size_prepared;
	
public IntPtr area_prepared;
	
public IntPtr area_updated;
	
public IntPtr closed;
}
