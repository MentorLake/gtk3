namespace MentorLake.GdkX11;

public class GdkX11DeviceManagerCoreClassHandle : BaseSafeHandle
{
}


public static class GdkX11DeviceManagerCoreClassExtensions
{

	public static GdkX11DeviceManagerCoreClass Dereference(this GdkX11DeviceManagerCoreClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11DeviceManagerCoreClass>(x.DangerousGetHandle());
}
internal class GdkX11DeviceManagerCoreClassExterns
{
}

public struct GdkX11DeviceManagerCoreClass
{
}
