namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of function passed to g_dataset_foreach(). It is
/// called with each #GQuark id and associated data element, together
/// with the @user_data parameter supplied to g_dataset_foreach().
/// </para>
/// </summary>

/// <param name="key_id">
/// the #GQuark id to identifying the data element.
/// </param>
/// <param name="data">
/// the data element.
/// </param>
/// <param name="user_data">
/// user data passed to g_dataset_foreach().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GDataForeachFunc(MentorLake.GLib.GQuark key_id, IntPtr data, IntPtr user_data);
