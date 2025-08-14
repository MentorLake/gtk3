namespace MentorLake.Vulkan;


public class VkShaderStatisticsInfoAMDHandle : BaseSafeHandle
{
}


public static class VkShaderStatisticsInfoAMDExtensions
{

	public static VkShaderStatisticsInfoAMD Dereference(this VkShaderStatisticsInfoAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderStatisticsInfoAMD>(x.DangerousGetHandle());
}
internal class VkShaderStatisticsInfoAMDExterns
{
}


public struct VkShaderStatisticsInfoAMD
{
}
