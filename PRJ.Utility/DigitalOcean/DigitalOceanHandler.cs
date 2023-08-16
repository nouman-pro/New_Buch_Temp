using Amazon.S3;
using Amazon.S3.Model;
using PRJ.Utility.OutputData;

namespace PRJ.Utility.DigitalOcean;

public class DigitalOceanHandler
{
    private static IAmazonS3 client;
    private const double DURATION = 24;

    public static async Task<OutputDTO<DigitalOceanDTO>> UploadBase64(string path, string fileName, string extension)
    {
        var s3ClientConfig = new AmazonS3Config
        {
            ServiceURL = DigitalOceanConfiguration.EndPointURL
        };

        client = new AmazonS3Client(DigitalOceanConfiguration.Access_key, DigitalOceanConfiguration.Secret_Key, s3ClientConfig);

        string keyName = DateTime.Now.ToString("ddMMyyyyHHmmss") + "_" + fileName + "." + extension;
        string base64string = path.Replace("data:image/jpeg;base64,", "").Replace("data:image/png;base64,", "").Replace("data:image/gif;base64,", "").Replace("data:image/bmp;base64,", "").Replace("data:application/pdf;base64,", "");

        byte[] bytes = Convert.FromBase64String(base64string);
        var request = new PutObjectRequest
        {
            BucketName = DigitalOceanConfiguration.BucketName,
            Key = keyName,
        };

        PutObjectResponse response;
        using (var ms = new MemoryStream(bytes))
        {
            request.InputStream = ms;
            response = await client.PutObjectAsync(request);
        }

        var obj = new DigitalOceanDTO()
        {
            KeyName = keyName,
            BaseUrl = await GetPhotoURL(keyName)
        };

        // return obj;
        return Output.Handler<DigitalOceanDTO>(ResponseCode.RECORD_CREATE, obj);

    }

    public static async Task<OutputDTO<string>> GetURL(string key)
    {
        var s3ClientConfig = new AmazonS3Config
        {
            ServiceURL = DigitalOceanConfiguration.EndPointURL
        };

        client = new AmazonS3Client(DigitalOceanConfiguration.Access_key, DigitalOceanConfiguration.Secret_Key, s3ClientConfig);

        var request = new GetPreSignedUrlRequest
        {
            BucketName = DigitalOceanConfiguration.BucketName,
            Key = key,
            //Verb = HttpVerb.GET,
            Expires = DateTime.UtcNow.AddDays(3)
        };
        return Output.Handler(ResponseCode.GET, client.GetPreSignedURL(request));
    }

    public static async Task<string> GetPhotoURL(string key)
    {
        if (!(key is null || key is ""))
        {
            var s3ClientConfig = new AmazonS3Config
            {
                ServiceURL = DigitalOceanConfiguration.EndPointURL
            };

            client = new AmazonS3Client(DigitalOceanConfiguration.Access_key, DigitalOceanConfiguration.Secret_Key, s3ClientConfig);

            var request = new GetPreSignedUrlRequest
            {
                BucketName = DigitalOceanConfiguration.BucketName,
                Key = key,
                //Verb = HttpVerb.GET,
                Expires = DateTime.UtcNow.AddDays(3)
            };


            var s3Object = client.GetPreSignedURL(request);

            return s3Object;
        }

        return null;
    }

    //public static string GetPhotoURLS(string key)
    //{
    //    if (!(key is null || key is ""))
    //    {
    //        var request = new GetPreSignedUrlRequest
    //        {
    //            BucketName = DigitalOceanConfiguration.BucketName,
    //            Key = key,
    //            //Verb = HttpVerb.GET,
    //            Expires = DateTime.UtcNow.AddHours(DURATION)
    //        };

    //        return client.GetPreSignedURL(request);

    //    }

    //    return null;
    //}
    public static string GetPhotoURLS(string key)
    {
        if (!(key is null || key is ""))
        {
            var s3ClientConfig = new AmazonS3Config
            {
                ServiceURL = DigitalOceanConfiguration.EndPointURL
            };

            client = new AmazonS3Client(DigitalOceanConfiguration.Access_key, DigitalOceanConfiguration.Secret_Key, s3ClientConfig);

            var request = new GetPreSignedUrlRequest
            {
                BucketName = DigitalOceanConfiguration.BucketName,
                Key = key,
                //Verb = HttpVerb.GET,
                Expires = DateTime.UtcNow.AddDays(3)
            };


            var s3Object = client.GetPreSignedURL(request);

            return s3Object;
        }

        return null;
    }
}
