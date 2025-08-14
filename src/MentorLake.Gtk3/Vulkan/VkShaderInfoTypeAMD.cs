namespace MentorLake.Vulkan;


public class VkShaderInfoTypeAMDHandle : BaseSafeHandle
{
}


public static class VkShaderInfoTypeAMDExtensions
{

	public static VkShaderInfoTypeAMD Dereference(this VkShaderInfoTypeAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderInfoTypeAMD>(x.DangerousGetHandle());
}
internal class VkShaderInfoTypeAMDExterns
{
}


public struct VkShaderInfoTypeAMD
{
}
