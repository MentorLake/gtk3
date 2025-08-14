namespace MentorLake.Vulkan;


public class VkShaderEXTHandle : BaseSafeHandle
{
}


public static class VkShaderEXTExtensions
{

	public static VkShaderEXT Dereference(this VkShaderEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderEXT>(x.DangerousGetHandle());
}
internal class VkShaderEXTExterns
{
}


public struct VkShaderEXT
{
}
