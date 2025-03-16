namespace MentorLake.Gio;

public class GInputStreamPrivateHandle : BaseSafeHandle
{
}


public static class GInputStreamPrivateExtensions
{

	public static GInputStreamPrivate Dereference(this GInputStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInputStreamPrivate>(x.DangerousGetHandle());
}
internal class GInputStreamPrivateExterns
{
}

public struct GInputStreamPrivate
{
}
