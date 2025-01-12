using MentorLake.Gtk3.GLib;

namespace MentorLake.Gtk3;

public class GLibSynchronizationContext : SynchronizationContext
{
	public override void Post(SendOrPostCallback d, object state)
	{
		GLibGlobalFunctions.g_idle_add_full(0, _ =>
		{
			d(state);
			return false;
		}, IntPtr.Zero, null);
	}
}
