namespace MentorLake.Gio;

public class GBufferedInputStreamPrivateHandle : BaseSafeHandle
{
}


public static class GBufferedInputStreamPrivateExtensions
{

	public static GBufferedInputStreamPrivate Dereference(this GBufferedInputStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GBufferedInputStreamPrivate>(x.DangerousGetHandle());
}
internal class GBufferedInputStreamPrivateExterns
{
}

public struct GBufferedInputStreamPrivate
{
}
