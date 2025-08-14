namespace MentorLake.Gio;


public class GPermissionClassHandle : BaseSafeHandle
{
}


public static class GPermissionClassExtensions
{

	public static GPermissionClass Dereference(this GPermissionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPermissionClass>(x.DangerousGetHandle());
}
internal class GPermissionClassExterns
{
}


public struct GPermissionClass
{
	
public GObjectClass parent_class;
	
public IntPtr acquire;
	
public IntPtr acquire_async;
	
public IntPtr acquire_finish;
	
public IntPtr release;
	
public IntPtr release_async;
	
public IntPtr release_finish;
	
public IntPtr reserved;
}
