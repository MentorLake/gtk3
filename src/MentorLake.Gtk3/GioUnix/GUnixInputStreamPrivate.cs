namespace MentorLake.GioUnix;

public class GUnixInputStreamPrivateHandle : BaseSafeHandle
{
}


public static class GUnixInputStreamPrivateExtensions
{

	public static GUnixInputStreamPrivate Dereference(this GUnixInputStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixInputStreamPrivate>(x.DangerousGetHandle());
}
internal class GUnixInputStreamPrivateExterns
{
}

public struct GUnixInputStreamPrivate
{
}
