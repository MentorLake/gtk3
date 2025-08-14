namespace MentorLake.Vulkan;


public class VkDrawMeshTasksIndirectCommandEXTHandle : BaseSafeHandle
{
}


public static class VkDrawMeshTasksIndirectCommandEXTExtensions
{

	public static VkDrawMeshTasksIndirectCommandEXT Dereference(this VkDrawMeshTasksIndirectCommandEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDrawMeshTasksIndirectCommandEXT>(x.DangerousGetHandle());
}
internal class VkDrawMeshTasksIndirectCommandEXTExterns
{
}


public struct VkDrawMeshTasksIndirectCommandEXT
{
}
