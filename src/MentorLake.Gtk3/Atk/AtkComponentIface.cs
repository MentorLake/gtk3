namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The AtkComponent interface should be supported by any object that is
/// rendered on the screen. The interface provides the standard mechanism
/// for an assistive technology to determine and set the graphical
/// representation of an object.
/// </para>
/// </summary>

public class AtkComponentIfaceHandle : BaseSafeHandle
{
}


public static class AtkComponentIfaceExtensions
{

	public static AtkComponentIface Dereference(this AtkComponentIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkComponentIface>(x.DangerousGetHandle());
}
internal class AtkComponentIfaceExterns
{
}

/// <summary>
/// <para>
/// The AtkComponent interface should be supported by any object that is
/// rendered on the screen. The interface provides the standard mechanism
/// for an assistive technology to determine and set the graphical
/// representation of an object.
/// </para>
/// </summary>

public struct AtkComponentIface
{
	/// <summary>
/// <para>
/// This virtual function is deprecated since 2.9.4
///   and it should not be overriden. See atk_component_add_focus_handler()
///   for more information.
/// </para>
/// </summary>

public IntPtr add_focus_handler;
	
public IntPtr contains;
	
public IntPtr ref_accessible_at_point;
	
public IntPtr get_extents;
	/// <summary>
/// <para>
/// This virtual function is deprecated since 2.12 and
///   it should not be overriden. Use @AtkComponentIface.get_extents instead.
/// </para>
/// </summary>

public IntPtr get_position;
	/// <summary>
/// <para>
/// This virtual function is deprecated since 2.12 and it
///   should not be overriden. Use @AtkComponentIface.get_extents instead.
/// </para>
/// </summary>

public IntPtr get_size;
	
public IntPtr grab_focus;
	/// <summary>
/// <para>
/// This virtual function is deprecated since
///   2.9.4 and it should not be overriden. See atk_component_remove_focus_handler()
///   for more information.
/// </para>
/// </summary>

public IntPtr remove_focus_handler;
	
public IntPtr set_extents;
	
public IntPtr set_position;
	
public IntPtr set_size;
	
public IntPtr get_layer;
	
public IntPtr get_mdi_zorder;
	
public IntPtr bounds_changed;
	
public IntPtr get_alpha;
	
public IntPtr scroll_to;
	
public IntPtr scroll_to_point;
}
