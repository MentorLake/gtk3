namespace MentorLake.Gio;

public class GMemoryInputStreamPrivateHandle : BaseSafeHandle
{
}


public static class GMemoryInputStreamPrivateExtensions
{

	public static GMemoryInputStreamPrivate Dereference(this GMemoryInputStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMemoryInputStreamPrivate>(x.DangerousGetHandle());
}
internal class GMemoryInputStreamPrivateExterns
{
}

public struct GMemoryInputStreamPrivate
{
}
