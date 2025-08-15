namespace MentorLake.Atk;

/// <summary>
/// <para>
/// This structure represents a single  text selection within a document. This
/// selection is defined by two points in the content, where each one is defined
/// by an AtkObject supporting the AtkText interface and a character offset
/// relative to it.
/// </para>
/// <para>
/// The end object must appear after the start object in the accessibility tree,
/// i.e. the end object must be reachable from the start object by navigating
/// forward (next, first child etc).
/// </para>
/// <para>
/// This struct also contains a @start_is_active boolean, to communicate if the
/// start of the selection is the active point or not.
/// </para>
/// <para>
/// The active point corresponds to the user&apos;s focus or point of interest. The
/// user moves the active point to expand or collapse the range. The anchor
/// point is the other point of the range and typically remains constant. In
/// most cases, anchor is the start of the range and active is the end. However,
/// when selecting backwards (e.g. pressing shift+left arrow in a text field),
/// the start of the range is the active point, as the user moves this to
/// manipulate the selection.
/// </para>
/// </summary>

public class AtkTextSelectionHandle : BaseSafeHandle
{
}


public static class AtkTextSelectionExtensions
{

	public static AtkTextSelection Dereference(this AtkTextSelectionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkTextSelection>(x.DangerousGetHandle());
}
internal class AtkTextSelectionExterns
{
}

/// <summary>
/// <para>
/// This structure represents a single  text selection within a document. This
/// selection is defined by two points in the content, where each one is defined
/// by an AtkObject supporting the AtkText interface and a character offset
/// relative to it.
/// </para>
/// <para>
/// The end object must appear after the start object in the accessibility tree,
/// i.e. the end object must be reachable from the start object by navigating
/// forward (next, first child etc).
/// </para>
/// <para>
/// This struct also contains a @start_is_active boolean, to communicate if the
/// start of the selection is the active point or not.
/// </para>
/// <para>
/// The active point corresponds to the user&apos;s focus or point of interest. The
/// user moves the active point to expand or collapse the range. The anchor
/// point is the other point of the range and typically remains constant. In
/// most cases, anchor is the start of the range and active is the end. However,
/// when selecting backwards (e.g. pressing shift+left arrow in a text field),
/// the start of the range is the active point, as the user moves this to
/// manipulate the selection.
/// </para>
/// </summary>

public struct AtkTextSelection
{
	/// <summary>
/// <para>
/// the AtkText containing the start of the selection.
/// </para>
/// </summary>

public IntPtr start_object;
	/// <summary>
/// <para>
/// the text offset of the beginning of the selection within
///                @start_object.
/// </para>
/// </summary>

public int start_offset;
	/// <summary>
/// <para>
/// the AtkText containing the end of the selection.
/// </para>
/// </summary>

public IntPtr end_object;
	/// <summary>
/// <para>
/// the text offset of the end of the selection within @end_object.
/// </para>
/// </summary>

public int end_offset;
	/// <summary>
/// <para>
/// a gboolean indicating whether the start of the selection
///                  is the active point.
/// </para>
/// </summary>

public bool start_is_active;
}
