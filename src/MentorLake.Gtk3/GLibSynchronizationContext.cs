using MentorLake.GLib;

namespace MentorLake.Gtk3;

public class GLibSynchronizationContext : SynchronizationContext
{
	public override void Post(SendOrPostCallback d, object state)
	{
		GLibGlobalFunctions.IdleAddFull(0, _ =>
		{
			d(state);
			return false;
		}, IntPtr.Zero, null);
	}
}
