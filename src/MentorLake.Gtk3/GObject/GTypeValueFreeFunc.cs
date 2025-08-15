namespace MentorLake.GObject;

/// <summary>
/// <para>
/// Frees any old contents that might be left in the `value-&amp;gt;data` array of
/// the given value.
/// </para>
/// <para>
/// No resources may remain allocated through the #GValue contents after this
/// function returns. E.g. for our above string type:
/// </para>
/// <code>
/// // only free strings without a specific flag for static storage
/// // only free strings without a specific flag for static storage
/// if (!(value-&amp;gt;data[1].v_uint &amp; G_VALUE_NOCOPY_CONTENTS))
///   g_free (value-&amp;gt;data[0].v_pointer);
/// </code>
/// </summary>

/// <param name="value">
/// the value to free
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTypeValueFreeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);
