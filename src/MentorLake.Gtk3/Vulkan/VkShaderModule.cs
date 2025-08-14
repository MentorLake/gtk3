namespace MentorLake.Vulkan;


public class VkShaderModuleHandle : BaseSafeHandle
{
}


public static class VkShaderModuleExtensions
{

	public static VkShaderModule Dereference(this VkShaderModuleHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderModule>(x.DangerousGetHandle());
}
internal class VkShaderModuleExterns
{
}


public struct VkShaderModule
{
}
