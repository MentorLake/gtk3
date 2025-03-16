namespace MentorLake.Vulkan;

public class VkShaderCreateFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkShaderCreateFlagBitsEXTExtensions
{

	public static VkShaderCreateFlagBitsEXT Dereference(this VkShaderCreateFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderCreateFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkShaderCreateFlagBitsEXTExterns
{
}

public struct VkShaderCreateFlagBitsEXT
{
}
