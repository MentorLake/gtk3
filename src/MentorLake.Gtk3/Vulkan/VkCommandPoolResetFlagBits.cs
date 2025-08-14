namespace MentorLake.Vulkan;


public class VkCommandPoolResetFlagBitsHandle : BaseSafeHandle
{
}


public static class VkCommandPoolResetFlagBitsExtensions
{

	public static VkCommandPoolResetFlagBits Dereference(this VkCommandPoolResetFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandPoolResetFlagBits>(x.DangerousGetHandle());
}
internal class VkCommandPoolResetFlagBitsExterns
{
}


public struct VkCommandPoolResetFlagBits
{
}
