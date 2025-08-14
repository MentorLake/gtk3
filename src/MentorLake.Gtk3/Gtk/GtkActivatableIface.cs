namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// > This method can be called with a %NULL action at times.
/// </para>
/// </summary>

public class GtkActivatableIfaceHandle : BaseSafeHandle
{
}


public static class GtkActivatableIfaceExtensions
{

	public static GtkActivatableIface Dereference(this GtkActivatableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkActivatableIface>(x.DangerousGetHandle());
}
internal class GtkActivatableIfaceExterns
{
}

/// <summary>
/// <para>
/// > This method can be called with a %NULL action at times.
/// </para>
/// </summary>

public struct GtkActivatableIface
{
	/// <summary>
/// <para>
/// Called to update the activatable when its related action’s properties change.
/// You must check the #GtkActivatable:use-action-appearance property only apply action
/// properties that are meant to effect the appearance accordingly.
/// </para>
/// </summary>

public IntPtr update;
	/// <summary>
/// <para>
/// Called to update the activatable completely, this is called internally when
/// #GtkActivatable:related-action property is set or unset and by the implementor when
/// #GtkActivatable:use-action-appearance changes.
/// </para>
/// </summary>

public IntPtr sync_action_properties;
}
