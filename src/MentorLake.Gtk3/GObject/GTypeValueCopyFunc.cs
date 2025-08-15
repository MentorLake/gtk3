namespace MentorLake.GObject;

/// <summary>
/// <para>
/// Copies the content of a #GValue into another.
/// </para>
/// <para>
/// The @dest_value is a #GValue with zero-filled data section and @src_value
/// is a properly initialized #GValue of same type, or derived type.
/// </para>
/// <para>
/// The purpose of this function is to copy the contents of @src_value
/// into @dest_value in a way, that even after @src_value has been freed, the
/// contents of @dest_value remain valid. String type example:
/// </para>
/// <code>
/// dest_value-&amp;gt;data[0].v_pointer = g_strdup (src_value-&amp;gt;data[0].v_pointer);
/// dest_value-&amp;gt;data[0].v_pointer = g_strdup (src_value-&amp;gt;data[0].v_pointer);
/// </code>
/// </summary>

/// <param name="src_value">
/// the value to copy
/// </param>
/// <param name="dest_value">
/// the location of the copy
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTypeValueCopyFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle src_value, out MentorLake.GObject.GValue dest_value);
