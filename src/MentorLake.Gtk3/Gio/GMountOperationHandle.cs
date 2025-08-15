namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GMountOperation` provides a mechanism for interacting with the user.
/// It can be used for authenticating mountable operations, such as loop
/// mounting files, hard drive partitions or server locations. It can
/// also be used to ask the user questions or show a list of applications
/// preventing unmount or eject operations from completing.
/// </para>
/// <para>
/// Note that `GMountOperation` is used for more than just [iface@Gio.Mount]
/// objects – for example it is also used in [method@Gio.Drive.start] and
/// [method@Gio.Drive.stop].
/// </para>
/// <para>
/// Users should instantiate a subclass of this that implements all the
/// various callbacks to show the required dialogs, such as
/// &amp;lt;see href=&quot;https://docs.gtk.org/gtk4/class.MountOperation.html&quot;&amp;gt;GtkMountOperation&amp;lt;/see&amp;gt;.
/// If no user interaction is desired (for example when automounting
/// filesystems at login time), usually `NULL` can be passed, see each method
/// taking a `GMountOperation` for details.
/// </para>
/// <para>
/// Throughout the API, the term ‘TCRYPT’ is used to mean ‘compatible with TrueCrypt and VeraCrypt’.
/// [TrueCrypt](https://en.wikipedia.org/wiki/TrueCrypt) is a discontinued system for
/// encrypting file containers, partitions or whole disks, typically used with Windows.
/// [VeraCrypt](https://www.veracrypt.fr/) is a maintained fork of TrueCrypt with various
/// improvements and auditing fixes.
/// </para>
/// </summary>

public class GMountOperationHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new mount operation.
/// </para>
/// </summary>

/// <return>
/// a #GMountOperation.
/// </return>

	public static MentorLake.Gio.GMountOperationHandle New()
	{
		return GMountOperationHandleExterns.g_mount_operation_new();
	}

}
public static class GMountOperationHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted by the backend when e.g. a device becomes unavailable
/// while a mount operation is in progress.
/// </para>
/// <para>
/// Implementations of GMountOperation should handle this signal
/// by dismissing open password dialogs.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when a mount operation asks the user for a password.
/// </para>
/// <para>
/// If the message contains a line break, the first line should be
/// presented as a heading. For example, it may be used as the
/// primary text in a #GtkMessageDialog.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when asking the user a question and gives a list of
/// choices for the user to choose from.
/// </para>
/// <para>
/// If the message contains a line break, the first line should be
/// presented as a heading. For example, it may be used as the
/// primary text in a #GtkMessageDialog.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when the user has replied to the mount operation.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when one or more processes are blocking an operation
/// e.g. unmounting/ejecting a #GMount or stopping a #GDrive.
/// </para>
/// <para>
/// Note that this signal may be emitted several times to update the
/// list of blocking processes as processes close files. The
/// application should only respond with g_mount_operation_reply() to
/// the latest signal (setting #GMountOperation:choice to the choice
/// the user made).
/// </para>
/// <para>
/// If the message contains a line break, the first line should be
/// presented as a heading. For example, it may be used as the
/// primary text in a #GtkMessageDialog.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when an unmount operation has been busy for more than some time
/// (typically 1.5 seconds).
/// </para>
/// <para>
/// When unmounting or ejecting a volume, the kernel might need to flush
/// pending data in its buffers to the volume stable storage, and this operation
/// can take a considerable amount of time. This signal may be emitted several
/// times as long as the unmount operation is outstanding, and then one
/// last time when the operation is completed, with @bytes_left set to zero.
/// </para>
/// <para>
/// Implementations of GMountOperation should handle this signal by
/// showing an UI notification, and then dismiss it, or show another notification
/// of completion, when @bytes_left reaches zero.
/// </para>
/// <para>
/// If the message contains a line break, the first line should be
/// presented as a heading. For example, it may be used as the
/// primary text in a #GtkMessageDialog.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// string containing a message to display to the user.
/// </para>
/// </summary>

	public string Message;
/// <summary>
/// <para>
/// string containing the default user name.
/// </para>
/// </summary>

	public string DefaultUser;
/// <summary>
/// <para>
/// string containing the default domain.
/// </para>
/// </summary>

	public string DefaultDomain;
/// <summary>
/// <para>
/// a set of #GAskPasswordFlags.
/// </para>
/// </summary>

	public MentorLake.Gio.GAskPasswordFlags Flags;

	public IntPtr UserData;
}

public class AskQuestionSignal
{

	public MentorLake.Gio.GMountOperationHandle Self;
/// <summary>
/// <para>
/// string containing a message to display to the user.
/// </para>
/// </summary>

	public string Message;
/// <summary>
/// <para>
/// an array of strings for each possible choice.
/// </para>
/// </summary>

	public string[] Choices;

	public IntPtr UserData;
}

public class ReplySignal
{

	public MentorLake.Gio.GMountOperationHandle Self;
/// <summary>
/// <para>
/// a #GMountOperationResult indicating how the request was handled
/// </para>
/// </summary>

	public MentorLake.Gio.GMountOperationResult Result;

	public IntPtr UserData;
}

public class ShowProcessesSignal
{

	public MentorLake.Gio.GMountOperationHandle Self;
/// <summary>
/// <para>
/// string containing a message to display to the user.
/// </para>
/// </summary>

	public string Message;
/// <summary>
/// <para>
/// an array of #GPid for processes
///   blocking the operation.
/// </para>
/// </summary>

	public MentorLake.GLib.GArrayHandle Processes;
/// <summary>
/// <para>
/// an array of strings for each possible choice.
/// </para>
/// </summary>

	public string[] Choices;

	public IntPtr UserData;
}

public class ShowUnmountProgressSignal
{

	public MentorLake.Gio.GMountOperationHandle Self;
/// <summary>
/// <para>
/// string containing a message to display to the user
/// </para>
/// </summary>

	public string Message;
/// <summary>
/// <para>
/// the estimated time left before the operation completes,
///     in microseconds, or -1
/// </para>
/// </summary>

	public long TimeLeft;
/// <summary>
/// <para>
/// the amount of bytes to be written before the operation
///     completes (or -1 if such amount is not known), or zero if the operation
///     is completed
/// </para>
/// </summary>

	public long BytesLeft;

	public IntPtr UserData;
}
}

public static class GMountOperationHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted by the backend when e.g. a device becomes unavailable
/// while a mount operation is in progress.
/// </para>
/// <para>
/// Implementations of GMountOperation should handle this signal
/// by dismissing open password dialogs.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void aborted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a mount operation asks the user for a password.
/// </para>
/// <para>
/// If the message contains a line break, the first line should be
/// presented as a heading. For example, it may be used as the
/// primary text in a #GtkMessageDialog.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="message">
/// string containing a message to display to the user.
/// </param>
/// <param name="default_user">
/// string containing the default user name.
/// </param>
/// <param name="default_domain">
/// string containing the default domain.
/// </param>
/// <param name="flags">
/// a set of #GAskPasswordFlags.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void ask_password([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle self, string message, string default_user, string default_domain, MentorLake.Gio.GAskPasswordFlags flags, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when asking the user a question and gives a list of
/// choices for the user to choose from.
/// </para>
/// <para>
/// If the message contains a line break, the first line should be
/// presented as a heading. For example, it may be used as the
/// primary text in a #GtkMessageDialog.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="message">
/// string containing a message to display to the user.
/// </param>
/// <param name="choices">
/// an array of strings for each possible choice.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void ask_question([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle self, string message, string[] choices, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the user has replied to the mount operation.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="result">
/// a #GMountOperationResult indicating how the request was handled
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void reply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle self, MentorLake.Gio.GMountOperationResult result, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when one or more processes are blocking an operation
/// e.g. unmounting/ejecting a #GMount or stopping a #GDrive.
/// </para>
/// <para>
/// Note that this signal may be emitted several times to update the
/// list of blocking processes as processes close files. The
/// application should only respond with g_mount_operation_reply() to
/// the latest signal (setting #GMountOperation:choice to the choice
/// the user made).
/// </para>
/// <para>
/// If the message contains a line break, the first line should be
/// presented as a heading. For example, it may be used as the
/// primary text in a #GtkMessageDialog.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="message">
/// string containing a message to display to the user.
/// </param>
/// <param name="processes">
/// an array of #GPid for processes
///   blocking the operation.
/// </param>
/// <param name="choices">
/// an array of strings for each possible choice.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_processes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle self, string message, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle processes, string[] choices, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when an unmount operation has been busy for more than some time
/// (typically 1.5 seconds).
/// </para>
/// <para>
/// When unmounting or ejecting a volume, the kernel might need to flush
/// pending data in its buffers to the volume stable storage, and this operation
/// can take a considerable amount of time. This signal may be emitted several
/// times as long as the unmount operation is outstanding, and then one
/// last time when the operation is completed, with @bytes_left set to zero.
/// </para>
/// <para>
/// Implementations of GMountOperation should handle this signal by
/// showing an UI notification, and then dismiss it, or show another notification
/// of completion, when @bytes_left reaches zero.
/// </para>
/// <para>
/// If the message contains a line break, the first line should be
/// presented as a heading. For example, it may be used as the
/// primary text in a #GtkMessageDialog.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="message">
/// string containing a message to display to the user
/// </param>
/// <param name="time_left">
/// the estimated time left before the operation completes,
///     in microseconds, or -1
/// </param>
/// <param name="bytes_left">
/// the amount of bytes to be written before the operation
///     completes (or -1 if such amount is not known), or zero if the operation
///     is completed
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_unmount_progress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle self, string message, long time_left, long bytes_left, IntPtr user_data);

}


public static class GMountOperationHandleExtensions
{
/// <summary>
/// <para>
/// Check to see whether the mount operation is being used
/// for an anonymous user.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <return>
/// %TRUE if mount operation is anonymous.
/// </return>

	public static bool GetAnonymous(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_anonymous(op);
	}

/// <summary>
/// <para>
/// Gets a choice from the mount operation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <return>
/// an integer containing an index of the user&apos;s choice from
/// the choice&apos;s list, or `0`.
/// </return>

	public static int GetChoice(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_choice(op);
	}

/// <summary>
/// <para>
/// Gets the domain of the mount operation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <return>
/// a string set to the domain.
/// </return>

	public static string GetDomain(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_domain(op);
	}

/// <summary>
/// <para>
/// Check to see whether the mount operation is being used
/// for a TCRYPT hidden volume.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <return>
/// %TRUE if mount operation is for hidden volume.
/// </return>

	public static bool GetIsTcryptHiddenVolume(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_is_tcrypt_hidden_volume(op);
	}

/// <summary>
/// <para>
/// Check to see whether the mount operation is being used
/// for a TCRYPT system volume.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <return>
/// %TRUE if mount operation is for system volume.
/// </return>

	public static bool GetIsTcryptSystemVolume(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_is_tcrypt_system_volume(op);
	}

/// <summary>
/// <para>
/// Gets a password from the mount operation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <return>
/// a string containing the password within @op.
/// </return>

	public static string GetPassword(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_password(op);
	}

/// <summary>
/// <para>
/// Gets the state of saving passwords for the mount operation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <return>
/// a #GPasswordSave flag.
/// </return>

	public static MentorLake.Gio.GPasswordSave GetPasswordSave(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_password_save(op);
	}

/// <summary>
/// <para>
/// Gets a PIM from the mount operation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <return>
/// The VeraCrypt PIM within @op.
/// </return>

	public static uint GetPim(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_pim(op);
	}

/// <summary>
/// <para>
/// Get the user name from the mount operation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <return>
/// a string containing the user name.
/// </return>

	public static string GetUsername(this MentorLake.Gio.GMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		return GMountOperationHandleExterns.g_mount_operation_get_username(op);
	}

/// <summary>
/// <para>
/// Emits the #GMountOperation::reply signal.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation
/// </param>
/// <param name="result">
/// a #GMountOperationResult
/// </param>

	public static T Reply<T>(this T op, MentorLake.Gio.GMountOperationResult result) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_reply(op, result);
		return op;
	}

/// <summary>
/// <para>
/// Sets the mount operation to use an anonymous user if @anonymous is %TRUE.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <param name="anonymous">
/// boolean value.
/// </param>

	public static T SetAnonymous<T>(this T op, bool anonymous) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_anonymous(op, anonymous);
		return op;
	}

/// <summary>
/// <para>
/// Sets a default choice for the mount operation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <param name="choice">
/// an integer.
/// </param>

	public static T SetChoice<T>(this T op, int choice) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_choice(op, choice);
		return op;
	}

/// <summary>
/// <para>
/// Sets the mount operation&apos;s domain.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <param name="domain">
/// the domain to set.
/// </param>

	public static T SetDomain<T>(this T op, string domain) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_domain(op, domain);
		return op;
	}

/// <summary>
/// <para>
/// Sets the mount operation to use a hidden volume if @hidden_volume is %TRUE.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <param name="hidden_volume">
/// boolean value.
/// </param>

	public static T SetIsTcryptHiddenVolume<T>(this T op, bool hidden_volume) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_is_tcrypt_hidden_volume(op, hidden_volume);
		return op;
	}

/// <summary>
/// <para>
/// Sets the mount operation to use a system volume if @system_volume is %TRUE.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <param name="system_volume">
/// boolean value.
/// </param>

	public static T SetIsTcryptSystemVolume<T>(this T op, bool system_volume) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_is_tcrypt_system_volume(op, system_volume);
		return op;
	}

/// <summary>
/// <para>
/// Sets the mount operation&apos;s password to @password.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <param name="password">
/// password to set.
/// </param>

	public static T SetPassword<T>(this T op, string password) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_password(op, password);
		return op;
	}

/// <summary>
/// <para>
/// Sets the state of saving passwords for the mount operation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <param name="save">
/// a set of #GPasswordSave flags.
/// </param>

	public static T SetPasswordSave<T>(this T op, MentorLake.Gio.GPasswordSave save) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_password_save(op, save);
		return op;
	}

/// <summary>
/// <para>
/// Sets the mount operation&apos;s PIM to @pim.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <param name="pim">
/// an unsigned integer.
/// </param>

	public static T SetPim<T>(this T op, uint pim) where T : GMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GMountOperationHandle)");
		GMountOperationHandleExterns.g_mount_operation_set_pim(op, pim);
		return op;
	}

/// <summary>
/// <para>
/// Sets the user name within @op to @username.
/// </para>
/// </summary>

/// <param name="op">
/// a #GMountOperation.
/// </param>
/// <param name="username">
/// input username.
/// </param>

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
