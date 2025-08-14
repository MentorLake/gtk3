namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Completes partial file and directory names given a partial string by
/// looking in the file system for clues. Can return a list of possible
/// completion strings for widget implementations.
/// </para>
/// </summary>

public class GFilenameCompleterHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new filename completer.
/// </para>
/// </summary>

/// <return>
/// a #GFilenameCompleter.
/// </return>

	public static MentorLake.Gio.GFilenameCompleterHandle New()
	{
		return GFilenameCompleterHandleExterns.g_filename_completer_new();
	}

}
public static class GFilenameCompleterHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the file name completion information comes available.
/// </para>
/// </summary>

	public static IObservable<GFilenameCompleterHandleSignalStructs.GotCompletionDataSignal> Signal_GotCompletionData(this GFilenameCompleterHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GFilenameCompleterHandleSignalStructs.GotCompletionDataSignal> obs) =>
		{
			GFilenameCompleterHandleSignalDelegates.got_completion_data handler = ( MentorLake.Gio.GFilenameCompleterHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GFilenameCompleterHandleSignalStructs.GotCompletionDataSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "got-completion-data", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GFilenameCompleterHandleSignalStructs
{

public class GotCompletionDataSignal
{

	public MentorLake.Gio.GFilenameCompleterHandle Self;

	public IntPtr UserData;
}
}

public static class GFilenameCompleterHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the file name completion information comes available.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void got_completion_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilenameCompleterHandle>))] MentorLake.Gio.GFilenameCompleterHandle self, IntPtr user_data);

}


public static class GFilenameCompleterHandleExtensions
{
/// <summary>
/// <para>
/// Obtains a completion for @initial_text from @completer.
/// </para>
/// </summary>

/// <param name="completer">
/// the filename completer.
/// </param>
/// <param name="initial_text">
/// text to be completed.
/// </param>
/// <return>
/// a completed string, or %NULL if no
///     completion exists. This string is not owned by GIO, so remember to g_free()
///     it when finished.
/// </return>

	public static string GetCompletionSuffix(this MentorLake.Gio.GFilenameCompleterHandle completer, string initial_text)
	{
		if (completer.IsInvalid) throw new Exception("Invalid handle (GFilenameCompleterHandle)");
		return GFilenameCompleterHandleExterns.g_filename_completer_get_completion_suffix(completer, initial_text);
	}

/// <summary>
/// <para>
/// Gets an array of completion strings for a given initial text.
/// </para>
/// </summary>

/// <param name="completer">
/// the filename completer.
/// </param>
/// <param name="initial_text">
/// text to be completed.
/// </param>
/// <return>
/// array of strings with possible completions for @initial_text.
/// This array must be freed by g_strfreev() when finished.
/// </return>

	public static string[] GetCompletions(this MentorLake.Gio.GFilenameCompleterHandle completer, string initial_text)
	{
		if (completer.IsInvalid) throw new Exception("Invalid handle (GFilenameCompleterHandle)");
		return GFilenameCompleterHandleExterns.g_filename_completer_get_completions(completer, initial_text);
	}

/// <summary>
/// <para>
/// If @dirs_only is %TRUE, @completer will only
/// complete directory names, and not file names.
/// </para>
/// </summary>

/// <param name="completer">
/// the filename completer.
/// </param>
/// <param name="dirs_only">
/// a #gboolean.
/// </param>

	public static T SetDirsOnly<T>(this T completer, bool dirs_only) where T : GFilenameCompleterHandle
	{
		if (completer.IsInvalid) throw new Exception("Invalid handle (GFilenameCompleterHandle)");
		GFilenameCompleterHandleExterns.g_filename_completer_set_dirs_only(completer, dirs_only);
		return completer;
	}

}

internal class GFilenameCompleterHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GFilenameCompleterHandle>))]
	internal static extern MentorLake.Gio.GFilenameCompleterHandle g_filename_completer_new();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_filename_completer_get_completion_suffix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilenameCompleterHandle>))] MentorLake.Gio.GFilenameCompleterHandle completer, string initial_text);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_filename_completer_get_completions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilenameCompleterHandle>))] MentorLake.Gio.GFilenameCompleterHandle completer, string initial_text);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_filename_completer_set_dirs_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilenameCompleterHandle>))] MentorLake.Gio.GFilenameCompleterHandle completer, bool dirs_only);

}
