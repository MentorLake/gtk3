namespace MentorLake.Vulkan;

public class VkCoarseSampleOrderCustomNVHandle : BaseSafeHandle
{
}


public static class VkCoarseSampleOrderCustomNVExtensions
{

	public static VkCoarseSampleOrderCustomNV Dereference(this VkCoarseSampleOrderCustomNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCoarseSampleOrderCustomNV>(x.DangerousGetHandle());
}
internal class VkCoarseSampleOrderCustomNVExterns
{
}

public struct VkCoarseSampleOrderCustomNV
{
}
