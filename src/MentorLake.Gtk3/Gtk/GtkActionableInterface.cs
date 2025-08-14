namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The interface vtable for #GtkActionable.
/// </para>
/// </summary>

public class GtkActionableInterfaceHandle : BaseSafeHandle
{
}


public static class GtkActionableInterfaceExtensions
{

	public static GtkActionableInterface Dereference(this GtkActionableInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkActionableInterface>(x.DangerousGetHandle());
}
internal class GtkActionableInterfaceExterns
{
}

/// <summary>
/// <para>
/// The interface vtable for #GtkActionable.
/// </para>
/// </summary>

public struct GtkActionableInterface
{
	/// <summary>
/// <para>
/// virtual function for gtk_actionable_get_action_name()
/// </para>
/// </summary>

public IntPtr get_action_name;
	/// <summary>
/// <para>
/// virtual function for gtk_actionable_set_action_name()
/// </para>
/// </summary>

public IntPtr set_action_name;
	/// <summary>
/// <para>
/// virtual function for gtk_actionable_get_action_target_value()
/// </para>
/// </summary>

public IntPtr get_action_target_value;
	/// <summary>
/// <para>
/// virtual function for gtk_actionable_set_action_target_value()
/// </para>
/// </summary>

public IntPtr set_action_target_value;
}
