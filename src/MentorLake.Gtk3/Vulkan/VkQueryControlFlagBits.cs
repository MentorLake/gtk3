namespace MentorLake.Vulkan;


public class VkQueryControlFlagBitsHandle : BaseSafeHandle
{
}


public static class VkQueryControlFlagBitsExtensions
{

	public static VkQueryControlFlagBits Dereference(this VkQueryControlFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryControlFlagBits>(x.DangerousGetHandle());
}
internal class VkQueryControlFlagBitsExterns
{
}


public struct VkQueryControlFlagBits
{
}
