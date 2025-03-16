namespace MentorLake.Gio;

public class GFileIOStreamPrivateHandle : BaseSafeHandle
{
}


public static class GFileIOStreamPrivateExtensions
{

	public static GFileIOStreamPrivate Dereference(this GFileIOStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileIOStreamPrivate>(x.DangerousGetHandle());
}
internal class GFileIOStreamPrivateExterns
{
}

public struct GFileIOStreamPrivate
{
}
