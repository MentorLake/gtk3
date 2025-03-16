namespace MentorLake.Gio;

public class GPermissionPrivateHandle : BaseSafeHandle
{
}


public static class GPermissionPrivateExtensions
{

	public static GPermissionPrivate Dereference(this GPermissionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPermissionPrivate>(x.DangerousGetHandle());
}
internal class GPermissionPrivateExterns
{
}

public struct GPermissionPrivate
{
}
