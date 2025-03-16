namespace MentorLake.Gio;

public class GDBusObjectSkeletonClassHandle : BaseSafeHandle
{
}


public static class GDBusObjectSkeletonClassExtensions
{

	public static GDBusObjectSkeletonClass Dereference(this GDBusObjectSkeletonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectSkeletonClass>(x.DangerousGetHandle());
}
internal class GDBusObjectSkeletonClassExterns
{
}

public struct GDBusObjectSkeletonClass
{
	public GObjectClass parent_class;
	public IntPtr authorize_method;
}
