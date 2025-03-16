namespace MentorLake.Gio;

public class GMemoryOutputStreamPrivateHandle : BaseSafeHandle
{
}


public static class GMemoryOutputStreamPrivateExtensions
{

	public static GMemoryOutputStreamPrivate Dereference(this GMemoryOutputStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMemoryOutputStreamPrivate>(x.DangerousGetHandle());
}
internal class GMemoryOutputStreamPrivateExterns
{
}

public struct GMemoryOutputStreamPrivate
{
}
