namespace MentorLake.Gio;


public class GConverterInputStreamPrivateHandle : BaseSafeHandle
{
}


public static class GConverterInputStreamPrivateExtensions
{

	public static GConverterInputStreamPrivate Dereference(this GConverterInputStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GConverterInputStreamPrivate>(x.DangerousGetHandle());
}
internal class GConverterInputStreamPrivateExterns
{
}


public struct GConverterInputStreamPrivate
{
}
