namespace MentorLake.GdkX11;

public class GdkX11DeviceCoreClassHandle : BaseSafeHandle
{
}


public static class GdkX11DeviceCoreClassExtensions
{

	public static GdkX11DeviceCoreClass Dereference(this GdkX11DeviceCoreClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11DeviceCoreClass>(x.DangerousGetHandle());
}
internal class GdkX11DeviceCoreClassExterns
{
}

public struct GdkX11DeviceCoreClass
{
}
