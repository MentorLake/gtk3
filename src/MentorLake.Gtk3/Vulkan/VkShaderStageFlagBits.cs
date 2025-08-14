namespace MentorLake.Vulkan;


public class VkShaderStageFlagBitsHandle : BaseSafeHandle
{
}


public static class VkShaderStageFlagBitsExtensions
{

	public static VkShaderStageFlagBits Dereference(this VkShaderStageFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderStageFlagBits>(x.DangerousGetHandle());
}
internal class VkShaderStageFlagBitsExterns
{
}


public struct VkShaderStageFlagBits
{
}
