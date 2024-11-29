using RestMatch.Azure.BlobStorage.Dto;

namespace RestMatch.Azure.BlobStorage
{
    public interface IAzureStorage
    {
        Task<BlobResponseDto> DeleteAsync(string blobFilename, ContainerEnum containerType);
        Task<BlobResponseDto> UploadAsync(byte[] blob, string fileName, ContainerEnum containerType);
    }
}