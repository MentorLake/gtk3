namespace MentorLake.Vulkan;


public class VkCommandPoolCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkCommandPoolCreateFlagBitsExtensions
{

	public static VkCommandPoolCreateFlagBits Dereference(this VkCommandPoolCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandPoolCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkCommandPoolCreateFlagBitsExterns
{
}


public struct VkCommandPoolCreateFlagBits
{
}
