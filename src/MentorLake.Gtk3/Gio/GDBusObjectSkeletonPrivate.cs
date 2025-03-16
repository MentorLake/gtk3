namespace MentorLake.Gio;

public class GDBusObjectSkeletonPrivateHandle : BaseSafeHandle
{
}


public static class GDBusObjectSkeletonPrivateExtensions
{

	public static GDBusObjectSkeletonPrivate Dereference(this GDBusObjectSkeletonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectSkeletonPrivate>(x.DangerousGetHandle());
}
internal class GDBusObjectSkeletonPrivateExterns
{
}

public struct GDBusObjectSkeletonPrivate
{
}
