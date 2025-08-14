namespace MentorLake.Gio;


public class GDBusInterfaceSkeletonPrivateHandle : BaseSafeHandle
{
}


public static class GDBusInterfaceSkeletonPrivateExtensions
{

	public static GDBusInterfaceSkeletonPrivate Dereference(this GDBusInterfaceSkeletonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusInterfaceSkeletonPrivate>(x.DangerousGetHandle());
}
internal class GDBusInterfaceSkeletonPrivateExterns
{
}


public struct GDBusInterfaceSkeletonPrivate
{
}
