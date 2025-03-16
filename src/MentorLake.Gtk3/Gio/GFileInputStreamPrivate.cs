namespace MentorLake.Gio;

public class GFileInputStreamPrivateHandle : BaseSafeHandle
{
}


public static class GFileInputStreamPrivateExtensions
{

	public static GFileInputStreamPrivate Dereference(this GFileInputStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileInputStreamPrivate>(x.DangerousGetHandle());
}
internal class GFileInputStreamPrivateExterns
{
}

public struct GFileInputStreamPrivate
{
}
