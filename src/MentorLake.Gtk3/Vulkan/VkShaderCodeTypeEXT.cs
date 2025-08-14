namespace MentorLake.Vulkan;


public class VkShaderCodeTypeEXTHandle : BaseSafeHandle
{
}


public static class VkShaderCodeTypeEXTExtensions
{

	public static VkShaderCodeTypeEXT Dereference(this VkShaderCodeTypeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderCodeTypeEXT>(x.DangerousGetHandle());
}
internal class VkShaderCodeTypeEXTExterns
{
}


public struct VkShaderCodeTypeEXT
{
}
