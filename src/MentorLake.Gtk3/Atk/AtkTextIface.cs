namespace MentorLake.Atk;


public class AtkTextIfaceHandle : BaseSafeHandle
{
}


public static class AtkTextIfaceExtensions
{

	public static AtkTextIface Dereference(this AtkTextIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkTextIface>(x.DangerousGetHandle());
}
internal class AtkTextIfaceExterns
{
}


public struct AtkTextIface
{
	
public GTypeInterface parent;
	
public IntPtr get_text;
	/// <summary>
/// <para>
/// Gets specified text. This virtual function
///   is deprecated and it should not be overridden.
/// </para>
/// </summary>

public IntPtr get_text_after_offset;
	/// <summary>
/// <para>
/// Gets specified text. This virtual function
///   is deprecated and it should not be overridden.
/// </para>
/// </summary>

public IntPtr get_text_at_offset;
	
public IntPtr get_character_at_offset;
	/// <summary>
/// <para>
/// Gets specified text. This virtual function
///   is deprecated and it should not be overridden.
/// </para>
/// </summary>

public IntPtr get_text_before_offset;
	
public IntPtr get_caret_offset;
	
public IntPtr get_run_attributes;
	
public IntPtr get_default_attributes;
	
public IntPtr get_character_extents;
	
public IntPtr get_character_count;
	
public IntPtr get_offset_at_point;
	
public IntPtr get_n_selections;
	
public IntPtr get_selection;
	
public IntPtr add_selection;
	
public IntPtr remove_selection;
	
public IntPtr set_selection;
	
public IntPtr set_caret_offset;
	/// <summary>
/// <para>
/// the signal handler which is executed when there is a
///   text change. This virtual function is deprecated sice 2.9.4 and
///   it should not be overriden.
/// </para>
/// </summary>

public IntPtr text_changed;
	
public IntPtr text_caret_moved;
	
public IntPtr text_selection_changed;
	
public IntPtr text_attributes_changed;
	
public IntPtr get_range_extents;
	
public IntPtr get_bounded_ranges;
	/// <summary>
/// <para>
/// Gets a portion of the text exposed through
///   an AtkText according to a given offset and a specific
///   granularity, along with the start and end offsets defining the
///   boundaries of such a portion of text.
/// </para>
/// </summary>

public IntPtr get_string_at_offset;
	
public IntPtr scroll_substring_to;
	
public IntPtr scroll_substring_to_point;
}
