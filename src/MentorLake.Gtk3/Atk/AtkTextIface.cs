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
	public IntPtr get_text_after_offset;
	public IntPtr get_text_at_offset;
	public IntPtr get_character_at_offset;
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
	public IntPtr text_changed;
	public IntPtr text_caret_moved;
	public IntPtr text_selection_changed;
	public IntPtr text_attributes_changed;
	public IntPtr get_range_extents;
	public IntPtr get_bounded_ranges;
	public IntPtr get_string_at_offset;
	public IntPtr scroll_substring_to;
	public IntPtr scroll_substring_to_point;
}
