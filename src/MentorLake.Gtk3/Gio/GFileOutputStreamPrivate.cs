namespace MentorLake.Gio;

public class GFileOutputStreamPrivateHandle : BaseSafeHandle
{
}


public static class GFileOutputStreamPrivateExtensions
{

	public static GFileOutputStreamPrivate Dereference(this GFileOutputStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileOutputStreamPrivate>(x.DangerousGetHandle());
}
internal class GFileOutputStreamPrivateExterns
{
}

public struct GFileOutputStreamPrivate
{
}
