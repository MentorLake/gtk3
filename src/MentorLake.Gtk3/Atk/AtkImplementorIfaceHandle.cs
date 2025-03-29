namespace MentorLake.Atk;

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
