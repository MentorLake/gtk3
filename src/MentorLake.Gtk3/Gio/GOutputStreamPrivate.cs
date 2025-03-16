namespace MentorLake.Gio;

public class GOutputStreamPrivateHandle : BaseSafeHandle
{
}


public static class GOutputStreamPrivateExtensions
{

	public static GOutputStreamPrivate Dereference(this GOutputStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GOutputStreamPrivate>(x.DangerousGetHandle());
}
internal class GOutputStreamPrivateExterns
{
}

public struct GOutputStreamPrivate
{
}
