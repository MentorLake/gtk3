namespace MentorLake.Gio;


public class GCancellablePrivateHandle : BaseSafeHandle
{
}


public static class GCancellablePrivateExtensions
{

	public static GCancellablePrivate Dereference(this GCancellablePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GCancellablePrivate>(x.DangerousGetHandle());
}
internal class GCancellablePrivateExterns
{
}


public struct GCancellablePrivate
{
}
