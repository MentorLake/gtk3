namespace MentorLake.Gio;

public class GDataOutputStreamPrivateHandle : BaseSafeHandle
{
}


public static class GDataOutputStreamPrivateExtensions
{

	public static GDataOutputStreamPrivate Dereference(this GDataOutputStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDataOutputStreamPrivate>(x.DangerousGetHandle());
}
internal class GDataOutputStreamPrivateExterns
{
}

public struct GDataOutputStreamPrivate
{
}
