namespace MentorLake.Gio;

/// <summary>
/// <para>
/// This struct defines a single action.  It is for use with
/// [method@Gio.ActionMap.add_action_entries].
/// </para>
/// <para>
/// The order of the items in the structure are intended to reflect
/// frequency of use.  It is permissible to use an incomplete initialiser
/// in order to leave some of the later values as `NULL`.  All values
/// after @name are optional.  Additional optional fields may be added in
/// the future.
/// </para>
/// <para>
/// See [method@Gio.ActionMap.add_action_entries] for an example.
/// </para>
/// </summary>

public class GActionEntryHandle : BaseSafeHandle
{
}


public static class GActionEntryExtensions
{

	public static GActionEntry Dereference(this GActionEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GActionEntry>(x.DangerousGetHandle());
}
internal class GActionEntryExterns
{
}

/// <summary>
/// <para>
/// This struct defines a single action.  It is for use with
/// [method@Gio.ActionMap.add_action_entries].
/// </para>
/// <para>
/// The order of the items in the structure are intended to reflect
/// frequency of use.  It is permissible to use an incomplete initialiser
/// in order to leave some of the later values as `NULL`.  All values
/// after @name are optional.  Additional optional fields may be added in
/// the future.
/// </para>
/// <para>
/// See [method@Gio.ActionMap.add_action_entries] for an example.
/// </para>
/// </summary>

public struct GActionEntry
{
	/// <summary>
/// <para>
/// the name of the action
/// </para>
/// </summary>

public string name;
	/// <summary>
/// <para>
/// the callback to connect to the &quot;activate&quot; signal of the action.
///   Since GLib 2.40, this can be `NULL` for stateful actions, in which case
///   the default handler is used. For boolean-stated actions with no
///   parameter, this is a toggle. For other state types (and parameter type
///   equal to the state type) this will be a function that just calls
///   @change_state (which you should provide).
/// </para>
/// </summary>

public IntPtr activate;
	/// <summary>
/// <para>
/// the type of the parameter that must be passed to the
///   activate function for this action, given as a single GVariant type string
///   (or `NULL` for no parameter)
/// </para>
/// </summary>

public string parameter_type;
	/// <summary>
/// <para>
/// the initial state for this action, given in
///   [GVariant text format](gvariant-text-format.html).  The state is parsed
///   with no extra type information, so type tags must be added to the string
///   if they are necessary.  Stateless actions should give `NULL` here.
/// </para>
/// </summary>

public string state;
	/// <summary>
/// <para>
/// the callback to connect to the &quot;change-state&quot; signal of the
///   action.  All stateful actions should provide a handler here; stateless
///   actions should not.
/// </para>
/// </summary>

public IntPtr change_state;
}
