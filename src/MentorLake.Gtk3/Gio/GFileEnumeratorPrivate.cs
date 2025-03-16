namespace MentorLake.Gio;

public class GFileEnumeratorPrivateHandle : BaseSafeHandle
{
}


public static class GFileEnumeratorPrivateExtensions
{

	public static GFileEnumeratorPrivate Dereference(this GFileEnumeratorPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileEnumeratorPrivate>(x.DangerousGetHandle());
}
internal class GFileEnumeratorPrivateExterns
{
}

public struct GFileEnumeratorPrivate
{
}
