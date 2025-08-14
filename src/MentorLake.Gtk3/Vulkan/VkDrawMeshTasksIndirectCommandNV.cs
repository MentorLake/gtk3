namespace MentorLake.Vulkan;


public class VkDrawMeshTasksIndirectCommandNVHandle : BaseSafeHandle
{
}


public static class VkDrawMeshTasksIndirectCommandNVExtensions
{

	public static VkDrawMeshTasksIndirectCommandNV Dereference(this VkDrawMeshTasksIndirectCommandNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDrawMeshTasksIndirectCommandNV>(x.DangerousGetHandle());
}
internal class VkDrawMeshTasksIndirectCommandNVExterns
{
}


public struct VkDrawMeshTasksIndirectCommandNV
{
}
