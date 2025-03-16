namespace MentorLake.Gio;

public class GDebugControllerInterfaceHandle : BaseSafeHandle
{
}


public static class GDebugControllerInterfaceExtensions
{

	public static GDebugControllerInterface Dereference(this GDebugControllerInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDebugControllerInterface>(x.DangerousGetHandle());
}
internal class GDebugControllerInterfaceExterns
{
}

public struct GDebugControllerInterface
{
}
