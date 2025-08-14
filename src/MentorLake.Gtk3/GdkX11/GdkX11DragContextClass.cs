namespace MentorLake.GdkX11;


public class GdkX11DragContextClassHandle : BaseSafeHandle
{
}


public static class GdkX11DragContextClassExtensions
{

	public static GdkX11DragContextClass Dereference(this GdkX11DragContextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11DragContextClass>(x.DangerousGetHandle());
}
internal class GdkX11DragContextClassExterns
{
}


public struct GdkX11DragContextClass
{
}
