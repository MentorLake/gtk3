namespace MentorLake.GdkX11;


public class GdkX11WindowClassHandle : BaseSafeHandle
{
}


public static class GdkX11WindowClassExtensions
{

	public static GdkX11WindowClass Dereference(this GdkX11WindowClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11WindowClass>(x.DangerousGetHandle());
}
internal class GdkX11WindowClassExterns
{
}


public struct GdkX11WindowClass
{
}
