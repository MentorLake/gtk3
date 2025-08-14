namespace MentorLake.Vulkan;


public class VkEventCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkEventCreateFlagBitsExtensions
{

	public static VkEventCreateFlagBits Dereference(this VkEventCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkEventCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkEventCreateFlagBitsExterns
{
}


public struct VkEventCreateFlagBits
{
}
