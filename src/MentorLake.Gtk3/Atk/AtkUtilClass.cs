namespace MentorLake.Atk;


public class AtkUtilClassHandle : BaseSafeHandle
{
}


public static class AtkUtilClassExtensions
{

	public static AtkUtilClass Dereference(this AtkUtilClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkUtilClass>(x.DangerousGetHandle());
}
internal class AtkUtilClassExterns
{
}


public struct AtkUtilClass
{
	
public GObjectClass parent;
	/// <summary>
/// <para>
/// adds the specified function to the list
///  of functions to be called when an ATK event occurs. ATK
///  implementors are discouraged from reimplementing this method.
/// </para>
/// </summary>

public IntPtr add_global_event_listener;
	/// <summary>
/// <para>
/// removes the specified function to
///  the list of functions to be called when an ATK event occurs. ATK
///  implementors are discouraged from reimplementing this method.
/// </para>
/// </summary>

public IntPtr remove_global_event_listener;
	/// <summary>
/// <para>
/// adds the specified function to the list of
///  functions to be called when a key event occurs.
/// </para>
/// </summary>

public IntPtr add_key_event_listener;
	/// <summary>
/// <para>
/// remove the specified function to the
///  list of functions to be called when a key event occurs.
/// </para>
/// </summary>

public IntPtr remove_key_event_listener;
	/// <summary>
/// <para>
/// gets the root accessible container for the current
///  application.
/// </para>
/// </summary>

public IntPtr get_root;
	/// <summary>
/// <para>
/// gets name string for the GUI toolkit
///  implementing ATK for this application.
/// </para>
/// </summary>

public IntPtr get_toolkit_name;
	/// <summary>
/// <para>
/// gets version string for the GUI toolkit
///  implementing ATK for this application.
/// </para>
/// </summary>

public IntPtr get_toolkit_version;
}
