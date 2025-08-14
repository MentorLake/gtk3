namespace MentorLake.GdkX11;


public class GdkX11ScreenClassHandle : BaseSafeHandle
{
}


public static class GdkX11ScreenClassExtensions
{

	public static GdkX11ScreenClass Dereference(this GdkX11ScreenClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11ScreenClass>(x.DangerousGetHandle());
}
internal class GdkX11ScreenClassExterns
{
}


public struct GdkX11ScreenClass
{
}
