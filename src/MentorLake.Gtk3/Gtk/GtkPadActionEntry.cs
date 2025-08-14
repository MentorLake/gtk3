namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Struct defining a pad action entry.
/// </para>
/// </summary>

public class GtkPadActionEntryHandle : BaseSafeHandle
{
}


public static class GtkPadActionEntryExtensions
{

	public static GtkPadActionEntry Dereference(this GtkPadActionEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPadActionEntry>(x.DangerousGetHandle());
}
internal class GtkPadActionEntryExterns
{
}

/// <summary>
/// <para>
/// Struct defining a pad action entry.
/// </para>
/// </summary>

public struct GtkPadActionEntry
{
	/// <summary>
/// <para>
/// the type of pad feature that will trigger this action entry.
/// </para>
/// </summary>

public GtkPadActionType type;
	/// <summary>
/// <para>
/// the 0-indexed button/ring/strip number that will trigger this action
///   entry.
/// </para>
/// </summary>

public int index;
	/// <summary>
/// <para>
/// the mode that will trigger this action entry, or -1 for all modes.
/// </para>
/// </summary>

public int mode;
	/// <summary>
/// <para>
/// Human readable description of this action entry, this string should
///   be deemed user-visible.
/// </para>
/// </summary>

public string label;
	/// <summary>
/// <para>
/// action name that will be activated in the #GActionGroup.
/// </para>
/// </summary>

public string action_name;
}
