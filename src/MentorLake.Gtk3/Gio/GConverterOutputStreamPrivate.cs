namespace MentorLake.Gio;

public class GConverterOutputStreamPrivateHandle : BaseSafeHandle
{
}


public static class GConverterOutputStreamPrivateExtensions
{

	public static GConverterOutputStreamPrivate Dereference(this GConverterOutputStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GConverterOutputStreamPrivate>(x.DangerousGetHandle());
}
internal class GConverterOutputStreamPrivateExterns
{
}

public struct GConverterOutputStreamPrivate
{
}
