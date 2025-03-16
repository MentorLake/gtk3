namespace MentorLake.Gio;

public class GFilenameCompleterHandle : GObjectHandle
{
	public static MentorLake.Gio.GFilenameCompleterHandle New()
	{
		return GFilenameCompleterHandleExterns.g_filename_completer_new();
	}

}
public static class GFilenameCompleterHandleSignalExtensions
{

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

public struct GotCompletionDataSignal
{
	public MentorLake.Gio.GFilenameCompleterHandle Self;
	public IntPtr UserData;
}
}

public static class GFilenameCompleterHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void got_completion_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilenameCompleterHandle>))] MentorLake.Gio.GFilenameCompleterHandle self, IntPtr user_data);

}


public static class GFilenameCompleterHandleExtensions
{
	public static string GetCompletionSuffix(this MentorLake.Gio.GFilenameCompleterHandle completer, string initial_text)
	{
		return GFilenameCompleterHandleExterns.g_filename_completer_get_completion_suffix(completer, initial_text);
	}

	public static string[] GetCompletions(this MentorLake.Gio.GFilenameCompleterHandle completer, string initial_text)
	{
		return GFilenameCompleterHandleExterns.g_filename_completer_get_completions(completer, initial_text);
	}

	public static T SetDirsOnly<T>(this T completer, bool dirs_only) where T : GFilenameCompleterHandle
	{
		GFilenameCompleterHandleExterns.g_filename_completer_set_dirs_only(completer, dirs_only);
		return completer;
	}

}

internal class GFilenameCompleterHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFilenameCompleterHandle g_filename_completer_new();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_filename_completer_get_completion_suffix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilenameCompleterHandle>))] MentorLake.Gio.GFilenameCompleterHandle completer, string initial_text);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_filename_completer_get_completions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilenameCompleterHandle>))] MentorLake.Gio.GFilenameCompleterHandle completer, string initial_text);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_filename_completer_set_dirs_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilenameCompleterHandle>))] MentorLake.Gio.GFilenameCompleterHandle completer, bool dirs_only);

}
