namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A #GSequenceIterCompareFunc is a function used to compare iterators.
/// It must return zero if the iterators compare equal, a negative value
/// if @a comes before @b, and a positive value if @b comes before @a.
/// </para>
/// </summary>

/// <param name="a">
/// a #GSequenceIter
/// </param>
/// <param name="b">
/// a #GSequenceIter
/// </param>
/// <param name="data">
/// user data
/// </param>
/// <return>
/// zero if the iterators are equal, a negative value if @a
///     comes before @b, and a positive value if @b comes before @a.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GSequenceIterCompareFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle b, IntPtr data);
