namespace MentorLake.Atk;

public interface AtkWindowHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkWindowHandleImpl : BaseSafeHandle, AtkWindowHandle
{
}

public static class AtkWindowHandleExtensions
{
}

internal class AtkWindowHandleExterns
{
}
