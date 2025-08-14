namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A `GThreadedSocketService` is a simple subclass of [class@Gio.SocketService]
/// that handles incoming connections by creating a worker thread and
/// dispatching the connection to it by emitting the
/// [signal@Gio.ThreadedSocketService::run signal] in the new thread.
/// </para>
/// <para>
/// The signal handler may perform blocking I/O and need not return
/// until the connection is closed.
/// </para>
/// <para>
/// The service is implemented using a thread pool, so there is a
/// limited amount of threads available to serve incoming requests.
/// The service automatically stops the [class@Gio.SocketService] from accepting
/// new connections when all threads are busy.
/// </para>
/// <para>
/// As with [class@Gio.SocketService], you may connect to
/// [signal@Gio.ThreadedSocketService::run], or subclass and override the default
/// handler.
/// </para>
/// </summary>

public class GThreadedSocketServiceHandle : GSocketServiceHandle
{
/// <summary>
/// <para>
/// Creates a new #GThreadedSocketService with no listeners. Listeners
/// must be added with one of the #GSocketListener "add" methods.
/// </para>
/// </summary>

/// <param name="max_threads">
/// the maximal number of threads to execute concurrently
///   handling incoming clients, -1 means no limit
/// </param>
/// <return>
/// a new #GSocketService.
/// </return>

	public static MentorLake.Gio.GThreadedSocketServiceHandle New(int max_threads)
	{
		return GThreadedSocketServiceHandleExterns.g_threaded_socket_service_new(max_threads);
	}

}
public static class GThreadedSocketServiceHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::run signal is emitted in a worker thread in response to an
/// incoming connection. This thread is dedicated to handling
/// @connection and may perform blocking IO. The signal handler need
/// not return until the connection is closed.
/// </para>
/// </summary>

	public static IObservable<GThreadedSocketServiceHandleSignalStructs.RunSignal> Signal_Run(this GThreadedSocketServiceHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GThreadedSocketServiceHandleSignalStructs.RunSignal> obs) =>
		{
			GThreadedSocketServiceHandleSignalDelegates.run handler = ( MentorLake.Gio.GThreadedSocketServiceHandle self,  MentorLake.Gio.GSocketConnectionHandle connection,  MentorLake.GObject.GObjectHandle source_object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GThreadedSocketServiceHandleSignalStructs.RunSignal()
				{
					Self = self, Connection = connection, SourceObject = source_object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "run", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GThreadedSocketServiceHandleSignalStructs
{

public class RunSignal
{

	public MentorLake.Gio.GThreadedSocketServiceHandle Self;
/// <summary>
/// <para>
/// a new #GSocketConnection object.
/// </para>
/// </summary>

	public MentorLake.Gio.GSocketConnectionHandle Connection;
/// <summary>
/// <para>
/// the source_object passed to g_socket_listener_add_address().
/// </para>
/// </summary>

	public MentorLake.GObject.GObjectHandle SourceObject;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop further signal handlers from being called
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class GThreadedSocketServiceHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::run signal is emitted in a worker thread in response to an
/// incoming connection. This thread is dedicated to handling
/// @connection and may perform blocking IO. The signal handler need
/// not return until the connection is closed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="connection">
/// a new #GSocketConnection object.
/// </param>
/// <param name="source_object">
/// the source_object passed to g_socket_listener_add_address().
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop further signal handlers from being called
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool run([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GThreadedSocketServiceHandle>))] MentorLake.Gio.GThreadedSocketServiceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, IntPtr user_data);

}


public static class GThreadedSocketServiceHandleExtensions
{
}

internal class GThreadedSocketServiceHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GThreadedSocketServiceHandle>))]
	internal static extern MentorLake.Gio.GThreadedSocketServiceHandle g_threaded_socket_service_new(int max_threads);

}
