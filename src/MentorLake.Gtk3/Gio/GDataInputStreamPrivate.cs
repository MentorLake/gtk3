namespace MentorLake.Gio;

public class GDataInputStreamPrivateHandle : BaseSafeHandle
{
}


public static class GDataInputStreamPrivateExtensions
{

	public static GDataInputStreamPrivate Dereference(this GDataInputStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDataInputStreamPrivate>(x.DangerousGetHandle());
}
internal class GDataInputStreamPrivateExterns
{
}

public struct GDataInputStreamPrivate
{
}
