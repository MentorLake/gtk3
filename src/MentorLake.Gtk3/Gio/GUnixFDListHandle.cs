namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A `GUnixFDList` contains a list of file descriptors.  It owns the file
/// descriptors that it contains, closing them when finalized.
/// </para>
/// <para>
/// It may be wrapped in a
/// &amp;lt;see href=&quot;../gio-unix/class.UnixFDMessage.html&quot;&amp;gt;GUnixFDMessage&amp;lt;/see&amp;gt; and sent over a
/// [class@Gio.Socket] in the `G_SOCKET_FAMILY_UNIX` family by using
/// [method@Gio.Socket.send_message] and received using
/// [method@Gio.Socket.receive_message].
/// </para>
/// <para>
/// Before 2.74, `&amp;lt;gio/gunixfdlist.h&amp;gt;` belonged to the UNIX-specific GIO
/// interfaces, thus you had to use the `gio-unix-2.0.pc` pkg-config file when
/// using it.
/// </para>
/// <para>
/// Since 2.74, the API is available for Windows.
/// </para>
/// </summary>

public class GUnixFDListHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GUnixFDList containing no file descriptors.
/// </para>
/// </summary>

/// <return>
/// a new #GUnixFDList
/// </return>

	public static MentorLake.Gio.GUnixFDListHandle New()
	{
		return GUnixFDListHandleExterns.g_unix_fd_list_new();
	}

/// <summary>
/// <para>
/// Creates a new #GUnixFDList containing the file descriptors given in
/// @fds.  The file descriptors become the property of the new list and
/// may no longer be used by the caller.  The array itself is owned by
/// the caller.
/// </para>
/// <para>
/// Each file descriptor in the array should be set to close-on-exec.
/// </para>
/// <para>
/// If @n_fds is -1 then @fds must be terminated with -1.
/// </para>
/// </summary>

/// <param name="fds">
/// the initial list of file descriptors
/// </param>
/// <param name="n_fds">
/// the length of #fds, or -1
/// </param>
/// <return>
/// a new #GUnixFDList
/// </return>

	public static MentorLake.Gio.GUnixFDListHandle NewFromArray(int[] fds, int n_fds)
	{
		return GUnixFDListHandleExterns.g_unix_fd_list_new_from_array(fds, n_fds);
	}

}

public static class GUnixFDListHandleExtensions
{
/// <summary>
/// <para>
/// Adds a file descriptor to @list.
/// </para>
/// <para>
/// The file descriptor is duplicated using dup(). You keep your copy
/// of the descriptor and the copy contained in @list will be closed
/// when @list is finalized.
/// </para>
/// <para>
/// A possible cause of failure is exceeding the per-process or
/// system-wide file descriptor limit.
/// </para>
/// <para>
/// The index of the file descriptor in the list is returned.  If you use
/// this index with g_unix_fd_list_get() then you will receive back a
/// duplicated copy of the same file descriptor.
/// </para>
/// </summary>

/// <param name="list">
/// a #GUnixFDList
/// </param>
/// <param name="fd">
/// a valid open file descriptor
/// </param>
/// <return>
/// the index of the appended fd in case of success, else -1
///          (and @error is set)
/// </return>

	public static int Append(this MentorLake.Gio.GUnixFDListHandle list, int fd)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GUnixFDListHandle)");
		var externCallResult = GUnixFDListHandleExterns.g_unix_fd_list_append(list, fd, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets a file descriptor out of @list.
/// </para>
/// <para>
/// @index_ specifies the index of the file descriptor to get.  It is a
/// programmer error for @index_ to be out of range; see
/// g_unix_fd_list_get_length().
/// </para>
/// <para>
/// The file descriptor is duplicated using dup() and set as
/// close-on-exec before being returned.  You must call close() on it
/// when you are done.
/// </para>
/// <para>
/// A possible cause of failure is exceeding the per-process or
/// system-wide file descriptor limit.
/// </para>
/// </summary>

/// <param name="list">
/// a #GUnixFDList
/// </param>
/// <param name="index_">
/// the index into the list
/// </param>
/// <return>
/// the file descriptor, or -1 in case of error
/// </return>

	public static int Get(this MentorLake.Gio.GUnixFDListHandle list, int index_)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GUnixFDListHandle)");
		var externCallResult = GUnixFDListHandleExterns.g_unix_fd_list_get(list, index_, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the length of @list (ie: the number of file descriptors
/// contained within).
/// </para>
/// </summary>

/// <param name="list">
/// a #GUnixFDList
/// </param>
/// <return>
/// the length of @list
/// </return>

	public static int GetLength(this MentorLake.Gio.GUnixFDListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GUnixFDListHandle)");
		return GUnixFDListHandleExterns.g_unix_fd_list_get_length(list);
	}

/// <summary>
/// <para>
/// Returns the array of file descriptors that is contained in this
/// object.
/// </para>
/// <para>
/// After this call, the descriptors remain the property of @list.  The
/// caller must not close them and must not free the array.  The array is
/// valid only until @list is changed in any way.
/// </para>
/// <para>
/// If @length is non-%NULL then it is set to the number of file
/// descriptors in the returned array. The returned array is also
/// terminated with -1.
/// </para>
/// <para>
/// This function never returns %NULL. In case there are no file
/// descriptors contained in @list, an empty array is returned.
/// </para>
/// </summary>

/// <param name="list">
/// a #GUnixFDList
/// </param>
/// <param name="length">
/// pointer to the length of the returned
///     array, or %NULL
/// </param>
/// <return>
/// an array of file
///     descriptors
/// </return>

	public static int[] PeekFds(this MentorLake.Gio.GUnixFDListHandle list, out int length)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GUnixFDListHandle)");
		return GUnixFDListHandleExterns.g_unix_fd_list_peek_fds(list, out length);
	}

/// <summary>
/// <para>
/// Returns the array of file descriptors that is contained in this
/// object.
/// </para>
/// <para>
/// After this call, the descriptors are no longer contained in
/// @list. Further calls will return an empty list (unless more
/// descriptors have been added).
/// </para>
/// <para>
/// The return result of this function must be freed with g_free().
/// The caller is also responsible for closing all of the file
/// descriptors.  The file descriptors in the array are set to
/// close-on-exec.
/// </para>
/// <para>
/// If @length is non-%NULL then it is set to the number of file
/// descriptors in the returned array. The returned array is also
/// terminated with -1.
/// </para>
/// <para>
/// This function never returns %NULL. In case there are no file
/// descriptors contained in @list, an empty array is returned.
/// </para>
/// </summary>

/// <param name="list">
/// a #GUnixFDList
/// </param>
/// <param name="length">
/// pointer to the length of the returned
///     array, or %NULL
/// </param>
/// <return>
/// an array of file
///     descriptors
/// </return>

	public static int[] StealFds(this MentorLake.Gio.GUnixFDListHandle list, out int length)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GUnixFDListHandle)");
		return GUnixFDListHandleExterns.g_unix_fd_list_steal_fds(list, out length);
	}

}

internal class GUnixFDListHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))]
	internal static extern MentorLake.Gio.GUnixFDListHandle g_unix_fd_list_new();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))]
	internal static extern MentorLake.Gio.GUnixFDListHandle g_unix_fd_list_new_from_array(int[] fds, int n_fds);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_fd_list_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list, int fd, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_fd_list_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list, int index_, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_fd_list_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list);

	[DllImport(GioLibrary.Name)]
	internal static extern int[] g_unix_fd_list_peek_fds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list, out int length);

	[DllImport(GioLibrary.Name)]
	internal static extern int[] g_unix_fd_list_steal_fds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list, out int length);

}
