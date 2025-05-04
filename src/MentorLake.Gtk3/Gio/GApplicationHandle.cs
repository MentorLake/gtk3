namespace MentorLake.Gio;

public class GApplicationHandle : GObjectHandle, GActionGroupHandle, GActionMapHandle
{
	public static MentorLake.Gio.GApplicationHandle New(string application_id, MentorLake.Gio.GApplicationFlags flags)
	{
		return GApplicationHandleExterns.g_application_new(application_id, flags);
	}

	public static MentorLake.Gio.GApplicationHandle GetDefault()
	{
		return GApplicationHandleExterns.g_application_get_default();
	}

	public static bool IdIsValid(string application_id)
	{
		return GApplicationHandleExterns.g_application_id_is_valid(application_id);
	}

}
public static class GApplicationHandleSignalExtensions
{

	public static IObservable<GApplicationHandleSignalStructs.ActivateSignal> Signal_Activate(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.ActivateSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.activate handler = ( MentorLake.Gio.GApplicationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GApplicationHandleSignalStructs.CommandLineSignal> Signal_CommandLine(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.CommandLineSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.command_line handler = ( MentorLake.Gio.GApplicationHandle self,  MentorLake.Gio.GApplicationCommandLineHandle command_line,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.CommandLineSignal()
				{
					Self = self, CommandLine = command_line, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "command-line", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GApplicationHandleSignalStructs.HandleLocalOptionsSignal> Signal_HandleLocalOptions(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.HandleLocalOptionsSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.handle_local_options handler = ( MentorLake.Gio.GApplicationHandle self,  MentorLake.GLib.GVariantDictHandle options,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.HandleLocalOptionsSignal()
				{
					Self = self, Options = options, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "handle-local-options", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GApplicationHandleSignalStructs.NameLostSignal> Signal_NameLost(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.NameLostSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.name_lost handler = ( MentorLake.Gio.GApplicationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.NameLostSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "name-lost", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GApplicationHandleSignalStructs.OpenSignal> Signal_Open(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.OpenSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.open handler = ( MentorLake.Gio.GApplicationHandle self,  MentorLake.Gio.GFileHandle[] files,  int n_files,  string hint,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.OpenSignal()
				{
					Self = self, Files = files, NFiles = n_files, Hint = hint, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "open", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GApplicationHandleSignalStructs.ShutdownSignal> Signal_Shutdown(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.ShutdownSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.shutdown handler = ( MentorLake.Gio.GApplicationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.ShutdownSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "shutdown", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GApplicationHandleSignalStructs.StartupSignal> Signal_Startup(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.StartupSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.startup handler = ( MentorLake.Gio.GApplicationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.StartupSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "startup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GApplicationHandleSignalStructs.ActionAddedSignal> Signal_ActionAdded(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.ActionAddedSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.action_added handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.ActionAddedSignal()
				{
					Self = self, ActionName = action_name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GApplicationHandleSignalStructs.ActionEnabledChangedSignal> Signal_ActionEnabledChanged(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.ActionEnabledChangedSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.action_enabled_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  bool enabled,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.ActionEnabledChangedSignal()
				{
					Self = self, ActionName = action_name, Enabled = enabled, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-enabled-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GApplicationHandleSignalStructs.ActionRemovedSignal> Signal_ActionRemoved(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.ActionRemovedSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.action_removed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.ActionRemovedSignal()
				{
					Self = self, ActionName = action_name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GApplicationHandleSignalStructs.ActionStateChangedSignal> Signal_ActionStateChanged(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.ActionStateChangedSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.action_state_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  MentorLake.GLib.GVariantHandle value,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.ActionStateChangedSignal()
				{
					Self = self, ActionName = action_name, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-state-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GApplicationHandleSignalStructs
{

public class ActivateSignal
{
	public MentorLake.Gio.GApplicationHandle Self;
	public IntPtr UserData;
}

public class CommandLineSignal
{
	public MentorLake.Gio.GApplicationHandle Self;
	public MentorLake.Gio.GApplicationCommandLineHandle CommandLine;
	public IntPtr UserData;
	public int ReturnValue;
}

public class HandleLocalOptionsSignal
{
	public MentorLake.Gio.GApplicationHandle Self;
	public MentorLake.GLib.GVariantDictHandle Options;
	public IntPtr UserData;
	public int ReturnValue;
}

public class NameLostSignal
{
	public MentorLake.Gio.GApplicationHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class OpenSignal
{
	public MentorLake.Gio.GApplicationHandle Self;
	public MentorLake.Gio.GFileHandle[] Files;
	public int NFiles;
	public string Hint;
	public IntPtr UserData;
}

public class ShutdownSignal
{
	public MentorLake.Gio.GApplicationHandle Self;
	public IntPtr UserData;
}

public class StartupSignal
{
	public MentorLake.Gio.GApplicationHandle Self;
	public IntPtr UserData;
}

public class ActionAddedSignal
{
	public MentorLake.Gio.GActionGroupHandle Self;
	public string ActionName;
	public IntPtr UserData;
}

public class ActionEnabledChangedSignal
{
	public MentorLake.Gio.GActionGroupHandle Self;
	public string ActionName;
	public bool Enabled;
	public IntPtr UserData;
}

public class ActionRemovedSignal
{
	public MentorLake.Gio.GActionGroupHandle Self;
	public string ActionName;
	public IntPtr UserData;
}

public class ActionStateChangedSignal
{
	public MentorLake.Gio.GActionGroupHandle Self;
	public string ActionName;
	public MentorLake.GLib.GVariantHandle Value;
	public IntPtr UserData;
}
}

public static class GApplicationHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int command_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle command_line, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int handle_local_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle options, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool name_lost([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void open([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle self, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle[] files, int n_files, string hint, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void shutdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void startup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_enabled_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, bool enabled, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, IntPtr user_data);

}


public static class GApplicationHandleExtensions
{
	public static T Activate<T>(this T application) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_activate(application);
		return application;
	}

	public static T AddMainOption<T>(this T application, string long_name, char short_name, MentorLake.GLib.GOptionFlags flags, MentorLake.GLib.GOptionArg arg, string description, string arg_description) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_add_main_option(application, long_name, short_name, flags, arg, description, arg_description);
		return application;
	}

	public static T AddMainOptionEntries<T>(this T application, MentorLake.GLib.GOptionEntryHandle[] entries) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_add_main_option_entries(application, entries);
		return application;
	}

	public static T AddOptionGroup<T>(this T application, MentorLake.GLib.GOptionGroupHandle group) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_add_option_group(application, group);
		return application;
	}

	public static T BindBusyProperty<T>(this T application, MentorLake.GObject.GObjectHandle @object, string property) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_bind_busy_property(application, @object, property);
		return application;
	}

	public static string GetApplicationId(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_application_id(application);
	}

	public static MentorLake.Gio.GDBusConnectionHandle GetDbusConnection(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_dbus_connection(application);
	}

	public static string GetDbusObjectPath(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_dbus_object_path(application);
	}

	public static MentorLake.Gio.GApplicationFlags GetFlags(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_flags(application);
	}

	public static uint GetInactivityTimeout(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_inactivity_timeout(application);
	}

	public static bool GetIsBusy(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_is_busy(application);
	}

	public static bool GetIsRegistered(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_is_registered(application);
	}

	public static bool GetIsRemote(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_is_remote(application);
	}

	public static string GetResourceBasePath(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_resource_base_path(application);
	}

	public static string GetVersion(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_version(application);
	}

	public static T Hold<T>(this T application) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_hold(application);
		return application;
	}

	public static T MarkBusy<T>(this T application) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_mark_busy(application);
		return application;
	}

	public static T Open<T>(this T application, MentorLake.Gio.GFileHandle[] files, int n_files, string hint) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_open(application, files, n_files, hint);
		return application;
	}

	public static T Quit<T>(this T application) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_quit(application);
		return application;
	}

	public static bool Register(this MentorLake.Gio.GApplicationHandle application, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		var externCallResult = GApplicationHandleExterns.g_application_register(application, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T Release<T>(this T application) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_release(application);
		return application;
	}

	public static int Run(this MentorLake.Gio.GApplicationHandle application, int argc, string[] argv)
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_run(application, argc, argv);
	}

	public static T SendNotification<T>(this T application, string id, MentorLake.Gio.GNotificationHandle notification) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_send_notification(application, id, notification);
		return application;
	}

	public static T SetActionGroup<T>(this T application, MentorLake.Gio.GActionGroupHandle action_group) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_action_group(application, action_group);
		return application;
	}

	public static T SetApplicationId<T>(this T application, string application_id) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_application_id(application, application_id);
		return application;
	}

	public static T SetDefault<T>(this T application) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_default(application);
		return application;
	}

	public static T SetFlags<T>(this T application, MentorLake.Gio.GApplicationFlags flags) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_flags(application, flags);
		return application;
	}

	public static T SetInactivityTimeout<T>(this T application, uint inactivity_timeout) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_inactivity_timeout(application, inactivity_timeout);
		return application;
	}

	public static T SetOptionContextDescription<T>(this T application, string description) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_option_context_description(application, description);
		return application;
	}

	public static T SetOptionContextParameterString<T>(this T application, string parameter_string) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_option_context_parameter_string(application, parameter_string);
		return application;
	}

	public static T SetOptionContextSummary<T>(this T application, string summary) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_option_context_summary(application, summary);
		return application;
	}

	public static T SetResourceBasePath<T>(this T application, string resource_path) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_resource_base_path(application, resource_path);
		return application;
	}

	public static T SetVersion<T>(this T application, string version) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_version(application, version);
		return application;
	}

	public static T UnbindBusyProperty<T>(this T application, MentorLake.GObject.GObjectHandle @object, string property) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_unbind_busy_property(application, @object, property);
		return application;
	}

	public static T UnmarkBusy<T>(this T application) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_unmark_busy(application);
		return application;
	}

	public static T WithdrawNotification<T>(this T application, string id) where T : GApplicationHandle
	{
		if (application.IsInvalid || application.IsClosed) throw new Exception("Invalid or closed handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_withdraw_notification(application, id);
		return application;
	}

}

internal class GApplicationHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GApplicationHandle g_application_new(string application_id, MentorLake.Gio.GApplicationFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_add_main_option([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string long_name, char short_name, MentorLake.GLib.GOptionFlags flags, MentorLake.GLib.GOptionArg arg, string description, string arg_description);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_add_main_option_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 0, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionEntryHandle>))] MentorLake.GLib.GOptionEntryHandle[] entries);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_add_option_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_bind_busy_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_application_get_application_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_application_get_dbus_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_application_get_dbus_object_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GApplicationFlags g_application_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_application_get_inactivity_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_application_get_is_busy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_application_get_is_registered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_application_get_is_remote([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_application_get_resource_base_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_application_get_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_hold([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_mark_busy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_open([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle[] files, int n_files, string hint);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_quit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_application_register([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_application_run([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, int argc, string[] argv);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_send_notification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))] MentorLake.Gio.GNotificationHandle notification);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_action_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_application_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string application_id);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, MentorLake.Gio.GApplicationFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_inactivity_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, uint inactivity_timeout);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_option_context_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string description);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_option_context_parameter_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string parameter_string);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_option_context_summary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string summary);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_resource_base_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string resource_path);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string version);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_unbind_busy_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_unmark_busy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_withdraw_notification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string id);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GApplicationHandle g_application_get_default();

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_application_id_is_valid(string application_id);

}
