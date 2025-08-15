namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A numerical value which represents the unique identifier of a registered
/// type.
/// </para>
/// </summary>

public struct GType
{
	public UIntPtr Value;
}

/// <summary>
/// <para>
/// A numerical value which represents the unique identifier of a registered
/// type.
/// </para>
/// </summary>

public class GTypeHandle : BaseSafeHandle
{
}

public static class GTypeHandleExtensions
{
	public static GType Dereference(this GTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GType>(x.DangerousGetHandle());
	public static UIntPtr DereferenceValue(this GTypeHandle x) => x.Dereference().Value;
}
