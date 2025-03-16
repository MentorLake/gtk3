namespace MentorLake.Gio;

public class GCharsetConverterClassHandle : BaseSafeHandle
{
}


public static class GCharsetConverterClassExtensions
{

	public static GCharsetConverterClass Dereference(this GCharsetConverterClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GCharsetConverterClass>(x.DangerousGetHandle());
}
internal class GCharsetConverterClassExterns
{
}

public struct GCharsetConverterClass
{
	public GObjectClass parent_class;
}
