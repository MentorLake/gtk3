namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The virtual function table for #GDebugController.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The virtual function table for #GDebugController.
/// </para>
/// </summary>

public struct GDebugControllerInterface
{
}
