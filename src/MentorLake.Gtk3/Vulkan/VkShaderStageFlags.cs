namespace MentorLake.Vulkan;


public class VkShaderStageFlagsHandle : BaseSafeHandle
{
}


public static class VkShaderStageFlagsExtensions
{

	public static VkShaderStageFlags Dereference(this VkShaderStageFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderStageFlags>(x.DangerousGetHandle());
}
internal class VkShaderStageFlagsExterns
{
}


public struct VkShaderStageFlags
{
}
