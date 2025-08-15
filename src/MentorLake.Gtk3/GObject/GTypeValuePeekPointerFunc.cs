namespace MentorLake.GObject;

/// <summary>
/// <para>
/// If the value contents fit into a pointer, such as objects or strings,
/// return this pointer, so the caller can peek at the current contents.
/// </para>
/// <para>
/// To extend on our above string example:
/// </para>
/// <code>
/// return value-&amp;gt;data[0].v_pointer;
/// return value-&amp;gt;data[0].v_pointer;
/// </code>
/// </summary>

/// <param name="value">
/// the value to peek
/// </param>
/// <return>
/// a pointer to the value contents
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GTypeValuePeekPointerFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);
