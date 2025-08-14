namespace MentorLake.Atk;


public class AtkValueIfaceHandle : BaseSafeHandle
{
}


public static class AtkValueIfaceExtensions
{

	public static AtkValueIface Dereference(this AtkValueIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkValueIface>(x.DangerousGetHandle());
}
internal class AtkValueIfaceExterns
{
}


public struct AtkValueIface
{
	
public GTypeInterface parent;
	/// <summary>
/// <para>
/// This virtual function is deprecated since 2.12
///  and it should not be overriden.
/// </para>
/// </summary>

public IntPtr get_current_value;
	/// <summary>
/// <para>
/// This virtual function is deprecated since 2.12
///  and it should not be overriden.
/// </para>
/// </summary>

public IntPtr get_maximum_value;
	/// <summary>
/// <para>
/// This virtual function is deprecated since 2.12
///  and it should not be overriden.
/// </para>
/// </summary>

public IntPtr get_minimum_value;
	/// <summary>
/// <para>
/// This virtual function is deprecated since 2.12
///  and it should not be overriden.
/// </para>
/// </summary>

public IntPtr set_current_value;
	/// <summary>
/// <para>
/// This virtual function is deprecated since
///  2.12 and it should not be overriden.
/// </para>
/// </summary>

public IntPtr get_minimum_increment;
	/// <summary>
/// <para>
/// gets the current value and the human readable
/// text alternative (if available) of this object. Since 2.12.
/// </para>
/// </summary>

public IntPtr get_value_and_text;
	/// <summary>
/// <para>
/// gets the range that defines the minimum and maximum
///  value of this object. Returns NULL if there is no range
///  defined. Since 2.12.
/// </para>
/// </summary>

public IntPtr get_range;
	/// <summary>
/// <para>
/// gets the minimum increment by which the value of
///  this object may be changed. If zero it is undefined. Since 2.12.
/// </para>
/// </summary>

public IntPtr get_increment;
	/// <summary>
/// <para>
/// returns a list of different subranges, and their
///  description (if available) of this object. Returns NULL if there
///  is not subranges defined. Since 2.12.
/// </para>
/// </summary>

public IntPtr get_sub_ranges;
	/// <summary>
/// <para>
/// sets the value of this object. Since 2.12.
/// </para>
/// </summary>

public IntPtr set_value;
}
