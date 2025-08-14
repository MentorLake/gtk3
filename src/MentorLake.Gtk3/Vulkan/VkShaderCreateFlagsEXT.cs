namespace MentorLake.Vulkan;


public class VkShaderCreateFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkShaderCreateFlagsEXTExtensions
{

	public static VkShaderCreateFlagsEXT Dereference(this VkShaderCreateFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderCreateFlagsEXT>(x.DangerousGetHandle());
}
internal class VkShaderCreateFlagsEXTExterns
{
}


public struct VkShaderCreateFlagsEXT
{
}
