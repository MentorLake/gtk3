namespace MentorLake.Vulkan;

public class VkCheckpointDataNVHandle : BaseSafeHandle
{
}


public static class VkCheckpointDataNVExtensions
{

	public static VkCheckpointDataNV Dereference(this VkCheckpointDataNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCheckpointDataNV>(x.DangerousGetHandle());
}
internal class VkCheckpointDataNVExterns
{
}

public struct VkCheckpointDataNV
{
}
