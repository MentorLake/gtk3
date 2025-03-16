namespace MentorLake.GdkX11;

public class GdkX11CursorClassHandle : BaseSafeHandle
{
}


public static class GdkX11CursorClassExtensions
{

	public static GdkX11CursorClass Dereference(this GdkX11CursorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11CursorClass>(x.DangerousGetHandle());
}
internal class GdkX11CursorClassExterns
{
}

public struct GdkX11CursorClass
{
}
