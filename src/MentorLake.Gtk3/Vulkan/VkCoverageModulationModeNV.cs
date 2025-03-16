namespace MentorLake.Vulkan;

public class VkCoverageModulationModeNVHandle : BaseSafeHandle
{
}


public static class VkCoverageModulationModeNVExtensions
{

	public static VkCoverageModulationModeNV Dereference(this VkCoverageModulationModeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCoverageModulationModeNV>(x.DangerousGetHandle());
}
internal class VkCoverageModulationModeNVExterns
{
}

public struct VkCoverageModulationModeNV
{
}
