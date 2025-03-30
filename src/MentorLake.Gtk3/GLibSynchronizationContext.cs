using GCHandle = System.Runtime.InteropServices.GCHandle;

namespace MentorLake.Gtk3;

public class GLibSynchronizationContext : SynchronizationContext
{
	public override void Post(SendOrPostCallback d, object state)
	{
		GCHandle gcHandle = new();

		GSourceFunc f = _ =>
		{
			d(state);
			gcHandle.Free();
			return false;
		};

		gcHandle = GCHandle.Alloc(f);
		GLibGlobalFunctions.IdleAddFull(0, f, IntPtr.Zero, null);
	}
}
