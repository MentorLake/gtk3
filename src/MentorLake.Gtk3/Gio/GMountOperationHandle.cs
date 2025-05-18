namespace MentorLake.Gio;

public class GMountOperationHandle : GObjectHandle
{
	public static MentorLake.Gio.GMountOperationHandle New()
	{
		return GMountOperationHandleExterns.g_mount_operation_new();
	}

}
public static class GMountOperationHandleSignalExtensions
{

	public static IObservable<GMountOperationHandleSignalStructs.AbortedSignal> Signal_Aborted(this GMountOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GMountOperationHandleSignalStructs.AbortedSignal> obs) =>
		{
			GMountOperationHandleSignalDelegates.aborted handler = ( MentorLake.Gio.GMountOperationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GMountOperationHandleSignalStructs.AbortedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "aborted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GMountOperationHandleSignalStructs.AskPasswordSignal> Signal_AskPassword(this GMountOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GMountOperationHandleSignalStructs.AskPasswordSignal> obs) =>
		{
			GMountOperationHandleSignalDelegates.ask_password handler = ( MentorLake.Gio.GMountOperationHandle self,  string message,  string default_user,  string default_domain,  MentorLake.Gio.GAskPasswordFlags flags,  IntPtr user_data) =>
			{
				

				var signalStruct = new GMountOperationHandleSignalStructs.AskPasswordSignal()
				{
					Self = self, Message = message, DefaultUser = default_user, DefaultDomain = default_domain, Flags = flags, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "ask-password", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GMountOperationHandleSignalStructs.AskQuestionSignal> Signal_AskQuestion(this GMountOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GMountOperationHandleSignalStructs.AskQuestionSignal> obs) =>
		{
			GMountOperationHandleSignalDelegates.ask_question handler = ( MentorLake.Gio.GMountOperationHandle self,  string message,  string[] choices,  IntPtr user_data) =>
			{
				

				var signalStruct = new GMountOperationHandleSignalStructs.AskQuestionSignal()
				{
					Self = self, Message = message, Choices = choices, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "ask-question", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GMountOperationHandleSignalStructs.ReplySignal> Signal_Reply(this GMountOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GMountOperationHandleSignalStructs.ReplySignal> obs) =>
		{
			GMountOperationHandleSignalDelegates.reply handler = ( MentorLake.Gio.GMountOperationHandle self,  MentorLake.Gio.GMountOperationResult result,  IntPtr user_data) =>
			{
				

				var signalStruct = new GMountOperationHandleSignalStructs.ReplySignal()
				{
					Self = self, Result = result, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "reply", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GMountOperationHandleSignalStructs.ShowProcessesSignal> Signal_ShowProcesses(this GMountOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GMountOperationHandleSignalStructs.ShowProcessesSignal> obs) =>
		{
			GMountOperationHandleSignalDelegates.show_processes handler = ( MentorLake.Gio.GMountOperationHandle self,  string message,  MentorLake.GLib.GArrayHandle processes,  string[] choices,  IntPtr user_data) =>
			{
				

				var signalStruct = new GMountOperationHandleSignalStructs.ShowProcessesSignal()
				{
					Self = self, Message = message, Processes = processes, Choices = choices, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-processes", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GMountOperationHandleSignalStructs.ShowUnmountProgressSignal> Signal_ShowUnmountProgress(this GMountOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GMountOperationHandleSignalStructs.ShowUnmountProgressSignal> obs) =>
		{
			GMountOperationHandleSignalDelegates.show_unmount_progress handler = ( MentorLake.Gio.GMountOperationHandle self,  string message,  long time_left,  long bytes_left,  IntPtr user_data) =>
			{
				

				var signalStruct = new GMountOperationHandleSignalStructs.ShowUnmountProgressSignal()
				{
					Self = self, Message = message, TimeLeft = time_left, BytesLeft = bytes_left, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-unmount-progress", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GMountOperationHandleSignalStructs
{

public class AbortedSignal
{
	public MentorLake.Gio.GMountOperationHandle Self;
	public IntPtr UserData;
}

public class AskPasswordSignal
{
	public MentorLake.Gio.GMountOperationHandle Self;
	public string Message;
	public string DefaultUser;
	public string DefaultDomain;
	public MentorLake.Gio.GAskPasswordFlags Flags;
	public IntPtr UserData;
}

public class AskQuestionSignal
{
	public MentorLake.Gio.GMountOperationHandle Self;
	public string Message;
	public string[] Choices;
	public IntPtr UserData;
}

public class ReplySignal
{
	public MentorLake.Gio.GMountOperationHandle Self;
	public MentorLake.Gio.GMountOperationResult Result;
	public IntPtr UserData;
}

public class ShowProcessesSignal
{
	public MentorLake.Gio.GMountOperationHandle Self;
	public string Message;
	public MentorLake.GLib.GArrayHandle Processes;
	public string[] Choices;
	public IntPtr UserData;
}

public class ShowUnmountProgressSignal
{
	public MentorLake.Gio.GMountOperationHandle Self;
	public string Message;
	public long TimeLeft;
	public long BytesLeft;
	public IntPtr UserData;
}
}

public static class GMountOperationHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void aborted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void ask_password([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle self, string message, string default_user, string default_domain, MentorLake.Gio.GAskPasswordFlags flags, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void ask_question([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle self, string message, string[] choices, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void reply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle self, MentorLake.Gio.GMountOperationResult result, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_processes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle self, string message, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle processes, string[] choices, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_unmount_progress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle self, string message, long time_left, long bytes_left, IntPtr user_data);

}


public static class GMountOperationHandleExtensions
{
	public static bool GetAnonymous(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_anonymous(op);
	}

	public static int GetChoice(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_choice(op);
	}

	public static string GetDomain(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_domain(op);
	}

	public static bool GetIsTcryptHiddenVolume(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_is_tcrypt_hidden_volume(op);
	}

	public static bool GetIsTcryptSystemVolume(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_is_tcrypt_system_volume(op);
	}

	public static string GetPassword(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_password(op);
	}

	public static MentorLake.Gio.GPasswordSave GetPasswordSave(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_password_save(op);
	}

	public static uint GetPim(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_pim(op);
	}

	public static string GetUsername(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_username(op);
	}

	public static T Reply<T>(this T op, MentorLake.Gio.GMountOperationResult result) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_reply(op, result);
		return op;
	}

	public static T SetAnonymous<T>(this T op, bool anonymous) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_anonymous(op, anonymous);
		return op;
	}

	public static T SetChoice<T>(this T op, int choice) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_choice(op, choice);
		return op;
	}

	public static T SetDomain<T>(this T op, string domain) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_domain(op, domain);
		return op;
	}

	public static T SetIsTcryptHiddenVolume<T>(this T op, bool hidden_volume) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_is_tcrypt_hidden_volume(op, hidden_volume);
		return op;
	}

	public static T SetIsTcryptSystemVolume<T>(this T op, bool system_volume) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_is_tcrypt_system_volume(op, system_volume);
		return op;
	}

	public static T SetPassword<T>(this T op, string password) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_password(op, password);
		return op;
	}

	public static T SetPasswordSave<T>(this T op, MentorLake.Gio.GPasswordSave save) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_password_save(op, save);
		return op;
	}

	public static T SetPim<T>(this T op, uint pim) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_pim(op, pim);
		return op;
	}

	public static T SetUsername<T>(this T op, string username) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_username(op, username);
		return op;
	}

}

internal class GMountOperationHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))]
	internal static extern MentorLake.Gio.GMountOperationHandle g_mount_operation_new();

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_operation_get_anonymous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_mount_operation_get_choice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mount_operation_get_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_operation_get_is_tcrypt_hidden_volume([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_operation_get_is_tcrypt_system_volume([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mount_operation_get_password([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GPasswordSave g_mount_operation_get_password_save([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_mount_operation_get_pim([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mount_operation_get_username([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_operation_reply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op, MentorLake.Gio.GMountOperationResult result);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_operation_set_anonymous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op, bool anonymous);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_operation_set_choice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op, int choice);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_operation_set_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op, string domain);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_operation_set_is_tcrypt_hidden_volume([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op, bool hidden_volume);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_operation_set_is_tcrypt_system_volume([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op, bool system_volume);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_operation_set_password([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op, string password);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_operation_set_password_save([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op, MentorLake.Gio.GPasswordSave save);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_operation_set_pim([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op, uint pim);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_operation_set_username([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle op, string username);

}
