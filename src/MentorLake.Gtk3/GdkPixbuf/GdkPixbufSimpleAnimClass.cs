namespace MentorLake.GdkPixbuf;


public class GdkPixbufSimpleAnimClassHandle : BaseSafeHandle
{
}


public static class GdkPixbufSimpleAnimClassExtensions
{

	public static GdkPixbufSimpleAnimClass Dereference(this GdkPixbufSimpleAnimClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkPixbufSimpleAnimClass>(x.DangerousGetHandle());
}
internal class GdkPixbufSimpleAnimClassExterns
{
}


public struct GdkPixbufSimpleAnimClass
{
}
