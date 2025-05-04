namespace MentorLake.GObject;

public class GSignalGroupHandle : GObjectHandle
{
	public static MentorLake.GObject.GSignalGroupHandle New(MentorLake.GObject.GType target_type)
	{
		return GSignalGroupHandleExterns.g_signal_group_new(target_type);
	}

}
public static class GSignalGroupHandleSignalExtensions
{

	public static IObservable<GSignalGroupHandleSignalStructs.BindSignal> Signal_Bind(this GSignalGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSignalGroupHandleSignalStructs.BindSignal> obs) =>
		{
			GSignalGroupHandleSignalDelegates.bind handler = ( MentorLake.GObject.GSignalGroupHandle self,  MentorLake.GObject.GObjectHandle instance,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSignalGroupHandleSignalStructs.BindSignal()
				{
					Self = self, Instance = instance, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "bind", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GSignalGroupHandleSignalStructs.UnbindSignal> Signal_Unbind(this GSignalGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSignalGroupHandleSignalStructs.UnbindSignal> obs) =>
		{
			GSignalGroupHandleSignalDelegates.unbind handler = ( MentorLake.GObject.GSignalGroupHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSignalGroupHandleSignalStructs.UnbindSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "unbind", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GSignalGroupHandleSignalStructs
{

public class BindSignal
{
	public MentorLake.GObject.GSignalGroupHandle Self;
	public MentorLake.GObject.GObjectHandle Instance;
	public IntPtr UserData;
}

public class UnbindSignal
{
	public MentorLake.GObject.GSignalGroupHandle Self;
	public IntPtr UserData;
}
}

public static class GSignalGroupHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unbind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, IntPtr user_data);

}


public static class GSignalGroupHandleExtensions
{
	public static T Block<T>(this T self) where T : GSignalGroupHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_block(self);
		return self;
	}

	public static T Connect<T>(this T self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data) where T : GSignalGroupHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_connect(self, detailed_signal, c_handler, data);
		return self;
	}

	public static T ConnectAfter<T>(this T self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data) where T : GSignalGroupHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_connect_after(self, detailed_signal, c_handler, data);
		return self;
	}

	public static T ConnectClosure<T>(this T self, string detailed_signal, MentorLake.GObject.GClosureHandle closure, bool after) where T : GSignalGroupHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_connect_closure(self, detailed_signal, closure, after);
		return self;
	}

	public static T ConnectData<T>(this T self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data, MentorLake.GObject.GClosureNotify notify, MentorLake.GObject.GConnectFlags flags) where T : GSignalGroupHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_connect_data(self, detailed_signal, c_handler, data, notify, flags);
		return self;
	}

	public static T ConnectObject<T>(this T self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr @object, MentorLake.GObject.GConnectFlags flags) where T : GSignalGroupHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_connect_object(self, detailed_signal, c_handler, @object, flags);
		return self;
	}

	public static T ConnectSwapped<T>(this T self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data) where T : GSignalGroupHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_connect_swapped(self, detailed_signal, c_handler, data);
		return self;
	}

	public static MentorLake.GObject.GObjectHandle DupTarget(this MentorLake.GObject.GSignalGroupHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GSignalGroupHandle)");
		return GSignalGroupHandleExterns.g_signal_group_dup_target(self);
	}

	public static T SetTarget<T>(this T self, MentorLake.GObject.GObjectHandle target) where T : GSignalGroupHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_set_target(self, target);
		return self;
	}

	public static T Unblock<T>(this T self) where T : GSignalGroupHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_unblock(self);
		return self;
	}

}

internal class GSignalGroupHandleExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GSignalGroupHandle g_signal_group_new(MentorLake.GObject.GType target_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_block([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_connect_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_connect_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, string detailed_signal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, bool after);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_connect_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data, MentorLake.GObject.GClosureNotify notify, MentorLake.GObject.GConnectFlags flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_connect_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr @object, MentorLake.GObject.GConnectFlags flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_connect_swapped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GObjectHandle g_signal_group_dup_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_set_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle target);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_unblock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self);

}
