namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Usage of AtkMisc is deprecated since 2.12 and heavily discouraged.
/// </para>
/// </summary>

public class AtkMiscClassHandle : BaseSafeHandle
{
}


public static class AtkMiscClassExtensions
{

	public static AtkMiscClass Dereference(this AtkMiscClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkMiscClass>(x.DangerousGetHandle());
}
internal class AtkMiscClassExterns
{
}

/// <summary>
/// <para>
/// Usage of AtkMisc is deprecated since 2.12 and heavily discouraged.
/// </para>
/// </summary>

public struct AtkMiscClass
{
	
public GObjectClass parent;
	/// <summary>
/// <para>
/// This virtual function is deprecated since 2.12 and
///   it should not be overriden.
/// </para>
/// </summary>

public IntPtr threads_enter;
	/// <summary>
/// <para>
/// This virtual function is deprecated sice 2.12 and
///   it should not be overriden.
/// </para>
/// </summary>

public IntPtr threads_leave;
	
public IntPtr vfuncs;
}
