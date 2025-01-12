namespace MentorLake.Gtk3.GObject;

public class GSignalGroupHandle : GObjectHandle
{
	public static GSignalGroupHandle New(GType target_type)
	{
		return GSignalGroupExterns.g_signal_group_new(target_type);
	}

}

public static class GSignalGroupSignalExtensions
{

	public static IObservable<GSignalGroupSignalStructs.BindSignal> Signal_Bind(this GSignalGroupHandle instance)
	{
		return Observable.Create((IObserver<GSignalGroupSignalStructs.BindSignal> obs) =>
		{
			GSignalGroupSignalDelegates.bind handler = (GSignalGroupHandle self, GObjectHandle instance, IntPtr user_data) =>
			{
				

				var signalStruct = new GSignalGroupSignalStructs.BindSignal()
				{
					Self = self, Instance = instance, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "bind", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GSignalGroupSignalStructs.UnbindSignal> Signal_Unbind(this GSignalGroupHandle instance)
	{
		return Observable.Create((IObserver<GSignalGroupSignalStructs.UnbindSignal> obs) =>
		{
			GSignalGroupSignalDelegates.unbind handler = (GSignalGroupHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GSignalGroupSignalStructs.UnbindSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "unbind", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GSignalGroupSignalStructs
{

public struct BindSignal
{
	public GSignalGroupHandle Self;
	public GObjectHandle Instance;
	public IntPtr UserData;
}

public struct UnbindSignal
{
	public GSignalGroupHandle Self;
	public IntPtr UserData;
}
}

public static class GSignalGroupSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSignalGroupHandle>))] GSignalGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle instance, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unbind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSignalGroupHandle>))] GSignalGroupHandle self, IntPtr user_data);

}


public static class GSignalGroupHandleExtensions
{
	public static T Block<T>(this T self) where T : GSignalGroupHandle
	{
		GSignalGroupExterns.g_signal_group_block(self);
		return self;
	}

	public static T Connect<T>(this T self, string detailed_signal, IntPtr c_handler, IntPtr data) where T : GSignalGroupHandle
	{
		GSignalGroupExterns.g_signal_group_connect(self, detailed_signal, c_handler, data);
		return self;
	}

	public static T ConnectAfter<T>(this T self, string detailed_signal, IntPtr c_handler, IntPtr data) where T : GSignalGroupHandle
	{
		GSignalGroupExterns.g_signal_group_connect_after(self, detailed_signal, c_handler, data);
		return self;
	}

	public static T ConnectClosure<T>(this T self, string detailed_signal, GClosureHandle closure, bool after) where T : GSignalGroupHandle
	{
		GSignalGroupExterns.g_signal_group_connect_closure(self, detailed_signal, closure, after);
		return self;
	}

	public static T ConnectData<T>(this T self, string detailed_signal, IntPtr c_handler, IntPtr data, GClosureNotify notify, GConnectFlags flags) where T : GSignalGroupHandle
	{
		GSignalGroupExterns.g_signal_group_connect_data(self, detailed_signal, c_handler, data, notify, flags);
		return self;
	}

	public static T ConnectObject<T>(this T self, string detailed_signal, IntPtr c_handler, IntPtr @object, GConnectFlags flags) where T : GSignalGroupHandle
	{
		GSignalGroupExterns.g_signal_group_connect_object(self, detailed_signal, c_handler, @object, flags);
		return self;
	}

	public static T ConnectSwapped<T>(this T self, string detailed_signal, IntPtr c_handler, IntPtr data) where T : GSignalGroupHandle
	{
		GSignalGroupExterns.g_signal_group_connect_swapped(self, detailed_signal, c_handler, data);
		return self;
	}

	public static GObjectHandle DupTarget(this GSignalGroupHandle self)
	{
		return GSignalGroupExterns.g_signal_group_dup_target(self);
	}

	public static T SetTarget<T>(this T self, GObjectHandle target) where T : GSignalGroupHandle
	{
		GSignalGroupExterns.g_signal_group_set_target(self, target);
		return self;
	}

	public static T Unblock<T>(this T self) where T : GSignalGroupHandle
	{
		GSignalGroupExterns.g_signal_group_unblock(self);
		return self;
	}

}

internal class GSignalGroupExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GSignalGroupHandle g_signal_group_new(GType target_type);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_block(GSignalGroupHandle self);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect(GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_after(GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_closure(GSignalGroupHandle self, string detailed_signal, GClosureHandle closure, bool after);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_data(GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr data, GClosureNotify notify, GConnectFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_object(GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr @object, GConnectFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_swapped(GSignalGroupHandle self, string detailed_signal, IntPtr c_handler, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_signal_group_dup_target(GSignalGroupHandle self);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_set_target(GSignalGroupHandle self, GObjectHandle target);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_unblock(GSignalGroupHandle self);

}
