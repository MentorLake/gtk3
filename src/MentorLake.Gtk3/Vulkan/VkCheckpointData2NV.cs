namespace MentorLake.Vulkan;

public class VkCheckpointData2NVHandle : BaseSafeHandle
{
}


public static class VkCheckpointData2NVExtensions
{

	public static VkCheckpointData2NV Dereference(this VkCheckpointData2NVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCheckpointData2NV>(x.DangerousGetHandle());
}
internal class VkCheckpointData2NVExterns
{
}

public struct VkCheckpointData2NV
{
}
