namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The `GSourceFuncs` struct contains a table of
/// functions used to handle event sources in a generic manner.
/// </para>
/// <para>
/// For idle sources, the prepare and check functions always return %TRUE
/// to indicate that the source is always ready to be processed. The prepare
/// function also returns a timeout value of 0 to ensure that the poll() call
/// doesn't block (since that would be time wasted which could have been spent
/// running the idle function).
/// </para>
/// <para>
/// For timeout sources, the prepare and check functions both return %TRUE
/// if the timeout interval has expired. The prepare function also returns
/// a timeout value to ensure that the poll() call doesn't block too long
/// and miss the next timeout.
/// </para>
/// <para>
/// For file descriptor sources, the prepare function typically returns %FALSE,
/// since it must wait until poll() has been called before it knows whether
/// any events need to be processed. It sets the returned timeout to -1 to
/// indicate that it doesn't mind how long the poll() call blocks. In the
/// check function, it tests the results of the poll() call to see if the
/// required condition has been met, and returns %TRUE if so.
/// </para>
/// </summary>

public class GSourceFuncsHandle : BaseSafeHandle
{
}


public static class GSourceFuncsExtensions
{

	public static GSourceFuncs Dereference(this GSourceFuncsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSourceFuncs>(x.DangerousGetHandle());
}
internal class GSourceFuncsExterns
{
}

/// <summary>
/// <para>
/// The `GSourceFuncs` struct contains a table of
/// functions used to handle event sources in a generic manner.
/// </para>
/// <para>
/// For idle sources, the prepare and check functions always return %TRUE
/// to indicate that the source is always ready to be processed. The prepare
/// function also returns a timeout value of 0 to ensure that the poll() call
/// doesn't block (since that would be time wasted which could have been spent
/// running the idle function).
/// </para>
/// <para>
/// For timeout sources, the prepare and check functions both return %TRUE
/// if the timeout interval has expired. The prepare function also returns
/// a timeout value to ensure that the poll() call doesn't block too long
/// and miss the next timeout.
/// </para>
/// <para>
/// For file descriptor sources, the prepare function typically returns %FALSE,
/// since it must wait until poll() has been called before it knows whether
/// any events need to be processed. It sets the returned timeout to -1 to
/// indicate that it doesn't mind how long the poll() call blocks. In the
/// check function, it tests the results of the poll() call to see if the
/// required condition has been met, and returns %TRUE if so.
/// </para>
/// </summary>

public struct GSourceFuncs
{
	/// <summary>
/// <para>
/// Called before all the file descriptors are polled. If the
///     source can determine that it is ready here (without waiting for the
///     results of the poll() call) it should return %TRUE. It can also return
///     a @timeout_ value which should be the maximum timeout (in milliseconds)
///     which should be passed to the poll() call. The actual timeout used will
///     be -1 if all sources returned -1, or it will be the minimum of all
///     the @timeout_ values returned which were >= 0.  Since 2.36 this may
///     be %NULL, in which case the effect is as if the function always returns
///     %FALSE with a timeout of -1.  If @prepare returns a
///     timeout and the source also has a ready time set, then the
///     lower of the two will be used.
/// </para>
/// </summary>

public GSourceFuncsPrepareFunc prepare;
	/// <summary>
/// <para>
/// Called after all the file descriptors are polled. The source
///     should return %TRUE if it is ready to be dispatched. Note that some
///     time may have passed since the previous prepare function was called,
///     so the source should be checked again here.  Since 2.36 this may
///     be %NULL, in which case the effect is as if the function always returns
///     %FALSE.
/// </para>
/// </summary>

public GSourceFuncsCheckFunc check;
	/// <summary>
/// <para>
/// Called to dispatch the event source, after it has returned
///     %TRUE in either its @prepare or its @check function, or if a ready time
///     has been reached. The @dispatch function receives a callback function and
///     user data. The callback function may be %NULL if the source was never
///     connected to a callback using [method@GLib.Source.set_callback]. The
///     @dispatch function should call the callback function with @user_data and
///     whatever additional parameters are needed for this type of event source.
///     The return value of the @dispatch function should be
///     [const@GLib.SOURCE_REMOVE] if the source should be removed or
///     [const@GLib.SOURCE_CONTINUE] to keep it.
/// </para>
/// </summary>

public GSourceFuncsDispatchFunc dispatch;
	/// <summary>
/// <para>
/// Called when the source is finalized. At this point, the source
///     will have been destroyed, had its callback cleared, and have been removed
///     from its [struct@GLib.MainContext], but it will still have its final
///     reference count, so methods can be called on it from within this
///     function.
/// </para>
/// </summary>

public GSourceFuncsFinalizeFunc finalize;
}
