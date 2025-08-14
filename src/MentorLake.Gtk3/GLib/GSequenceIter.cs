namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GSequenceIter struct is an opaque data type representing an
/// iterator pointing into a #GSequence.
/// </para>
/// </summary>

public class GSequenceIterHandle : BaseSafeHandle
{
}


public static class GSequenceIterExtensions
{
/// <summary>
/// <para>
/// Returns a negative number if @a comes before @b, 0 if they are equal,
/// and a positive number if @a comes after @b.
/// </para>
/// <para>
/// The @a and @b iterators must point into the same sequence.
/// </para>
/// </summary>

/// <param name="a">
/// a #GSequenceIter
/// </param>
/// <param name="b">
/// a #GSequenceIter
/// </param>
/// <return>
/// a negative number if @a comes before @b, 0 if they are
///     equal, and a positive number if @a comes after @b
/// </return>

	public static int Compare(this MentorLake.GLib.GSequenceIterHandle a, MentorLake.GLib.GSequenceIterHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_compare(a, b);
	}

/// <summary>
/// <para>
/// Returns the position of @iter
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <return>
/// the position of @iter
/// </return>

	public static int GetPosition(this MentorLake.GLib.GSequenceIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_get_position(iter);
	}

/// <summary>
/// <para>
/// Returns the #GSequence that @iter points into.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <return>
/// the #GSequence that @iter points into
/// </return>

	public static MentorLake.GLib.GSequenceHandle GetSequence(this MentorLake.GLib.GSequenceIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_get_sequence(iter);
	}

/// <summary>
/// <para>
/// Returns whether @iter is the begin iterator
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <return>
/// whether @iter is the begin iterator
/// </return>

	public static bool IsBegin(this MentorLake.GLib.GSequenceIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_is_begin(iter);
	}

/// <summary>
/// <para>
/// Returns whether @iter is the end iterator
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <return>
/// Whether @iter is the end iterator
/// </return>

	public static bool IsEnd(this MentorLake.GLib.GSequenceIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_is_end(iter);
	}

/// <summary>
/// <para>
/// Returns the #GSequenceIter which is @delta positions away from @iter.
/// If @iter is closer than -@delta positions to the beginning of the sequence,
/// the begin iterator is returned. If @iter is closer than @delta positions
/// to the end of the sequence, the end iterator is returned.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <param name="delta">
/// A positive or negative number indicating how many positions away
///    from @iter the returned #GSequenceIter will be
/// </param>
/// <return>
/// a #GSequenceIter which is @delta positions away from @iter
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle Move(this MentorLake.GLib.GSequenceIterHandle iter, int delta)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_move(iter, delta);
	}

/// <summary>
/// <para>
/// Returns an iterator pointing to the next position after @iter.
/// If @iter is the end iterator, the end iterator is returned.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <return>
/// a #GSequenceIter pointing to the next position after @iter
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle Next(this MentorLake.GLib.GSequenceIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_next(iter);
	}

/// <summary>
/// <para>
/// Returns an iterator pointing to the previous position before @iter.
/// If @iter is the begin iterator, the begin iterator is returned.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <return>
/// a #GSequenceIter pointing to the previous position
///     before @iter
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle Prev(this MentorLake.GLib.GSequenceIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_prev(iter);
	}


	public static GSequenceIter Dereference(this GSequenceIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSequenceIter>(x.DangerousGetHandle());
}
internal class GSequenceIterExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern int g_sequence_iter_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle b);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_sequence_iter_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))]
	internal static extern MentorLake.GLib.GSequenceHandle g_sequence_iter_get_sequence([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_sequence_iter_is_begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_sequence_iter_is_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_iter_move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, int delta);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_iter_prev([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

}

/// <summary>
/// <para>
/// The #GSequenceIter struct is an opaque data type representing an
/// iterator pointing into a #GSequence.
/// </para>
/// </summary>

public struct GSequenceIter
{
}
