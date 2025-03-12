namespace FaceDetectAPI.Services;

public interface IDetectFaceService
{
    Task<string> DetectFace(IFormFile file);
}