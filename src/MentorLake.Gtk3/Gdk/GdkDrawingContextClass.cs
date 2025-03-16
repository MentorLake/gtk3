namespace MentorLake.Gdk;

public class GdkDrawingContextClassHandle : BaseSafeHandle
{
}


public static class GdkDrawingContextClassExtensions
{

	public static GdkDrawingContextClass Dereference(this GdkDrawingContextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkDrawingContextClass>(x.DangerousGetHandle());
}
internal class GdkDrawingContextClassExterns
{
}

public struct GdkDrawingContextClass
{
}
