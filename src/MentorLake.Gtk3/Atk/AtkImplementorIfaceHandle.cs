namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The AtkImplementor interface is implemented by objects for which
/// AtkObject peers may be obtained via calls to
/// iface-&amp;gt;(ref_accessible)(implementor);
/// </para>
/// </summary>

public interface AtkImplementorIfaceHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkImplementorIfaceHandleImpl : BaseSafeHandle, AtkImplementorIfaceHandle
{
}

public static class AtkImplementorIfaceHandleExtensions
{
}

internal class AtkImplementorIfaceHandleExterns
{
}
