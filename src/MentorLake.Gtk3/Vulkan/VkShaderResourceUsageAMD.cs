namespace MentorLake.Vulkan;


public class VkShaderResourceUsageAMDHandle : BaseSafeHandle
{
}


public static class VkShaderResourceUsageAMDExtensions
{

	public static VkShaderResourceUsageAMD Dereference(this VkShaderResourceUsageAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderResourceUsageAMD>(x.DangerousGetHandle());
}
internal class VkShaderResourceUsageAMDExterns
{
}


public struct VkShaderResourceUsageAMD
{
}
