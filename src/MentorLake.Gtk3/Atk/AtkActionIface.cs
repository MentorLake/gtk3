namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The #AtkAction interface should be supported by any object that can
/// perform one or more actions. The interface provides the standard
/// mechanism for an assistive technology to determine what those actions
/// are as well as tell the object to perform them. Any object that can
/// be manipulated should support this interface.
/// </para>
/// </summary>

public class AtkActionIfaceHandle : BaseSafeHandle
{
}


public static class AtkActionIfaceExtensions
{

	public static AtkActionIface Dereference(this AtkActionIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkActionIface>(x.DangerousGetHandle());
}
internal class AtkActionIfaceExterns
{
}

/// <summary>
/// <para>
/// The #AtkAction interface should be supported by any object that can
/// perform one or more actions. The interface provides the standard
/// mechanism for an assistive technology to determine what those actions
/// are as well as tell the object to perform them. Any object that can
/// be manipulated should support this interface.
/// </para>
/// </summary>

public struct AtkActionIface
{
	
public IntPtr do_action;
	
public IntPtr get_n_actions;
	
public IntPtr get_description;
	
public IntPtr get_name;
	
public IntPtr get_keybinding;
	
public IntPtr set_description;
	
public IntPtr get_localized_name;
}
