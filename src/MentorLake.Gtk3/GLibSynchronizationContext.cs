using GCHandle = System.Runtime.InteropServices.GCHandle;

namespace MentorLake.Gtk3;

public class GLibSynchronizationContext(int callbackPriority = 0) : SynchronizationContext
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
		GLibGlobalFunctions.IdleAddFull(callbackPriority, f, IntPtr.Zero, null);
	}
}
