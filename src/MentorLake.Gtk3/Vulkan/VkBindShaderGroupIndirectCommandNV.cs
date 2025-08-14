namespace MentorLake.Vulkan;


public class VkBindShaderGroupIndirectCommandNVHandle : BaseSafeHandle
{
}


public static class VkBindShaderGroupIndirectCommandNVExtensions
{

	public static VkBindShaderGroupIndirectCommandNV Dereference(this VkBindShaderGroupIndirectCommandNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindShaderGroupIndirectCommandNV>(x.DangerousGetHandle());
}
internal class VkBindShaderGroupIndirectCommandNVExterns
{
}


public struct VkBindShaderGroupIndirectCommandNV
{
}
