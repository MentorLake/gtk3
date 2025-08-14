namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The ATK Interface provided by UI components that represent a top-level window.
/// </para>
/// <para>
/// #AtkWindow should be implemented by the UI elements that represent
/// a top-level window, such as the main window of an application or
/// dialog.
/// </para>
/// <para>
/// See [class@AtkObject]
/// </para>
/// </summary>

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
