namespace MentorLake.GdkX11;


public class GdkX11VisualClassHandle : BaseSafeHandle
{
}


public static class GdkX11VisualClassExtensions
{

	public static GdkX11VisualClass Dereference(this GdkX11VisualClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11VisualClass>(x.DangerousGetHandle());
}
internal class GdkX11VisualClassExterns
{
}


public struct GdkX11VisualClass
{
}
