namespace MentorLake.Gio;

public class GBufferedOutputStreamPrivateHandle : BaseSafeHandle
{
}


public static class GBufferedOutputStreamPrivateExtensions
{

	public static GBufferedOutputStreamPrivate Dereference(this GBufferedOutputStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GBufferedOutputStreamPrivate>(x.DangerousGetHandle());
}
internal class GBufferedOutputStreamPrivateExterns
{
}

public struct GBufferedOutputStreamPrivate
{
}
