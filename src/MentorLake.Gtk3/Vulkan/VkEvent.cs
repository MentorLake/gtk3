namespace MentorLake.Vulkan;


public class VkEventHandle : BaseSafeHandle
{
}


public static class VkEventExtensions
{

	public static VkEvent Dereference(this VkEventHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkEvent>(x.DangerousGetHandle());
}
internal class VkEventExterns
{
}


public struct VkEvent
{
}
